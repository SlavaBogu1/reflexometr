namespace Reflexes_UI
{
    partial class MainApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Applicatrion_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.App_Exit_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DB_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DB_edit_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DB_parameters_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Help_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Help_About_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.repeat_test_number_updown = new System.Windows.Forms.NumericUpDown();
            this.restart_button = new System.Windows.Forms.Button();
            this.ResetTest_button = new System.Windows.Forms.Button();
            this.baudRate = new System.Windows.Forms.ComboBox();
            this.comPort = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.ArduinoConnect_button = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.StartTest_button = new System.Windows.Forms.Button();
            this.Test_list_comboBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.UserMessage_label = new System.Windows.Forms.Label();
            this.log_listView = new System.Windows.Forms.RichTextBox();
            this.Log_view_enabled = new System.Windows.Forms.CheckBox();
            this.Subjects_View_Table = new System.Windows.Forms.TableLayoutPanel();
            this.resource_name_label_5 = new System.Windows.Forms.Label();
            this.resource_name_label_4 = new System.Windows.Forms.Label();
            this.resource_name_label_3 = new System.Windows.Forms.Label();
            this.resource_name_label_2 = new System.Windows.Forms.Label();
            this.resource_name_textbox_5 = new System.Windows.Forms.TextBox();
            this.resource_name_textbox_4 = new System.Windows.Forms.TextBox();
            this.resource_name_textbox_3 = new System.Windows.Forms.TextBox();
            this.resource_name_textbox_2 = new System.Windows.Forms.TextBox();
            this.resource_name_textbox_1 = new System.Windows.Forms.TextBox();
            this.resource_name_label_1 = new System.Windows.Forms.Label();
            this.result_label_1 = new System.Windows.Forms.Label();
            this.result_label_2 = new System.Windows.Forms.Label();
            this.result_label_3 = new System.Windows.Forms.Label();
            this.result_label_4 = new System.Windows.Forms.Label();
            this.result_label_5 = new System.Windows.Forms.Label();
            this.tag_textbox_1 = new System.Windows.Forms.TextBox();
            this.tag_textbox_2 = new System.Windows.Forms.TextBox();
            this.tag_textbox_3 = new System.Windows.Forms.TextBox();
            this.tag_textbox_4 = new System.Windows.Forms.TextBox();
            this.tag_textbox_5 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repeat_test_number_updown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.Subjects_View_Table.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Applicatrion_ToolStripMenuItem,
            this.DB_ToolStripMenuItem,
            this.Help_ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(923, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Applicatrion_ToolStripMenuItem
            // 
            this.Applicatrion_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.App_Exit_ToolStripMenuItem});
            this.Applicatrion_ToolStripMenuItem.Name = "Applicatrion_ToolStripMenuItem";
            this.Applicatrion_ToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.Applicatrion_ToolStripMenuItem.Text = "Приложение";
            // 
            // App_Exit_ToolStripMenuItem
            // 
            this.App_Exit_ToolStripMenuItem.Name = "App_Exit_ToolStripMenuItem";
            this.App_Exit_ToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.App_Exit_ToolStripMenuItem.Text = "Выход";
            this.App_Exit_ToolStripMenuItem.Click += new System.EventHandler(this.App_Exit_ToolStripMenuItem_Click);
            // 
            // DB_ToolStripMenuItem
            // 
            this.DB_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DB_edit_ToolStripMenuItem,
            this.DB_parameters_menu});
            this.DB_ToolStripMenuItem.Name = "DB_ToolStripMenuItem";
            this.DB_ToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.DB_ToolStripMenuItem.Text = "База Данных";
            // 
            // DB_edit_ToolStripMenuItem
            // 
            this.DB_edit_ToolStripMenuItem.Name = "DB_edit_ToolStripMenuItem";
            this.DB_edit_ToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.DB_edit_ToolStripMenuItem.Text = "Редактирование";
            this.DB_edit_ToolStripMenuItem.Click += new System.EventHandler(this.DB_edit_ToolStripMenuItem_Click);
            // 
            // DB_parameters_menu
            // 
            this.DB_parameters_menu.Name = "DB_parameters_menu";
            this.DB_parameters_menu.Size = new System.Drawing.Size(163, 22);
            this.DB_parameters_menu.Text = "Параметры";
            this.DB_parameters_menu.Click += new System.EventHandler(this.DB_parameters_menu_Click);
            // 
            // Help_ToolStripMenuItem
            // 
            this.Help_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Help_About_ToolStripMenuItem});
            this.Help_ToolStripMenuItem.Name = "Help_ToolStripMenuItem";
            this.Help_ToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.Help_ToolStripMenuItem.Text = "Справка";
            // 
            // Help_About_ToolStripMenuItem
            // 
            this.Help_About_ToolStripMenuItem.Name = "Help_About_ToolStripMenuItem";
            this.Help_About_ToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.Help_About_ToolStripMenuItem.Text = "О Программе";
            this.Help_About_ToolStripMenuItem.Click += new System.EventHandler(this.Help_About_ToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Subjects_View_Table);
            this.splitContainer1.Size = new System.Drawing.Size(923, 515);
            this.splitContainer1.SplitterDistance = 410;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 1;
            this.splitContainer1.TabStop = false;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Controls.Add(this.repeat_test_number_updown);
            this.splitContainer2.Panel1.Controls.Add(this.restart_button);
            this.splitContainer2.Panel1.Controls.Add(this.ResetTest_button);
            this.splitContainer2.Panel1.Controls.Add(this.baudRate);
            this.splitContainer2.Panel1.Controls.Add(this.comPort);
            this.splitContainer2.Panel1.Controls.Add(this.label13);
            this.splitContainer2.Panel1.Controls.Add(this.ArduinoConnect_button);
            this.splitContainer2.Panel1.Controls.Add(this.label12);
            this.splitContainer2.Panel1.Controls.Add(this.StartTest_button);
            this.splitContainer2.Panel1.Controls.Add(this.Test_list_comboBox);
            this.splitContainer2.Panel1.Controls.Add(this.label11);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(923, 410);
            this.splitContainer2.SplitterDistance = 250;
            this.splitContainer2.SplitterWidth = 1;
            this.splitContainer2.TabIndex = 0;
            this.splitContainer2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "повторов";
            // 
            // repeat_test_number_updown
            // 
            this.repeat_test_number_updown.Location = new System.Drawing.Point(129, 220);
            this.repeat_test_number_updown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.repeat_test_number_updown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.repeat_test_number_updown.Name = "repeat_test_number_updown";
            this.repeat_test_number_updown.Size = new System.Drawing.Size(38, 20);
            this.repeat_test_number_updown.TabIndex = 12;
            this.repeat_test_number_updown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // restart_button
            // 
            this.restart_button.Location = new System.Drawing.Point(81, 325);
            this.restart_button.Name = "restart_button";
            this.restart_button.Size = new System.Drawing.Size(75, 23);
            this.restart_button.TabIndex = 11;
            this.restart_button.Text = "Заново";
            this.restart_button.UseVisualStyleBackColor = true;
            this.restart_button.Click += new System.EventHandler(this.restart_button_Click);
            // 
            // ResetTest_button
            // 
            this.ResetTest_button.Location = new System.Drawing.Point(60, 254);
            this.ResetTest_button.Name = "ResetTest_button";
            this.ResetTest_button.Size = new System.Drawing.Size(120, 23);
            this.ResetTest_button.TabIndex = 10;
            this.ResetTest_button.Text = "Сброс Теста";
            this.ResetTest_button.UseVisualStyleBackColor = true;
            this.ResetTest_button.Click += new System.EventHandler(this.ResetTest_button_Click);
            // 
            // baudRate
            // 
            this.baudRate.Enabled = false;
            this.baudRate.FormattingEnabled = true;
            this.baudRate.Location = new System.Drawing.Point(122, 64);
            this.baudRate.Name = "baudRate";
            this.baudRate.Size = new System.Drawing.Size(105, 21);
            this.baudRate.TabIndex = 9;
            // 
            // comPort
            // 
            this.comPort.FormattingEnabled = true;
            this.comPort.Location = new System.Drawing.Point(11, 64);
            this.comPort.Name = "comPort";
            this.comPort.Size = new System.Drawing.Size(105, 21);
            this.comPort.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(36, 164);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "Выбрать";
            // 
            // ArduinoConnect_button
            // 
            this.ArduinoConnect_button.Location = new System.Drawing.Point(39, 91);
            this.ArduinoConnect_button.Name = "ArduinoConnect_button";
            this.ArduinoConnect_button.Size = new System.Drawing.Size(143, 23);
            this.ArduinoConnect_button.TabIndex = 6;
            this.ArduinoConnect_button.Text = "Подключить";
            this.ArduinoConnect_button.UseVisualStyleBackColor = true;
            this.ArduinoConnect_button.Click += new System.EventHandler(this.ArduinoConnect_button_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(40, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(142, 18);
            this.label12.TabIndex = 5;
            this.label12.Text = "Рефлексометр";
            // 
            // StartTest_button
            // 
            this.StartTest_button.Location = new System.Drawing.Point(36, 217);
            this.StartTest_button.Name = "StartTest_button";
            this.StartTest_button.Size = new System.Drawing.Size(75, 23);
            this.StartTest_button.TabIndex = 4;
            this.StartTest_button.Text = "Запустить";
            this.StartTest_button.UseVisualStyleBackColor = true;
            this.StartTest_button.Click += new System.EventHandler(this.StartTest_button_Click);
            // 
            // Test_list_comboBox
            // 
            this.Test_list_comboBox.Enabled = false;
            this.Test_list_comboBox.FormattingEnabled = true;
            this.Test_list_comboBox.Location = new System.Drawing.Point(36, 180);
            this.Test_list_comboBox.Name = "Test_list_comboBox";
            this.Test_list_comboBox.Size = new System.Drawing.Size(172, 21);
            this.Test_list_comboBox.TabIndex = 2;
            this.Test_list_comboBox.SelectedIndexChanged += new System.EventHandler(this.Test_list_comboBox_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(36, 134);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 18);
            this.label11.TabIndex = 1;
            this.label11.Text = "Тесты";
            // 
            // splitContainer3
            // 
            this.splitContainer3.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer3.IsSplitterFixed = true;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer3.Panel1.Controls.Add(this.UserMessage_label);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer3.Panel2.Controls.Add(this.log_listView);
            this.splitContainer3.Panel2.Controls.Add(this.Log_view_enabled);
            this.splitContainer3.Size = new System.Drawing.Size(672, 410);
            this.splitContainer3.SplitterDistance = 550;
            this.splitContainer3.SplitterWidth = 1;
            this.splitContainer3.TabIndex = 0;
            this.splitContainer3.TabStop = false;
            // 
            // UserMessage_label
            // 
            this.UserMessage_label.Dock = System.Windows.Forms.DockStyle.Top;
            this.UserMessage_label.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserMessage_label.Location = new System.Drawing.Point(0, 0);
            this.UserMessage_label.Name = "UserMessage_label";
            this.UserMessage_label.Size = new System.Drawing.Size(548, 114);
            this.UserMessage_label.TabIndex = 0;
            this.UserMessage_label.Text = "Здесь Вы будете видеть текст заданий.";
            this.UserMessage_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // log_listView
            // 
            this.log_listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.log_listView.Location = new System.Drawing.Point(0, 0);
            this.log_listView.Name = "log_listView";
            this.log_listView.ReadOnly = true;
            this.log_listView.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.log_listView.Size = new System.Drawing.Size(119, 391);
            this.log_listView.TabIndex = 2;
            this.log_listView.Text = "";
            // 
            // Log_view_enabled
            // 
            this.Log_view_enabled.AutoSize = true;
            this.Log_view_enabled.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Log_view_enabled.Location = new System.Drawing.Point(0, 391);
            this.Log_view_enabled.Name = "Log_view_enabled";
            this.Log_view_enabled.Size = new System.Drawing.Size(119, 17);
            this.Log_view_enabled.TabIndex = 1;
            this.Log_view_enabled.Text = "Скрыть сообщения";
            this.Log_view_enabled.UseVisualStyleBackColor = true;
            this.Log_view_enabled.CheckedChanged += new System.EventHandler(this.Log_view_enabled_CheckedChanged);
            // 
            // Subjects_View_Table
            // 
            this.Subjects_View_Table.ColumnCount = 5;
            this.Subjects_View_Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Subjects_View_Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Subjects_View_Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Subjects_View_Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Subjects_View_Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Subjects_View_Table.Controls.Add(this.resource_name_label_5, 4, 1);
            this.Subjects_View_Table.Controls.Add(this.resource_name_label_4, 3, 1);
            this.Subjects_View_Table.Controls.Add(this.resource_name_label_3, 2, 1);
            this.Subjects_View_Table.Controls.Add(this.resource_name_label_2, 1, 1);
            this.Subjects_View_Table.Controls.Add(this.resource_name_textbox_5, 4, 0);
            this.Subjects_View_Table.Controls.Add(this.resource_name_textbox_4, 3, 0);
            this.Subjects_View_Table.Controls.Add(this.resource_name_textbox_3, 2, 0);
            this.Subjects_View_Table.Controls.Add(this.resource_name_textbox_2, 1, 0);
            this.Subjects_View_Table.Controls.Add(this.resource_name_textbox_1, 0, 0);
            this.Subjects_View_Table.Controls.Add(this.resource_name_label_1, 0, 1);
            this.Subjects_View_Table.Controls.Add(this.result_label_1, 0, 3);
            this.Subjects_View_Table.Controls.Add(this.result_label_2, 1, 3);
            this.Subjects_View_Table.Controls.Add(this.result_label_3, 2, 3);
            this.Subjects_View_Table.Controls.Add(this.result_label_4, 3, 3);
            this.Subjects_View_Table.Controls.Add(this.result_label_5, 4, 3);
            this.Subjects_View_Table.Controls.Add(this.tag_textbox_1, 0, 2);
            this.Subjects_View_Table.Controls.Add(this.tag_textbox_2, 1, 2);
            this.Subjects_View_Table.Controls.Add(this.tag_textbox_3, 2, 2);
            this.Subjects_View_Table.Controls.Add(this.tag_textbox_4, 3, 2);
            this.Subjects_View_Table.Controls.Add(this.tag_textbox_5, 4, 2);
            this.Subjects_View_Table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Subjects_View_Table.Location = new System.Drawing.Point(0, 0);
            this.Subjects_View_Table.Name = "Subjects_View_Table";
            this.Subjects_View_Table.RowCount = 4;
            this.Subjects_View_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.Subjects_View_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.Subjects_View_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.Subjects_View_Table.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Subjects_View_Table.Size = new System.Drawing.Size(923, 104);
            this.Subjects_View_Table.TabIndex = 0;
            // 
            // resource_name_label_5
            // 
            this.resource_name_label_5.AutoSize = true;
            this.resource_name_label_5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.resource_name_label_5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resource_name_label_5.Location = new System.Drawing.Point(739, 25);
            this.resource_name_label_5.Name = "resource_name_label_5";
            this.resource_name_label_5.Size = new System.Drawing.Size(181, 25);
            this.resource_name_label_5.TabIndex = 9;
            this.resource_name_label_5.Text = "Выберите участника";
            this.resource_name_label_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resource_name_label_4
            // 
            this.resource_name_label_4.AutoSize = true;
            this.resource_name_label_4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.resource_name_label_4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resource_name_label_4.Location = new System.Drawing.Point(555, 25);
            this.resource_name_label_4.Name = "resource_name_label_4";
            this.resource_name_label_4.Size = new System.Drawing.Size(178, 25);
            this.resource_name_label_4.TabIndex = 8;
            this.resource_name_label_4.Text = "Выберите участника";
            this.resource_name_label_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resource_name_label_3
            // 
            this.resource_name_label_3.AutoSize = true;
            this.resource_name_label_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.resource_name_label_3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resource_name_label_3.Location = new System.Drawing.Point(371, 25);
            this.resource_name_label_3.Name = "resource_name_label_3";
            this.resource_name_label_3.Size = new System.Drawing.Size(178, 25);
            this.resource_name_label_3.TabIndex = 7;
            this.resource_name_label_3.Text = "Выберите участника";
            this.resource_name_label_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resource_name_label_2
            // 
            this.resource_name_label_2.AutoSize = true;
            this.resource_name_label_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.resource_name_label_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resource_name_label_2.Location = new System.Drawing.Point(187, 25);
            this.resource_name_label_2.Name = "resource_name_label_2";
            this.resource_name_label_2.Size = new System.Drawing.Size(178, 25);
            this.resource_name_label_2.TabIndex = 6;
            this.resource_name_label_2.Text = "Выберите участника";
            this.resource_name_label_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resource_name_textbox_5
            // 
            this.resource_name_textbox_5.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.resource_name_textbox_5.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.resource_name_textbox_5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resource_name_textbox_5.Enabled = false;
            this.resource_name_textbox_5.Location = new System.Drawing.Point(739, 3);
            this.resource_name_textbox_5.Name = "resource_name_textbox_5";
            this.resource_name_textbox_5.Size = new System.Drawing.Size(181, 20);
            this.resource_name_textbox_5.TabIndex = 4;
            this.resource_name_textbox_5.Text = "Ф.И.О.";
            this.resource_name_textbox_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.resource_name_textbox_5.TextChanged += new System.EventHandler(this.resource_name_textbox_5_TextChanged_1);
            // 
            // resource_name_textbox_4
            // 
            this.resource_name_textbox_4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.resource_name_textbox_4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.resource_name_textbox_4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resource_name_textbox_4.Enabled = false;
            this.resource_name_textbox_4.Location = new System.Drawing.Point(555, 3);
            this.resource_name_textbox_4.Name = "resource_name_textbox_4";
            this.resource_name_textbox_4.Size = new System.Drawing.Size(178, 20);
            this.resource_name_textbox_4.TabIndex = 3;
            this.resource_name_textbox_4.Text = "Ф.И.О.";
            this.resource_name_textbox_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.resource_name_textbox_4.TextChanged += new System.EventHandler(this.resource_name_textbox_4_TextChanged_1);
            // 
            // resource_name_textbox_3
            // 
            this.resource_name_textbox_3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.resource_name_textbox_3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.resource_name_textbox_3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resource_name_textbox_3.Enabled = false;
            this.resource_name_textbox_3.Location = new System.Drawing.Point(371, 3);
            this.resource_name_textbox_3.Name = "resource_name_textbox_3";
            this.resource_name_textbox_3.Size = new System.Drawing.Size(178, 20);
            this.resource_name_textbox_3.TabIndex = 2;
            this.resource_name_textbox_3.Text = "Ф.И.О.";
            this.resource_name_textbox_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.resource_name_textbox_3.TextChanged += new System.EventHandler(this.resource_name_textbox_3_TextChanged_1);
            // 
            // resource_name_textbox_2
            // 
            this.resource_name_textbox_2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.resource_name_textbox_2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.resource_name_textbox_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resource_name_textbox_2.Enabled = false;
            this.resource_name_textbox_2.Location = new System.Drawing.Point(187, 3);
            this.resource_name_textbox_2.Name = "resource_name_textbox_2";
            this.resource_name_textbox_2.Size = new System.Drawing.Size(178, 20);
            this.resource_name_textbox_2.TabIndex = 1;
            this.resource_name_textbox_2.Text = "Ф.И.О.";
            this.resource_name_textbox_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.resource_name_textbox_2.TextChanged += new System.EventHandler(this.resource_name_textbox_2_TextChanged_1);
            // 
            // resource_name_textbox_1
            // 
            this.resource_name_textbox_1.AutoCompleteCustomSource.AddRange(new string[] {
            "Папа",
            "Вася",
            "Силен",
            "В Математике"});
            this.resource_name_textbox_1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.resource_name_textbox_1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.resource_name_textbox_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resource_name_textbox_1.Enabled = false;
            this.resource_name_textbox_1.Location = new System.Drawing.Point(3, 3);
            this.resource_name_textbox_1.Name = "resource_name_textbox_1";
            this.resource_name_textbox_1.Size = new System.Drawing.Size(178, 20);
            this.resource_name_textbox_1.TabIndex = 0;
            this.resource_name_textbox_1.Text = "Ф.И.О.";
            this.resource_name_textbox_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.resource_name_textbox_1.TextChanged += new System.EventHandler(this.resource_name_textbox_1_TextChanged);
            // 
            // resource_name_label_1
            // 
            this.resource_name_label_1.AutoSize = true;
            this.resource_name_label_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.resource_name_label_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resource_name_label_1.Location = new System.Drawing.Point(3, 25);
            this.resource_name_label_1.Name = "resource_name_label_1";
            this.resource_name_label_1.Size = new System.Drawing.Size(178, 25);
            this.resource_name_label_1.TabIndex = 5;
            this.resource_name_label_1.Text = "Выберите участника";
            this.resource_name_label_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // result_label_1
            // 
            this.result_label_1.AutoSize = true;
            this.result_label_1.BackColor = System.Drawing.Color.LightGray;
            this.result_label_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.result_label_1.Location = new System.Drawing.Point(3, 75);
            this.result_label_1.Name = "result_label_1";
            this.result_label_1.Size = new System.Drawing.Size(178, 29);
            this.result_label_1.TabIndex = 10;
            this.result_label_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // result_label_2
            // 
            this.result_label_2.AutoSize = true;
            this.result_label_2.BackColor = System.Drawing.Color.LightGray;
            this.result_label_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.result_label_2.Location = new System.Drawing.Point(187, 75);
            this.result_label_2.Name = "result_label_2";
            this.result_label_2.Size = new System.Drawing.Size(178, 29);
            this.result_label_2.TabIndex = 11;
            this.result_label_2.Text = " ";
            this.result_label_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // result_label_3
            // 
            this.result_label_3.AutoSize = true;
            this.result_label_3.BackColor = System.Drawing.Color.LightGray;
            this.result_label_3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.result_label_3.Location = new System.Drawing.Point(371, 75);
            this.result_label_3.Name = "result_label_3";
            this.result_label_3.Size = new System.Drawing.Size(178, 29);
            this.result_label_3.TabIndex = 12;
            this.result_label_3.Text = " ";
            this.result_label_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // result_label_4
            // 
            this.result_label_4.AutoSize = true;
            this.result_label_4.BackColor = System.Drawing.Color.LightGray;
            this.result_label_4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.result_label_4.Location = new System.Drawing.Point(555, 75);
            this.result_label_4.Name = "result_label_4";
            this.result_label_4.Size = new System.Drawing.Size(178, 29);
            this.result_label_4.TabIndex = 13;
            this.result_label_4.Text = " ";
            this.result_label_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // result_label_5
            // 
            this.result_label_5.AutoSize = true;
            this.result_label_5.BackColor = System.Drawing.Color.LightGray;
            this.result_label_5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.result_label_5.Location = new System.Drawing.Point(739, 75);
            this.result_label_5.Name = "result_label_5";
            this.result_label_5.Size = new System.Drawing.Size(181, 29);
            this.result_label_5.TabIndex = 14;
            this.result_label_5.Text = " ";
            this.result_label_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tag_textbox_1
            // 
            this.tag_textbox_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tag_textbox_1.Location = new System.Drawing.Point(3, 53);
            this.tag_textbox_1.Name = "tag_textbox_1";
            this.tag_textbox_1.Size = new System.Drawing.Size(178, 20);
            this.tag_textbox_1.TabIndex = 15;
            this.tag_textbox_1.Text = "комментарий";
            this.tag_textbox_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tag_textbox_2
            // 
            this.tag_textbox_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tag_textbox_2.Location = new System.Drawing.Point(187, 53);
            this.tag_textbox_2.Name = "tag_textbox_2";
            this.tag_textbox_2.Size = new System.Drawing.Size(178, 20);
            this.tag_textbox_2.TabIndex = 16;
            this.tag_textbox_2.Text = "комментарий";
            this.tag_textbox_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tag_textbox_3
            // 
            this.tag_textbox_3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tag_textbox_3.Location = new System.Drawing.Point(371, 53);
            this.tag_textbox_3.Name = "tag_textbox_3";
            this.tag_textbox_3.Size = new System.Drawing.Size(178, 20);
            this.tag_textbox_3.TabIndex = 17;
            this.tag_textbox_3.Text = "комментарий";
            this.tag_textbox_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tag_textbox_4
            // 
            this.tag_textbox_4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tag_textbox_4.Location = new System.Drawing.Point(555, 53);
            this.tag_textbox_4.Name = "tag_textbox_4";
            this.tag_textbox_4.Size = new System.Drawing.Size(178, 20);
            this.tag_textbox_4.TabIndex = 18;
            this.tag_textbox_4.Text = "комментарий";
            this.tag_textbox_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tag_textbox_5
            // 
            this.tag_textbox_5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tag_textbox_5.Location = new System.Drawing.Point(739, 53);
            this.tag_textbox_5.Name = "tag_textbox_5";
            this.tag_textbox_5.Size = new System.Drawing.Size(181, 20);
            this.tag_textbox_5.TabIndex = 19;
            this.tag_textbox_5.Text = "комментарий";
            this.tag_textbox_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 539);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainApp";
            this.Text = "Рефлектометр";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainApp_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.repeat_test_number_updown)).EndInit();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.Subjects_View_Table.ResumeLayout(false);
            this.Subjects_View_Table.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Applicatrion_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Help_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem App_Exit_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DB_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Help_About_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DB_edit_ToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel Subjects_View_Table;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Label resource_name_label_5;
        private System.Windows.Forms.Label resource_name_label_4;
        private System.Windows.Forms.Label resource_name_label_3;
        private System.Windows.Forms.Label resource_name_label_2;
        private System.Windows.Forms.TextBox resource_name_textbox_1;
        private System.Windows.Forms.Label resource_name_label_1;
        private System.Windows.Forms.Label UserMessage_label;
        private System.Windows.Forms.CheckBox Log_view_enabled;
        private System.Windows.Forms.TextBox resource_name_textbox_5;
        private System.Windows.Forms.TextBox resource_name_textbox_4;
        private System.Windows.Forms.TextBox resource_name_textbox_3;
        private System.Windows.Forms.TextBox resource_name_textbox_2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox Test_list_comboBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button StartTest_button;
        private System.Windows.Forms.Button ArduinoConnect_button;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comPort;
        private System.Windows.Forms.ComboBox baudRate;
        private System.Windows.Forms.Label result_label_1;
        private System.Windows.Forms.Label result_label_2;
        private System.Windows.Forms.Label result_label_3;
        private System.Windows.Forms.Label result_label_4;
        private System.Windows.Forms.Label result_label_5;
        private System.Windows.Forms.TextBox tag_textbox_1;
        private System.Windows.Forms.TextBox tag_textbox_2;
        private System.Windows.Forms.TextBox tag_textbox_3;
        private System.Windows.Forms.TextBox tag_textbox_4;
        private System.Windows.Forms.TextBox tag_textbox_5;
        private System.Windows.Forms.Button restart_button;
        private System.Windows.Forms.Button ResetTest_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown repeat_test_number_updown;
        private System.Windows.Forms.RichTextBox log_listView;
        private System.Windows.Forms.ToolStripMenuItem DB_parameters_menu;
    }
}

