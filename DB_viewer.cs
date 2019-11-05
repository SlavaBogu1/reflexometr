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

namespace Reflexes_UI
{
    
    public partial class DB_viewer : Form
    {
        private MainApp main_form;

        public DB_viewer()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            main_form = this.Owner as MainApp;
            if (main_form != null)
            {
                // заполнить таблицу из DB
                if (main_form.conn.State ==ConnectionState.Open)
                {
                    using (main_form.mysqlAdapter = new MySqlDataAdapter("SELECT * FROM resources", main_form.conn))
                    using (DataTable dtbl = new DataTable())
                    {
                        main_form.mysqlAdapter.Fill(dtbl);
                        dataGridView_resources.DataSource = dtbl;
                    }

                }
            }
            
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            tabControl1_Update();
        }

        private void tabControl1_Update()
        {
            int i = tabControl1.SelectedIndex;
            DataGridView dgrv = null;

            main_form = this.Owner as MainApp;
            if (main_form != null)
            {
                string my_select;

                switch(i){
                    case 0:
                        my_select = "SELECT * FROM resources";
                        dgrv = dataGridView_resources;
                        break;
                    case 1:
                        my_select = "SELECT * FROM results";
                        dgrv = dataGridView_results;
                        break;
                    case 2:
                        my_select = "SELECT * FROM tests";
                        dgrv = dataGridView_tests;
                        break;
                    default:
                        return;
                }

                using (main_form.mysqlAdapter = new MySqlDataAdapter(my_select, main_form.conn))
                using (DataTable dtbl = new DataTable())
                {
                    main_form.mysqlAdapter.Fill(dtbl);
                    dgrv.DataSource = dtbl;
                }
            }
        }

        private async void Save_DB_to_CSV_button_Click(object sender, EventArgs e)
        {
            /*
             * 
             *https://stackoverflow.com/questions/356578/how-to-output-mysql-query-results-in-csv-format
            SELECT order_id, product_name, qty
            FROM orders
            WHERE foo = 'bar'
            INTO OUTFILE '/var/lib/mysql-files/orders.csv'
            FIELDS TERMINATED BY ','
            ENCLOSED BY '"'
            LINES TERMINATED BY '\n';
            */
            main_form = this.Owner as MainApp;
            string save_tests_command = "";
            string dbase_name="";
           
            int i = tabControl1.SelectedIndex;

                switch (i)
                {
                    case 0:
                        dbase_name = "resources";
                        save_tests_command = "SELECT id,birth,fname,lname,mname,title FROM resources INTO OUTFILE @file_name FIELDS TERMINATED BY ',' ENCLOSED BY '\"' LINES TERMINATED BY '\n'; ";
                        break;
                    case 1:
                        dbase_name = "results";
                        save_tests_command = "SELECT id,data,resource_id,test_id,result_txt,result_msec,tags FROM results INTO OUTFILE @file_name FIELDS TERMINATED BY ',' ENCLOSED BY '\"' LINES TERMINATED BY '\n'; ";
                        break;
                    case 2:
                        dbase_name = "tests";
                        save_tests_command = "SELECT id,description,test_script,test_name FROM tests INTO OUTFILE @file_name FIELDS TERMINATED BY ',' ENCLOSED BY '\"' LINES TERMINATED BY '\n'; ";
                        break;
                    default:
                        break;

                }
            string file_name = Application.StartupPath + "\\" + dbase_name + "_" + System.DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss") + ".csv";            
            using (MySqlCommand mysqlcommand = new MySqlCommand(save_tests_command, main_form.conn))
            {
                mysqlcommand.Parameters.AddWithValue("file_name", file_name);

                /* просмотр SQL команды после замены параметров
                string tmp = mysqlcommand.CommandText.ToString();
                foreach (MySqlParameter p in mysqlcommand.Parameters)
                {
                    tmp = tmp.Replace('@' + p.ParameterName.ToString(), "'" + p.Value.ToString() + "'");
                }
                */
                await mysqlcommand.ExecuteNonQueryAsync();
            }
        }

        private void dataGridView_resources_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = tabControl1.SelectedIndex;
            DataGridView dgv = sender as DataGridView;

            int row = dgv.SelectedCells[0].RowIndex; //номер строки, где отмечен cell
            int column = dgv.SelectedCells[0].ColumnIndex; //номер колонки, где отмечен cell

            //клик на пустой строке в таблице
            if (dgv.Rows[row].Cells[0].Value.ToString() == "") return;

