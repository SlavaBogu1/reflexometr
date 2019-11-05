using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// add MySQL suport
// Don't forget to add reference to MySQL.Data.dll into project.
using MySql.Data;
using MySql.Data.MySqlClient;
// useful MySQL
/*
    https://dev.mysql.com/doc/refman/8.0/en/delete.html
    ALTER TABLE tablename AUTO_INCREMENT = 1
   
  
 */



//Arduino
using System.Timers;
using System.IO.Ports;
using System.Threading;

//JSON https://www.newtonsoft.com/json
using Newtonsoft.Json;

namespace Reflexes_UI
{
    public partial class MainApp : Form
    {

        // CONFIG
        // application parameters
        private bool DB_autoload_enabled = false;
        // -CONFIG
        
        //MySQL
        // local DB connection and other MySQL objects
        public MySqlConnection conn;
        public MySqlDataReader mysqlReader = null;
        public MySqlDataAdapter mysqlAdapter = null;
        //-MySQL

        //Arduino
        public static SerialPort port;
        private System.Timers.Timer aTimer;
        private int tick_1, tick_2, communication_round_delta;
        delegate void SetTextCallback(string text);
        private BackgroundWorker hardWorker;
        private Thread readThread = null;
        //-Arduino

        // Участники
        struct participants
        {
            string name;
            int button_id;
            int screen_id;
            int db_id;
            int msec;
            
            // задать id из базы данных
            public int db_id_access
            {
                get { return db_id; }
                set { db_id = value; }
            }

            // задать id из на экране
            public int screen_id_access
            {
                get { return screen_id; }
                set { screen_id = value; }
            }

            // задать id привязанной кнопки
            public int button_id_access
            {
                get { return button_id; }
                set { button_id = value; }
            }

            // задать длительность реакции
            public int msec_access
            {
                get { return msec; }
                set { msec = value; }
            }

            // задать имя
            public string name_access
            {
                get { return name; }
                set { name = value; }
            }
        }
        participants[] array_of_participants;
        int selected_participant = 0; // никто не выбран для редактирования
        int participant_count = 0;
        //-участники

        //flags
        static bool first_connect = true;
        static bool test_is_in_progress = false;
        static bool the_first = false;
        string test_description;
        //-flags

        public MainApp()
        {
            InitializeComponent();

            array_of_participants = new participants[5];
            ClearArrayOfParticipant();
            
            hardWorker = new BackgroundWorker();
            CreateTimer();
        }
        private void ClearArrayOfParticipant()
        {
            for (int i = 0; i < 5; i++)
            {
                array_of_participants[i].button_id_access = -1;
                array_of_participants[i].db_id_access = -1;
                array_of_participants[i].screen_id_access = -1;
                participant_count = 0;
                selected_participant = 0;
            }
                
        }

        private void CreateTimer()
        {
            // Create a timer with a two second interval.
            Random random = new Random();
            int delay = random.Next(1200, 7000);

            aTimer = new System.Timers.Timer(delay);
            // Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = false;
            aTimer.Enabled = false;

        }
        private void StartTimer()
        {
            // Create a timer with a two second interval.
            Random random = new Random();
            int delay = random.Next(1200, 7000);

            aTimer.Interval = delay;
            aTimer.Start();
            //tick_1 = Environment.TickCount & Int32.MaxValue;
            splitContainer3.Panel1.BackColor = Color.Red;
        }

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            StartTest();
        }

        private void StartTest()
        {
            //начало отсчета в ардуино
            if (port.IsOpen) {
                port.Write("1");
                tick_1 = Environment.TickCount & Int32.MaxValue;
            }            
            splitContainer3.Panel1.BackColor =  Color.Green;

            //если задано количество повторов - перезапустить таймер через 2-6 сек.
            if (repeat_test_number_updown.Value > 1)
            {
                Random random = new Random();
                int delay = random.Next(2000, 6000);
                Thread.Sleep(delay);
                //StartTimer();
                StartTest_button_Click(null, null);

                // Используем Invoke для получения данных из потока чтения из USB
                if (repeat_test_number_updown.InvokeRequired)
                {
                    repeat_test_number_updown.Invoke((MethodInvoker)delegate { repeat_test_number_updown.DownButton(); });
                }
                else
                {
                    repeat_test_number_updown.DownButton();
                }                                    
            }
            else
            {
                Thread.Sleep(3000);
                UserMessage("Тест завершен");
                ClearResultLabels();
                if (StartTest_button.InvokeRequired)
                {
                    StartTest_button.Invoke((MethodInvoker)delegate { StartTest_button.Enabled = true; });
                    repeat_test_number_updown.Invoke((MethodInvoker)delegate { repeat_test_number_updown.Enabled = true; });
                    splitContainer3.Invoke((MethodInvoker)delegate { splitContainer3.Panel1.BackColor = Color.LightGray; });

                }
                else
                {
                    StartTest_button.Enabled = true;
                    repeat_test_number_updown.Enabled = true;
                    splitContainer3.Panel1.BackColor = Color.LightGray;
                }

            }
        }



        public bool Is_DB_autoload_enabled() {
            return DB_autoload_enabled;
        }

        private void App_Exit_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Help_About_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 ab = new AboutBox1();
            ab.ShowDialog();
        }

        private void DB_edit_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DB_viewer db_edit = new DB_viewer();
            db_edit.Owner = this;
            db_edit.ShowDialog();
        }

        private void DB_config_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DB_config_Form db_config = new DB_config_Form();
            db_config.ShowDialog();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            splitContainer3.SplitterDistance = splitContainer2.Width - 500; //боковые пустые панели по 250 px
            LogMessage("Начало работы: " + DateTime.Now.ToString("dd-MMM-yy h:mm:ss"));

            Load_Application_Parameters();
            LogMessage("Параметры загружены");

            if (Is_DB_autoload_enabled()) {
                Connect_to_DB(GetDB_address_string());
                ReadDB_tables();
            } else {
                UserMessage("Вам требуется подключиться к базе данных. Используйте меню 'База Данных' ");
            }

            UserMessage("Проверьте, что рефлесометр подключен к компьютеру кабелем и нажмите 'Подключить'");
            Arduino_Connection_Config();
        }

        private void Arduino_Connection_Config()
        {
            int index = 0;
            foreach (string s in SerialPort.GetPortNames()) {
                comPort.Items.Add(s);
                comPort.SelectedIndex = index++; //selec the last one
            }
            if (comPort.Items.Count ==0) {
                UserMessage("Рефлексометр не подключен");
                LogMessage("Рефлексометр не подключен");
            }

            baudRate.Items.Add("2400");
            baudRate.Items.Add("4800");
            baudRate.Items.Add("9600");
            baudRate.Items.Add("14400");
            baudRate.Items.Add("19200");
            baudRate.Items.Add("28800");
            baudRate.Items.Add("38400");
            baudRate.Items.Add("57600");
            baudRate.Items.Add("115200");

            baudRate.SelectedIndex = 7;
        }

        private async void ReadDB_tables()
        {
            // Прочитать таблицы из DB
            // tests - описания тестов. HARDCODED 
            // results - предыдущие результаты
            // resources - список участников. Из него подготовить Suggestions.

            // список фамилий для выбора в окне редактирования
            var resource_name_collection = new AutoCompleteStringCollection();

            // читать всех участников
            MySqlCommand mysqlcommand = new MySqlCommand("SELECT * FROM resources;", conn);
            LogMessage(mysqlcommand.CommandText);

            try
            {
                mysqlReader = mysqlcommand.ExecuteReader();

                while (await mysqlReader.ReadAsync())
                {
                    /*SelectResult_listbox.Items.Add(Convert.ToString(mysqlReader["id"]) + "     "
                        + Convert.ToString(mysqlReader["birth"]) + "     "
                        + Convert.ToString(mysqlReader["lname"]) + "     "
                        + Convert.ToString(mysqlReader["fname"]) + "     "
                        + Convert.ToString(mysqlReader["mname"]) + "     "
                        + Convert.ToString(mysqlReader["title"]) + "     "
                        + Convert.ToString(mysqlReader["tags"]));*/
                    char fname_1 = Convert.ToString(mysqlReader["fname"])[0];
                    char mname_1 = Convert.ToString(mysqlReader["mname"])[0];
                    resource_name_collection.Add(Convert.ToString(mysqlReader["lname"]) + ". "+ fname_1 + "." + mname_1 + "." + " [" + Convert.ToString(mysqlReader["id"] + "]"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (mysqlReader != null) mysqlReader.Close();
            }

            //заполнить список имен для авто-подстановки
            // формат:  Фамилия И.О. [db_id]
            if (resource_name_collection.Count > 0)
            {
                resource_name_textbox_1.AutoCompleteCustomSource = resource_name_collection;
                resource_name_textbox_2.AutoCompleteCustomSource = resource_name_collection;
                resource_name_textbox_3.AutoCompleteCustomSource = resource_name_collection;
                resource_name_textbox_4.AutoCompleteCustomSource = resource_name_collection;
                resource_name_textbox_5.AutoCompleteCustomSource = resource_name_collection;
            }

            //прочитать список тестов
            mysqlcommand.CommandText = "SELECT * FROM tests;";
            LogMessage(mysqlcommand.CommandText);
            try
            {
                mysqlReader = mysqlcommand.ExecuteReader();

                while (await mysqlReader.ReadAsync())
                {
                    Test_list_comboBox.Items.Add(Convert.ToString(mysqlReader["test_name"]));
                    test_description = Convert.ToString(mysqlReader["description"]);
                }
                Test_list_comboBox.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (mysqlReader != null) mysqlReader.Close();
            }
        }

        private async void Connect_to_DB(string db_address) {
            if (db_address == null) { //Надо задать пароль вместо вопросов ниже. Надо сделать динамический пароь через параметры. TODO
                db_address = "server=localhost;user=slava;database=secundomer;port=3306;password=?????????;Character Set=utf8;"; 
            }
            conn = new MySqlConnection(db_address);

            try {
                LogMessage("Подключаемся к базе данных ...");
                await conn.OpenAsync();
                // Управление пунктами меню
                DB_edit_ToolStripMenuItem.Enabled = true;
            } catch (Exception ex) {
                LogMessage(ex.ToString());
                conn.Close();
                // Управление пунктами меню
                DB_edit_ToolStripMenuItem.Enabled = false;
            }
            LogMessage("Приложение готово к работе");

        }


        private void LogMessage(string msg) {
            if (!Log_view_enabled.Checked) {
                
                // Используем Invoke для получения данных из потока чтения из USB
                if (log_listView.InvokeRequired) {
                    log_listView.Invoke( (MethodInvoker) delegate { log_listView.AppendText(msg + System.Environment.NewLine); });
                } else {
                    log_listView.AppendText(msg + System.Environment.NewLine);
                }
            }
        }

        private void UserMessage(string msg) {
            // Используем Invoke для получения данных из потока чтения из USB            
            if (UserMessage_label.InvokeRequired){
                UserMessage_label.Invoke((MethodInvoker)delegate { UserMessage_label.Text = msg; });
            } else {
                UserMessage_label.Text = msg;
            }
            
        }

        

        private void Load_Application_Parameters() {
            //сейчас просто захардкодим параметры
            //потом будем их читать из реестра
            DB_autoload_enabled = true;

        }

        private void Log_view_enabled_CheckedChanged(object sender, EventArgs e)
        {
            if (Log_view_enabled.Checked) {
                log_listView.Clear();
                log_listView.Enabled = false;
            } else {
                log_listView.Enabled = true;
            }
        }



        private void DB_disconnect_ToolStripMenuItem_Click_1(object sender, EventArgs e) {
            conn.Close();
            LogMessage("DB закрыта");
            // Управление пунктами меню
            DB_edit_ToolStripMenuItem.Enabled = false;
        }

        private void ArduinoConnect_button_Click(object sender, EventArgs e)
        {

            if (comPort.SelectedItem != null) {
                System.ComponentModel.IContainer components = new System.ComponentModel.Container();
                port = new System.IO.Ports.SerialPort(components);
                port.PortName = comPort.SelectedItem.ToString();
                port.BaudRate = Int32.Parse(baudRate.SelectedItem.ToString());
                port.DtrEnable = true;
                port.ReadTimeout = 5000;
                port.WriteTimeout = 500;
            } else {
                LogMessage("Укажите номер порта для связи с Рефлексометром");
                return;
            }

            try {
                //port.Encoding = ASCIIEncoding;
                port.Open();
            } catch (Exception ex) {
                LogMessage("Невозможно подключиться к Рефлексометру");
                LogMessage(ex.ToString());
            }

            readThread = new Thread(new ThreadStart(this.Read));
            readThread.Start();
            this.hardWorker.RunWorkerAsync();

            ArduinoConnect_button.Enabled = false;
            comPort.Enabled = false;
            baudRate.Enabled = false;
        }

        private void DB_connect_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Подключение по адресу по-умолчанию.
            Connect_to_DB(GetDB_address_string());
        }

        private string GetDB_address_string() {
            // hardcoded for first version
            return "server=localhost;user=slava;database=secundomer;port=3306;password=X7lw4BqmDB;Character Set=utf8;";
        }

        private void MainApp_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (readThread != null) readThread.Abort();
            if (port != null) port.Close(); //если не убить поток, то будет exception - чтение из закрытого порта.
        }

        public void Read() {
            while (port.IsOpen)
            {
                var line = string.Empty;
                var line2 = string.Empty;

                char bchar;
                var sb = new StringBuilder();
                bool json_msg_is_not_complete = true;

                // читаем, пока не получена закрывающая скобка JSON
                while (json_msg_is_not_complete) { 

                    //получена пачка байт
                    while (port.BytesToRead > 0) {
                        var b = port.ReadByte();
                        if (b >= 32 && b < 127) {
                            bchar = (char)b;
                        } else {
                            bchar = ' ';
                        }

                        if (b == 0x7E) {
                            //echo symbol to calculate round-rime
                            tick_2 = Environment.TickCount & Int32.MaxValue;
                            communication_round_delta = tick_2 - tick_1;
                            line2 = $"Communication delay {communication_round_delta} msec";
                            LogMessage(line2 + System.Environment.NewLine);
                            bchar = ' ';
                            if ((communication_round_delta > 100) && (participant_count !=0))
                            {
                                LogMessage("БОЛЬШАЯ ЗАДЕРЖКА ОБМЕНА ДАННЫМИ");
                            }
                        }

                        //добавляем полученные символы в строку
                        if (b != 0x00)
                            sb.Append(bchar);

                        //если получен символ завершения строки - конвертируем накопленные байты в строку
                        if (b == 0x0D) {
                            line = sb.ToString();
                        }
                        if (b == 0x00) {
                            line = sb.ToString();
                        }

                        if (b == 0x7D) {
                            json_msg_is_not_complete = false;
                        }
                        
                    }
                    // пришедшие данные еще не полная JSON строка. Подождем еще.
                    //Иначе зря процессор грузим
                    Thread.Sleep(2);
                }
                if (line.Length != 0) {
                    // multi-line
                    int count = 0;
                    foreach (char c in line) if (c == '{') count++;
                    if (count > 1)
                    {
                        int start_pos = 0;
                        int end_pos = 0;

                        for (int i = 0; i < count; i++)
                        {
                            string json_part;
                            end_pos = line.IndexOf('}', start_pos);
                            json_part = line.Substring(start_pos, end_pos - start_pos + 1);
                            start_pos = end_pos + 2;
                            Process_Data_From_Arduino(json_part);
                        }
                    } else
                    {
                        // single json
                        Process_Data_From_Arduino(line /*+ System.Environment.NewLine*/);
                    }

                    
                }

            }
        }

        private void resource_name_textbox_1_TextChanged(object sender, EventArgs e)
        {
            UserMessage("Участник " + resource_name_textbox_1.Text + " нажмите кнопку");
            resource_name_label_1.Text = "Выберите участника";
            resource_name_label_1.BackColor = Color.LightPink;
            selected_participant = 1;

            //очистить тэги
            tag_textbox_1.Text = "";

        }
        private void resource_name_textbox_2_TextChanged_1(object sender, EventArgs e)
        {
            UserMessage("Участник " + resource_name_textbox_2.Text + " нажмите кнопку");
            resource_name_label_2.Text = "Выберите участника";
            resource_name_label_2.BackColor = Color.LightPink;
            selected_participant = 2;
            
            //очистить тэги
            tag_textbox_2.Text = "";
        }

        private void resource_name_textbox_3_TextChanged_1(object sender, EventArgs e)
        {
            UserMessage("Участник " + resource_name_textbox_3.Text + " нажмите кнопку");
            resource_name_label_3.Text = "Выберите участника";
            resource_name_label_3.BackColor = Color.LightPink;
            selected_participant = 3;

            //очистить тэги
            tag_textbox_3.Text = "";
        }

        private void resource_name_textbox_4_TextChanged_1(object sender, EventArgs e)
        {
            UserMessage("Участник " + resource_name_textbox_4.Text + " нажмите кнопку");
            resource_name_label_4.Text = "Выберите участника";
            resource_name_label_4.BackColor = Color.LightPink;
            selected_participant = 4;

            //очистить тэги
            tag_textbox_4.Text = "";
        }

        private void resource_name_textbox_5_TextChanged_1(object sender, EventArgs e)
        {
            UserMessage("Участник " + resource_name_textbox_5.Text + " нажмите кнопку");
            resource_name_label_5.Text = "Выберите участника";
            resource_name_label_5.BackColor = Color.LightPink;
            selected_participant = 5;

            //очистить тэги
            tag_textbox_5.Text = "";
        }

        private void Process_Data_From_Arduino(string json) {

            Arduino_Message arduino_msg;
            try
            {
                arduino_msg = JsonConvert.DeserializeObject<Arduino_Message>(json);
            } catch (Exception ex)
            {
                LogMessage(json);
                LogMessage(ex.ToString());
                return;
            }

            if (arduino_msg == null) return;

            FirstTimeConnectionToArduino();

            LogMessage("Рефлексометр:");
            switch (arduino_msg.ver)
            {
                case 0:                    
                    LogMessage("Версия 0");
                    break;
                case 1:
                    LogMessage("Версия 1");
                    break;
                default:
                    LogMessage("Протокол связи с Рефлексометром неизвестен");
                    break;
            }

            if (arduino_msg.message != null)
            {
                LogMessage(arduino_msg.message);
                switch (arduino_msg.message)
                {
                    case "Falstart":
                        //два режима
                        // первый - назначение кнопок при старте
                        // второй - определение фальшстарта во время теста
                        if (test_is_in_progress)
                        {
                            Record_Test_Results(arduino_msg);
                            //CreateDB_result_record(arduino_msg.user_id, 1 /* hardcoded*/, "фальшстарт", -1,);
                        } else
                        {
                            if (arduino_msg.user_id != 0)
                            {
                                UpdateArrayOfParticipants(selected_participant, arduino_msg.user_id);
                            }
                        }
                        break;
                    case "result:":
                        //получено сообщение о результате теста
                        // вывести на экран и записать в базу.
                        Record_Test_Results(arduino_msg);
                        break;
                    case "Connection ready.":
                        break;
                    default:
                        break;
                }
            }
            if (arduino_msg.user_id != 0) LogMessage("Участник #" + arduino_msg.user_id.ToString() + "msec: " +arduino_msg.msec.ToString());

        }
        private void Record_Test_Results(Arduino_Message msg)
        {
            string tags = "";

            // вывести на экран
            // по номеру кнопки найти участника
            for (int i =0; i < 5; i++)
            {
                if (array_of_participants[i].button_id_access == -1) continue;

                if (array_of_participants[i].button_id_access == msg.user_id)
                {
                    Color mcol = Color.LightGreen;
                    if (msg.msec == -1)
                    {
                        //the_first = false; //фальшстарт не участвует в отметке первого ответа
                        mcol = Color.Red;
                    }

                    switch (i)
                    {
                        case 0:
                            if (result_label_1.InvokeRequired) {
                                result_label_1.Invoke((MethodInvoker)delegate { result_label_1.Text = msg.msec.ToString(); });
                                tag_textbox_1.Invoke((MethodInvoker)delegate { tags = tag_textbox_1.Text; });

                                if (!the_first)
                                {
                                    the_first = true;
                                    result_label_1.Invoke((MethodInvoker)delegate { result_label_1.BackColor = mcol; });
                                }

                            } else {
                                result_label_1.Text = msg.msec.ToString();
                                tags = tag_textbox_1.Text;

                                if (!the_first)
                                {
                                    the_first = true;
                                    result_label_1.BackColor = mcol;
                                }

                            }
                            break;
                        case 1:                            
                            if (result_label_2.InvokeRequired)
                            {
                                result_label_2.Invoke((MethodInvoker)delegate { result_label_2.Text = msg.msec.ToString(); });
                                tag_textbox_2.Invoke((MethodInvoker)delegate { tags = tag_textbox_2.Text; });

                                if (!the_first )
                                {
                                    the_first = true;                                    
                                    result_label_2.Invoke((MethodInvoker)delegate { result_label_2.BackColor = mcol; });
                                }
                            }
                            else
                            {
                                result_label_2.Text = msg.msec.ToString();
                                tags = tag_textbox_2.Text;

                                if (!the_first)
                                {
                                    the_first = true;
                                    result_label_2.BackColor = mcol;
                                }
                            }
                            break;
                        case 2:
                            if (result_label_3.InvokeRequired)
                            {
                                result_label_3.Invoke((MethodInvoker)delegate { result_label_3.Text = msg.msec.ToString(); });
                                tag_textbox_3.Invoke((MethodInvoker)delegate { tags = tag_textbox_3.Text; });

                                if (!the_first)
                                {
                                    the_first = true;
                                    result_label_3.Invoke((MethodInvoker)delegate { result_label_3.BackColor = mcol; });
                                }
                            }
                            else
                            {
                                result_label_3.Text = msg.msec.ToString();
                                tags = tag_textbox_3.Text;

                                if (!the_first)
                                {
                                    the_first = true;
                                    result_label_3.BackColor = mcol;
                                }
                            }
                            break;
                        case 3:
                            if (result_label_4.InvokeRequired)
                            {
                                result_label_4.Invoke((MethodInvoker)delegate { result_label_4.Text = msg.msec.ToString(); });
                                tag_textbox_4.Invoke((MethodInvoker)delegate { tags = tag_textbox_4.Text; });

                                if (!the_first)
                                {
                                    the_first = true;
                                    result_label_4.Invoke((MethodInvoker)delegate { result_label_4.BackColor = mcol; });
                                }
                            }
                            else
                            {
                                result_label_4.Text = msg.msec.ToString();
                                tags = tag_textbox_4.Text;

                                if (!the_first)
                                {
                                    the_first = true;
                                    result_label_4.BackColor = mcol;
                                }
                            }
                            break;
                        case 4:
                            if (result_label_5.InvokeRequired)
                            {
                                result_label_5.Invoke((MethodInvoker)delegate { result_label_5.Text = msg.msec.ToString(); });
                                tag_textbox_5.Invoke((MethodInvoker)delegate { tags = tag_textbox_5.Text; });

                                if (!the_first)
                                {
                                    the_first = true;
                                    result_label_1.Invoke((MethodInvoker)delegate { result_label_5.BackColor = mcol; });
                                }
                            }
                            else
                            {
                                result_label_5.Text = msg.msec.ToString();
                                tags = tag_textbox_5.Text;

                                if (!the_first)
                                {
                                    the_first = true;
                                    result_label_5.BackColor = mcol;
                                }
                            }
                            break;
                        default:
                            break;
                    }

                    if (msg.msec == -1)
                    {
                        the_first = false; //фальшстарт не участвует в отметке первого ответа
                    }

                    //TBD test_id hardcoded == 1
                    CreateDB_result_record(array_of_participants[i].db_id_access, 1 /* test_id*/ , msg.message, msg.msec, tags);
                }
            }            
        }

        private void ClearResultLabels()
        {
            if (result_label_1.InvokeRequired) {
                result_label_1.Invoke((MethodInvoker)delegate { result_label_1.Text = ""; result_label_1.BackColor = Color.LightGray; });                
            } else {
                result_label_1.Text = "";
                result_label_1.BackColor = Color.LightGray;
            }
            if (result_label_2.InvokeRequired)
            {
                result_label_2.Invoke((MethodInvoker)delegate { result_label_2.Text = ""; result_label_2.BackColor = Color.LightGray; });                
            }
            else
            {
                result_label_2.Text = "";
                result_label_2.BackColor = Color.LightGray;
            }
            if (result_label_3.InvokeRequired)
            {
                result_label_3.Invoke((MethodInvoker)delegate { result_label_3.Text = ""; result_label_3.BackColor = Color.LightGray; });                
            }
            else
            {
                result_label_3.Text = "";
                result_label_3.BackColor = Color.LightGray;
            }
            if (result_label_4.InvokeRequired)
            {
                result_label_4.Invoke((MethodInvoker)delegate { result_label_4.Text = ""; result_label_4.BackColor = Color.LightGray; });                
            }
            else
            {
                result_label_4.Text = "";
                result_label_4.BackColor = Color.LightGray;
            }
            if (result_label_5.InvokeRequired)
            {
                result_label_5.Invoke((MethodInvoker)delegate { result_label_5.Text = ""; result_label_5.BackColor = Color.LightGray; });                
            }
            else
            {
                result_label_5.Text = "";
                result_label_5.BackColor = Color.LightGray;
            }
        }

        private async void CreateDB_result_record(int db_res_id, int current_test_id, string test_msg, int result_msec, string tag )
        {
            MySqlCommand mysqlcommand = new MySqlCommand("INSERT INTO results (data,resource_id,test_id,result_txt,result_msec,tags) VALUES (@res_date,@res_id,@test_id,@res_txt,@res_msec,@tags);", conn);
            mysqlcommand.Parameters.AddWithValue("res_date", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            mysqlcommand.Parameters.AddWithValue("res_id", db_res_id.ToString() );
            mysqlcommand.Parameters.AddWithValue("test_id", current_test_id.ToString() );
            mysqlcommand.Parameters.AddWithValue("res_txt", test_msg ); 
            mysqlcommand.Parameters.AddWithValue("res_msec", result_msec.ToString() );
            mysqlcommand.Parameters.AddWithValue("tags", tag);
            
            await mysqlcommand.ExecuteNonQueryAsync();
        }




        private void UpdateArrayOfParticipants(int id, int arduino_id )
        {
            if (id == 0) //не назначен пользователь
            {
                UserMessage("ВЫ НЕ ВВЕЛИ ИМЕНА УЧАСТНИКОВ");
                return;
            }

            array_of_participants[id - 1].button_id_access = arduino_id;
            
            array_of_participants[id - 1].screen_id_access = id;
            array_of_participants[id - 1].name_access = GetResourceName(id - 1, arduino_id);

            // взять индекс DB из имени [] 
            int str_len = array_of_participants[id - 1].name_access.Length;
            int id_index = array_of_participants[id - 1].name_access.IndexOf("[", 1, str_len - 1);
            array_of_participants[id - 1].db_id_access = int.Parse(array_of_participants[id - 1].name_access[id_index + 1].ToString());

            //просто флаг для того, чтобы не показывать сооьщение о большой задержке, если нет участников
            //может потом еще для чего пригодится
            participant_count++;
        }

        private void FirstTimeConnectionToArduino()
        {
            if (!first_connect) return;
            if (ArduinoConnect_button.InvokeRequired)
            {
                ArduinoConnect_button.Invoke((MethodInvoker)delegate
                {
                    ArduinoConnect_button.Text = "Подключен";
                    ArduinoConnect_button.BackColor = Color.LightGreen;
                    resource_name_textbox_1.Enabled = true;
                    resource_name_textbox_2.Enabled = true;
                    resource_name_textbox_3.Enabled = true;
                    resource_name_textbox_4.Enabled = true;
                    resource_name_textbox_5.Enabled = true;
                    UserMessage("Выберите имена участников теста");
                });
            }
            else
            {
                ArduinoConnect_button.Text = "Подключен";
                ArduinoConnect_button.BackColor = Color.LightGreen;
                resource_name_textbox_1.Enabled = true;
                resource_name_textbox_2.Enabled = true;
                resource_name_textbox_3.Enabled = true;
                resource_name_textbox_4.Enabled = true;
                resource_name_textbox_5.Enabled = true;
                UserMessage("Выберите имена участников теста");
            }
            first_connect = false;
            if (port.IsOpen)
            {
                port.Write("2"); //light on
            }
        }

        private void StartTest_button_Click(object sender, EventArgs e)
        {
            string sendtext = "5"; // команда для ардуино - подготовиться к тесту.
            test_is_in_progress = true;

            if (port.IsOpen)
            {
                port.Write(sendtext);
                tick_1 = Environment.TickCount & Int32.MaxValue;
            }
            // запуск теста
            StartTimer();
            StartTest_button.Enabled = false;
            repeat_test_number_updown.Enabled = false;

            //прочитать описание теста и вывести его на экран
            UserMessage(test_description);
            ClearResultLabels();

            // флаг определять кто первый нажал
            the_first = false;

        }

        private void Test_list_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //TBD заглушка, пока не реализовано.

            //прочитать описание теста при смене и вывести его на экран
            UserMessage(test_description);
        }

        private void restart_button_Click(object sender, EventArgs e)
        {
            // вернуть приложение в исходное состояние
            if (port == null) Application.Restart();

            if (port.IsOpen){port.Write("3"); /*light off*/}
            //ClearArrayOfParticipant();
            //ClearFlags();
            
            //не париться пока с очисткой и перерисовкой. просто перезапустимся
            Application.Restart();
            //if (port.IsOpen){port.Write("2"); /*light on*/}

        }
        private void ClearFlags() {
            first_connect = true;
            test_is_in_progress = false;
            the_first = false;
        }


        private void ResetTest_button_Click(object sender, EventArgs e)
        {
            //остановить выполнение теста
            // послать команду "4"
            if (port.IsOpen)
            {
                port.Write("4"); //сброс всех флагов на Arduino. Запуск теста заново


            }
        }

        private void DB_parameters_menu_Click(object sender, EventArgs e)
        {
            DB_parameters db_par = new DB_parameters();
            db_par.ShowDialog();
        }

        private string GetResourceName(int id, int arduino_id)
        {
            string name = "";
            switch (id)
            {
                case 0:
                    if (resource_name_textbox_1.InvokeRequired)
                    {
                        resource_name_textbox_1.Invoke((MethodInvoker)delegate
                        {
                            name = resource_name_textbox_1.Text;
                            resource_name_label_1.BackColor = Color.LightGreen;
                            resource_name_label_1.Text = "Кнопка #" + arduino_id.ToString();
                            resource_name_textbox_1.Enabled = false;
                        });
                    }
                    else
                    {
                        name = resource_name_textbox_1.Text;
                        resource_name_label_1.BackColor = Color.LightGreen;
                        resource_name_label_1.Text = "Кнопка #" + arduino_id.ToString();
                        resource_name_textbox_1.Enabled = false;                        
                    };
                    break;
                case 1:
                    if (resource_name_textbox_2.InvokeRequired) {
                        resource_name_textbox_2.Invoke((MethodInvoker)delegate
                        {
                            name = resource_name_textbox_2.Text;
                            resource_name_label_2.BackColor = Color.LightGreen;
                            resource_name_label_2.Text = "Кнопка #" + arduino_id.ToString();
                            resource_name_textbox_2.Enabled = false;
                        });
                    } else
                    {
                        name = resource_name_textbox_2.Text;
                        resource_name_label_2.BackColor = Color.LightGreen;
                        resource_name_label_2.Text = "Кнопка #" + arduino_id.ToString();
                        resource_name_textbox_2.Enabled = false;
                    };
                    break;
                case 2:
                    if (resource_name_textbox_3.InvokeRequired)
                    {
                        resource_name_textbox_3.Invoke((MethodInvoker)delegate
                        {
                            name = resource_name_textbox_3.Text;
                            resource_name_label_3.BackColor = Color.LightGreen;
                            resource_name_label_3.Text = "Кнопка #" + arduino_id.ToString();
                            resource_name_textbox_3.Enabled = false;
                        });
                    }
                    else
                    {
                        name = resource_name_textbox_3.Text;
                        resource_name_label_3.BackColor = Color.LightGreen;
                        resource_name_label_3.Text = "Кнопка #" + arduino_id.ToString();
                        resource_name_textbox_3.Enabled = false;
                    };
                    break;
                case 3:
                    if (resource_name_textbox_4.InvokeRequired)
                    {
                        resource_name_textbox_4.Invoke((MethodInvoker)delegate
                        {
                            name = resource_name_textbox_4.Text;
                            resource_name_label_4.BackColor = Color.LightGreen;
                            resource_name_label_4.Text = "Кнопка #" + arduino_id.ToString();
                            resource_name_textbox_4.Enabled = false;

                        });
                    }
                    else
                    {
                        name = resource_name_textbox_4.Text;
                        resource_name_label_4.BackColor = Color.LightGreen;
                        resource_name_label_4.Text = "Кнопка #" + arduino_id.ToString();
                        resource_name_textbox_4.Enabled = false;
                    };
                    break;
                case 4:
                    if (resource_name_textbox_5.InvokeRequired)
                    {
                        resource_name_textbox_5.Invoke((MethodInvoker)delegate
                        {
                            name = resource_name_textbox_5.Text;
                            resource_name_label_5.BackColor = Color.LightGreen;
                            resource_name_label_5.Text = "Кнопка #" + arduino_id.ToString();
                            resource_name_textbox_5.Enabled = false;
                        });
                    }
                    else
                    {
                        name = resource_name_textbox_5.Text;
                        resource_name_label_5.BackColor = Color.LightGreen;
                        resource_name_label_5.Text = "Кнопка #" + arduino_id.ToString();
                        resource_name_textbox_5.Enabled = false;
                    };
                    break;
                default:
                    name = "";
                    break;                
            }
            UserMessage("Участник " + name + "кнопка #" + arduino_id.ToString());
            return name;
        }


        public class Arduino_Message
        {
            public int ver { get; set; }
            public string message { get; set; }
            public int user_id { get; set; }
            public int msec { get; set; }
        }
    }
}