            switch (i)
            {
                case 0: //заполнение таблицы ресурсов
                    id_resources_textbox.Text = dgv.Rows[row].Cells[0].Value.ToString();
                    //чтобы убрать нули вместо времени...
                    string birth_resurses_text = dgv.Rows[row].Cells[1].Value.ToString();
                    DateTime birth_date = DateTime.Parse(birth_resurses_text);
                    birth_resurses_textbox.Text = birth_date.ToString("yyyy-MM-dd");

                    fname_resurses_textbox.Text = dgv.Rows[row].Cells[2].Value.ToString();
                    lname_resurses_textbox.Text = dgv.Rows[row].Cells[3].Value.ToString();                    
                    mname_resurses_textbox.Text = dgv.Rows[row].Cells[4].Value.ToString();
                    title_resurses_textbox.Text = dgv.Rows[row].Cells[5].Value.ToString();
                    
                    break;
                case 1: //заполнение таблицы результатов
                    id_results_textbox.Text = dgv.Rows[row].Cells[0].Value.ToString();
                    tags_results_textbox.Text = dgv.Rows[row].Cells[6].Value.ToString();
                    break;
                case 2: // запорлнение таблицы тестов
                    id_tests_textbox.Text = dgv.Rows[row].Cells[0].Value.ToString();
                    name_tests_textbox.Text = dgv.Rows[row].Cells[3].Value.ToString();
                    description_tests_textbox.Text = dgv.Rows[row].Cells[1].Value.ToString();
                    script_tests_textbox.Text = dgv.Rows[row].Cells[2].Value.ToString();
                    break;
                default:
                    break;
            }

        }

        private async void resource_delete_record_button_Click(object sender, EventArgs e)
        {
            main_form = this.Owner as MainApp;
            if (id_resources_textbox.Text != "")
            {
                string delete_resource_command = "DELETE FROM resources WHERE id = @id;";
                using (MySqlCommand mysqlcommand = new MySqlCommand(delete_resource_command, main_form.conn))
                {
                    mysqlcommand.Parameters.AddWithValue("id", id_resources_textbox.Text);
                    await mysqlcommand.ExecuteNonQueryAsync();
                }

            }
            dataGridView_resources.Update();
            dataGridView_resources.Refresh();
            tabControl1_Update();

        }

        private async void result_delete_record_button_Click(object sender, EventArgs e)
        {
            // TBD не работает, дает 0
            //int row = dataGridView_resources.SelectedCells[0].RowIndex; //номер строки, где отмечен cell

            main_form = this.Owner as MainApp;
            if (id_results_textbox.Text != "")
            {
                string delete_result_command = "DELETE FROM results WHERE id = @id;";
                using (MySqlCommand mysqlcommand = new MySqlCommand(delete_result_command, main_form.conn))
                {
                    mysqlcommand.Parameters.AddWithValue("id", id_results_textbox.Text);
                    await mysqlcommand.ExecuteNonQueryAsync();
                }
            }
            dataGridView_results.Update();
            dataGridView_results.Refresh();
            tabControl1_Update();

            //TBD пометить строчку, рядом с той, которую удалили
            //dataGridView_results.CurrentCell = dataGridView_results.Rows[row - 1].Cells[0];

        }

        private async void test_delete_record_button_Click(object sender, EventArgs e)
        {
            main_form = this.Owner as MainApp;
            if (id_tests_textbox.Text != "")
            {
                string delete_tests_command = "DELETE FROM tests WHERE id = @id;";
                using (MySqlCommand mysqlcommand = new MySqlCommand(delete_tests_command, main_form.conn))
                {
                    mysqlcommand.Parameters.AddWithValue("id", id_tests_textbox.Text);
                    await mysqlcommand.ExecuteNonQueryAsync();
                }

            }
            dataGridView_tests.Update();
            dataGridView_tests.Refresh();
            tabControl1_Update();
        }

        private async void results_record_update_button_Click(object sender, EventArgs e)
        {
            //добавить коммент в базу
            main_form = this.Owner as MainApp;
            if ((id_results_textbox.Text != "") && (tags_results_textbox.Text != ""))
            {
                string update_tag_command = "UPDATE results SET tags=@tags WHERE id = @id;";
                using (MySqlCommand mysqlcommand = new MySqlCommand(update_tag_command, main_form.conn))
                {
                    mysqlcommand.Parameters.AddWithValue("id", id_results_textbox.Text);
                    mysqlcommand.Parameters.AddWithValue("tags", tags_results_textbox.Text);
                    await mysqlcommand.ExecuteNonQueryAsync();
                }

            }
            dataGridView_results.Update();
            dataGridView_results.Refresh();
            tabControl1_Update();
        }

        private async void tests_update_record_button_Click(object sender, EventArgs e)
        {
            main_form = this.Owner as MainApp;
            if (id_tests_textbox.Text != "") 
            {
                string update_command = "UPDATE tests SET description=@description, test_name=@test_name,test_script=@test_script WHERE id = @id;";
                string test_name = name_tests_textbox.Text;
                string test_script = script_tests_textbox.Text;
                string description = description_tests_textbox.Text;
                
                using (MySqlCommand mysqlcommand = new MySqlCommand(update_command, main_form.conn))
                {
                    mysqlcommand.Parameters.AddWithValue("id", id_tests_textbox.Text);
                    mysqlcommand.Parameters.AddWithValue("description", description);
                    mysqlcommand.Parameters.AddWithValue("test_name", test_name);
                    mysqlcommand.Parameters.AddWithValue("test_script", test_script);
                    await mysqlcommand.ExecuteNonQueryAsync();
                }

            }
            dataGridView_tests.Update();
            dataGridView_tests.Refresh();
            tabControl1_Update();
        }

        private async void tests_add_record_button_Click(object sender, EventArgs e)
        {
            main_form = this.Owner as MainApp;

            string update_command = "INSERT INTO tests (description, test_name,test_script) VALUES(@description,@test_name,test_script);";
            string test_name = name_tests_textbox.Text;
            string test_script = script_tests_textbox.Text;
            string description = description_tests_textbox.Text;

            using (MySqlCommand mysqlcommand = new MySqlCommand(update_command, main_form.conn))
            {
                mysqlcommand.Parameters.AddWithValue("description", description);
                mysqlcommand.Parameters.AddWithValue("test_name", test_name);
                mysqlcommand.Parameters.AddWithValue("test_script", test_script);
                await mysqlcommand.ExecuteNonQueryAsync();
            }

            dataGridView_tests.Update();
            dataGridView_tests.Refresh();
            tabControl1_Update();

        }

        private async void resources_update_record_button_Click(object sender, EventArgs e)
        {
            main_form = this.Owner as MainApp;
            if (id_resources_textbox.Text != "")
            {
                string update_command = "UPDATE resources SET birth=@birth, fname=@fname, lname=@lname, mname=@mname, title=@title WHERE id = @id;";
                string birth = birth_resurses_textbox.Text;
                string fname = fname_resurses_textbox.Text;
                string lname = lname_resurses_textbox.Text;
                string mname = mname_resurses_textbox.Text;
                string title = title_resurses_textbox.Text;

                using (MySqlCommand mysqlcommand = new MySqlCommand(update_command, main_form.conn))
                {
                    mysqlcommand.Parameters.AddWithValue("id", id_resources_textbox.Text);
                    mysqlcommand.Parameters.AddWithValue("birth", birth);
                    mysqlcommand.Parameters.AddWithValue("fname", fname);
                    mysqlcommand.Parameters.AddWithValue("lname", lname);
                    mysqlcommand.Parameters.AddWithValue("mname", mname);
                    mysqlcommand.Parameters.AddWithValue("title", title);
                    await mysqlcommand.ExecuteNonQueryAsync();
                }

            }
            dataGridView_resources.Update();
            dataGridView_resources.Refresh();
            tabControl1_Update();
        }

        private async void resources_insert_record_button_Click(object sender, EventArgs e)
        {
            main_form = this.Owner as MainApp;

            string update_command = "INSERT INTO resources (birth, fname, lname, mname, title) VALUES(@birth,@fname,@lname,@mname,@title);";
            string birth = birth_resurses_textbox.Text;
            string fname = fname_resurses_textbox.Text;
            string lname = lname_resurses_textbox.Text;
            string mname = mname_resurses_textbox.Text;
            string title = title_resurses_textbox.Text;

            using (MySqlCommand mysqlcommand = new MySqlCommand(update_command, main_form.conn))
            {
                mysqlcommand.Parameters.AddWithValue("birth", birth);
                mysqlcommand.Parameters.AddWithValue("fname", fname);
                mysqlcommand.Parameters.AddWithValue("lname", lname);
                mysqlcommand.Parameters.AddWithValue("mname", mname);
                mysqlcommand.Parameters.AddWithValue("title", title);
                await mysqlcommand.ExecuteNonQueryAsync();
            }
           
            dataGridView_resources.Update();
            dataGridView_resources.Refresh();
            tabControl1_Update();
        }

        private void DB_view_Close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView_resources_KeyPress(object sender, KeyPressEventArgs e)
        {            
            dataGridView_resources_CellClick(sender, null);
        }
    }
}

