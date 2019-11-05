namespace Reflexes_UI
{
    partial class DB_viewer
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
            this.Save_DB_to_CSV_button = new System.Windows.Forms.Button();
            this.db_tab_tests = new System.Windows.Forms.TabPage();
            this.tests_add_record_button = new System.Windows.Forms.Button();
            this.script_tests_textbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.description_tests_textbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tests_update_record_button = new System.Windows.Forms.Button();
            this.name_tests_textbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.test_delete_record_button = new System.Windows.Forms.Button();
            this.id_tests_textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView_tests = new System.Windows.Forms.DataGridView();
            this.db_tab_results = new System.Windows.Forms.TabPage();
            this.results_record_update_button = new System.Windows.Forms.Button();
            this.tags_results_textbox = new System.Windows.Forms.TextBox();
            this.id_results_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.result_delete_record_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_results = new System.Windows.Forms.DataGridView();
            this.db_tab_resources = new System.Windows.Forms.TabPage();
            this.birth_resurses_textbox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.title_resurses_textbox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.mname_resurses_textbox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.fname_resurses_textbox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.resources_insert_record_button = new System.Windows.Forms.Button();
            this.resources_update_record_button = new System.Windows.Forms.Button();
            this.lname_resurses_textbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.resource_delete_record_button = new System.Windows.Forms.Button();
            this.id_resources_textbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView_resources = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.DB_view_Close_button = new System.Windows.Forms.Button();
            this.db_tab_tests.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tests)).BeginInit();
            this.db_tab_results.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_results)).BeginInit();
            this.db_tab_resources.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_resources)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Save_DB_to_CSV_button
            // 
            this.Save_DB_to_CSV_button.Location = new System.Drawing.Point(582, 477);
            this.Save_DB_to_CSV_button.Name = "Save_DB_to_CSV_button";
            this.Save_DB_to_CSV_button.Size = new System.Drawing.Size(75, 23);
            this.Save_DB_to_CSV_button.TabIndex = 2;
            this.Save_DB_to_CSV_button.Text = "Сохранить";
            this.Save_DB_to_CSV_button.UseVisualStyleBackColor = true;
            this.Save_DB_to_CSV_button.Click += new System.EventHandler(this.Save_DB_to_CSV_button_Click);
            // 
            // db_tab_tests
            // 
            this.db_tab_tests.Controls.Add(this.tests_add_record_button);
            this.db_tab_tests.Controls.Add(this.script_tests_textbox);
            this.db_tab_tests.Controls.Add(this.label6);
            this.db_tab_tests.Controls.Add(this.description_tests_textbox);
            this.db_tab_tests.Controls.Add(this.label5);
            this.db_tab_tests.Controls.Add(this.tests_update_record_button);
            this.db_tab_tests.Controls.Add(this.name_tests_textbox);
            this.db_tab_tests.Controls.Add(this.label4);
            this.db_tab_tests.Controls.Add(this.test_delete_record_button);
            this.db_tab_tests.Controls.Add(this.id_tests_textbox);
            this.db_tab_tests.Controls.Add(this.label3);
            this.db_tab_tests.Controls.Add(this.dataGridView_tests);
            this.db_tab_tests.Location = new System.Drawing.Point(4, 22);
            this.db_tab_tests.Name = "db_tab_tests";
            this.db_tab_tests.Padding = new System.Windows.Forms.Padding(3);
            this.db_tab_tests.Size = new System.Drawing.Size(788, 431);
            this.db_tab_tests.TabIndex = 1;
            this.db_tab_tests.Text = "Тесты";
            this.db_tab_tests.UseVisualStyleBackColor = true;
            // 
            // tests_add_record_button
            // 
            this.tests_add_record_button.Location = new System.Drawing.Point(430, 368);
            this.tests_add_record_button.Name = "tests_add_record_button";
            this.tests_add_record_button.Size = new System.Drawing.Size(75, 23);
            this.tests_add_record_button.TabIndex = 14;
            this.tests_add_record_button.Text = "Добавить";
            this.tests_add_record_button.UseVisualStyleBackColor = true;
            this.tests_add_record_button.Click += new System.EventHandler(this.tests_add_record_button_Click);
            // 
            // script_tests_textbox
            // 
            this.script_tests_textbox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.script_tests_textbox.Location = new System.Drawing.Point(332, 392);
            this.script_tests_textbox.Name = "script_tests_textbox";
            this.script_tests_textbox.Size = new System.Drawing.Size(74, 20);
            this.script_tests_textbox.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(329, 373);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Скрипт";
            // 
            // description_tests_textbox
            // 
            this.description_tests_textbox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.description_tests_textbox.Location = new System.Drawing.Point(202, 392);
            this.description_tests_textbox.Name = "description_tests_textbox";
            this.description_tests_textbox.Size = new System.Drawing.Size(124, 20);
            this.description_tests_textbox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(199, 373);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Описание теста";
            // 
            // tests_update_record_button
            // 
            this.tests_update_record_button.Location = new System.Drawing.Point(430, 395);
            this.tests_update_record_button.Name = "tests_update_record_button";
            this.tests_update_record_button.Size = new System.Drawing.Size(75, 23);
            this.tests_update_record_button.TabIndex = 9;
            this.tests_update_record_button.Text = "Обновить";
            this.tests_update_record_button.UseVisualStyleBackColor = true;
            this.tests_update_record_button.Click += new System.EventHandler(this.tests_update_record_button_Click);
            // 
            // name_tests_textbox
            // 
            this.name_tests_textbox.Location = new System.Drawing.Point(113, 392);
            this.name_tests_textbox.Name = "name_tests_textbox";
            this.name_tests_textbox.Size = new System.Drawing.Size(74, 20);
            this.name_tests_textbox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 373);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Имя теста";
            // 
            // test_delete_record_button
            // 
            this.test_delete_record_button.Location = new System.Drawing.Point(640, 390);
            this.test_delete_record_button.Name = "test_delete_record_button";
            this.test_delete_record_button.Size = new System.Drawing.Size(140, 23);
            this.test_delete_record_button.TabIndex = 5;
            this.test_delete_record_button.Text = "Удалить запись";
            this.test_delete_record_button.UseVisualStyleBackColor = true;
            this.test_delete_record_button.Click += new System.EventHandler(this.test_delete_record_button_Click);
            // 
            // id_tests_textbox
            // 
            this.id_tests_textbox.Location = new System.Drawing.Point(8, 392);
            this.id_tests_textbox.Name = "id_tests_textbox";
            this.id_tests_textbox.Size = new System.Drawing.Size(83, 20);
            this.id_tests_textbox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Номер записи:";
            // 
            // dataGridView_tests
            // 
            this.dataGridView_tests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_tests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_tests.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView_tests.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_tests.MultiSelect = false;
            this.dataGridView_tests.Name = "dataGridView_tests";
            this.dataGridView_tests.ReadOnly = true;
            this.dataGridView_tests.Size = new System.Drawing.Size(782, 350);
            this.dataGridView_tests.TabIndex = 0;
            this.dataGridView_tests.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_resources_CellClick);
            // 
            // db_tab_results
            // 
            this.db_tab_results.Controls.Add(this.results_record_update_button);
            this.db_tab_results.Controls.Add(this.tags_results_textbox);
            this.db_tab_results.Controls.Add(this.id_results_textbox);
            this.db_tab_results.Controls.Add(this.label2);
            this.db_tab_results.Controls.Add(this.result_delete_record_button);
            this.db_tab_results.Controls.Add(this.label1);
            this.db_tab_results.Controls.Add(this.dataGridView_results);
            this.db_tab_results.Location = new System.Drawing.Point(4, 22);
            this.db_tab_results.Name = "db_tab_results";
            this.db_tab_results.Size = new System.Drawing.Size(788, 431);
            this.db_tab_results.TabIndex = 2;
            this.db_tab_results.Text = "Результаты";
            this.db_tab_results.UseVisualStyleBackColor = true;
            // 
            // results_record_update_button
            // 
            this.results_record_update_button.Location = new System.Drawing.Point(451, 390);
            this.results_record_update_button.Name = "results_record_update_button";
            this.results_record_update_button.Size = new System.Drawing.Size(75, 23);
            this.results_record_update_button.TabIndex = 6;
            this.results_record_update_button.Text = "Обновить";
            this.results_record_update_button.UseVisualStyleBackColor = true;
            this.results_record_update_button.Click += new System.EventHandler(this.results_record_update_button_Click);
            // 
            // tags_results_textbox
            // 
            this.tags_results_textbox.Location = new System.Drawing.Point(142, 392);
            this.tags_results_textbox.Name = "tags_results_textbox";
            this.tags_results_textbox.Size = new System.Drawing.Size(303, 20);
            this.tags_results_textbox.TabIndex = 5;
            // 
            // id_results_textbox
            // 
            this.id_results_textbox.Location = new System.Drawing.Point(8, 392);
            this.id_results_textbox.Name = "id_results_textbox";
            this.id_results_textbox.Size = new System.Drawing.Size(83, 20);
            this.id_results_textbox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 373);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Комментарии";
            // 
            // result_delete_record_button
            // 
            this.result_delete_record_button.Location = new System.Drawing.Point(640, 390);
            this.result_delete_record_button.Name = "result_delete_record_button";
            this.result_delete_record_button.Size = new System.Drawing.Size(140, 23);
            this.result_delete_record_button.TabIndex = 3;
            this.result_delete_record_button.Text = "Удалить запись";
            this.result_delete_record_button.UseVisualStyleBackColor = true;
            this.result_delete_record_button.Click += new System.EventHandler(this.result_delete_record_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 373);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Номер записи:";
            // 
            // dataGridView_results
            // 
            this.dataGridView_results.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_results.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView_results.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_results.MultiSelect = false;
            this.dataGridView_results.Name = "dataGridView_results";
            this.dataGridView_results.ReadOnly = true;
            this.dataGridView_results.Size = new System.Drawing.Size(788, 350);
            this.dataGridView_results.TabIndex = 0;
            this.dataGridView_results.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_resources_CellClick);
            // 
            // db_tab_resources
            // 
            this.db_tab_resources.Controls.Add(this.birth_resurses_textbox);
            this.db_tab_resources.Controls.Add(this.label12);
            this.db_tab_resources.Controls.Add(this.title_resurses_textbox);
            this.db_tab_resources.Controls.Add(this.label11);
            this.db_tab_resources.Controls.Add(this.mname_resurses_textbox);
            this.db_tab_resources.Controls.Add(this.label10);
            this.db_tab_resources.Controls.Add(this.fname_resurses_textbox);
            this.db_tab_resources.Controls.Add(this.label9);
            this.db_tab_resources.Controls.Add(this.resources_insert_record_button);
            this.db_tab_resources.Controls.Add(this.resources_update_record_button);
            this.db_tab_resources.Controls.Add(this.lname_resurses_textbox);
            this.db_tab_resources.Controls.Add(this.label8);
            this.db_tab_resources.Controls.Add(this.resource_delete_record_button);
            this.db_tab_resources.Controls.Add(this.id_resources_textbox);
            this.db_tab_resources.Controls.Add(this.label7);
            this.db_tab_resources.Controls.Add(this.dataGridView_resources);
            this.db_tab_resources.Location = new System.Drawing.Point(4, 22);
            this.db_tab_resources.Name = "db_tab_resources";
            this.db_tab_resources.Padding = new System.Windows.Forms.Padding(3);
            this.db_tab_resources.Size = new System.Drawing.Size(788, 431);
            this.db_tab_resources.TabIndex = 0;
            this.db_tab_resources.Text = "Участники";
            this.db_tab_resources.UseVisualStyleBackColor = true;
            // 
            // birth_resurses_textbox
            // 
            this.birth_resurses_textbox.Location = new System.Drawing.Point(437, 392);
            this.birth_resurses_textbox.Name = "birth_resurses_textbox";
            this.birth_resurses_textbox.Size = new System.Drawing.Size(96, 20);
            this.birth_resurses_textbox.TabIndex = 26;
            this.birth_resurses_textbox.Text = "гггг-мм-дд";
            this.birth_resurses_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(434, 373);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Дата рождения";
            // 
            // title_resurses_textbox
            // 
            this.title_resurses_textbox.Location = new System.Drawing.Point(357, 392);
            this.title_resurses_textbox.Name = "title_resurses_textbox";
            this.title_resurses_textbox.Size = new System.Drawing.Size(74, 20);
            this.title_resurses_textbox.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(354, 373);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Должность";
            // 
            // mname_resurses_textbox
            // 
            this.mname_resurses_textbox.Location = new System.Drawing.Point(277, 392);
            this.mname_resurses_textbox.Name = "mname_resurses_textbox";
            this.mname_resurses_textbox.Size = new System.Drawing.Size(74, 20);
            this.mname_resurses_textbox.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(274, 373);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Отчество";
            // 
            // fname_resurses_textbox
            // 
            this.fname_resurses_textbox.Location = new System.Drawing.Point(197, 392);
            this.fname_resurses_textbox.Name = "fname_resurses_textbox";
            this.fname_resurses_textbox.Size = new System.Drawing.Size(74, 20);
            this.fname_resurses_textbox.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(194, 373);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Имя";
            // 
            // resources_insert_record_button
            // 
            this.resources_insert_record_button.Location = new System.Drawing.Point(539, 368);
            this.resources_insert_record_button.Name = "resources_insert_record_button";
            this.resources_insert_record_button.Size = new System.Drawing.Size(75, 23);
            this.resources_insert_record_button.TabIndex = 18;
            this.resources_insert_record_button.Text = "Добавить";
            this.resources_insert_record_button.UseVisualStyleBackColor = true;
            this.resources_insert_record_button.Click += new System.EventHandler(this.resources_insert_record_button_Click);
            // 
            // resources_update_record_button
            // 
            this.resources_update_record_button.Location = new System.Drawing.Point(539, 395);
            this.resources_update_record_button.Name = "resources_update_record_button";
            this.resources_update_record_button.Size = new System.Drawing.Size(75, 23);
            this.resources_update_record_button.TabIndex = 17;
            this.resources_update_record_button.Text = "Обновить";
            this.resources_update_record_button.UseVisualStyleBackColor = true;
            this.resources_update_record_button.Click += new System.EventHandler(this.resources_update_record_button_Click);
            // 
            // lname_resurses_textbox
            // 
            this.lname_resurses_textbox.Location = new System.Drawing.Point(117, 392);
            this.lname_resurses_textbox.Name = "lname_resurses_textbox";
            this.lname_resurses_textbox.Size = new System.Drawing.Size(74, 20);
            this.lname_resurses_textbox.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(114, 373);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Фамилия";
            // 
            // resource_delete_record_button
            // 
            this.resource_delete_record_button.Location = new System.Drawing.Point(640, 390);
            this.resource_delete_record_button.Name = "resource_delete_record_button";
            this.resource_delete_record_button.Size = new System.Drawing.Size(140, 23);
            this.resource_delete_record_button.TabIndex = 5;
            this.resource_delete_record_button.Text = "Удалить запись";
            this.resource_delete_record_button.UseVisualStyleBackColor = true;
            this.resource_delete_record_button.Click += new System.EventHandler(this.resource_delete_record_button_Click);
            // 
            // id_resources_textbox
            // 
            this.id_resources_textbox.Location = new System.Drawing.Point(6, 392);
            this.id_resources_textbox.Name = "id_resources_textbox";
            this.id_resources_textbox.Size = new System.Drawing.Size(83, 20);
            this.id_resources_textbox.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 373);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Номер записи:";
            // 
            // dataGridView_resources
            // 
            this.dataGridView_resources.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_resources.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_resources.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView_resources.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_resources.MultiSelect = false;
            this.dataGridView_resources.Name = "dataGridView_resources";
            this.dataGridView_resources.ReadOnly = true;
            this.dataGridView_resources.Size = new System.Drawing.Size(782, 350);
            this.dataGridView_resources.TabIndex = 0;
            this.dataGridView_resources.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_resources_CellClick);
            this.dataGridView_resources.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridView_resources_KeyPress);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.db_tab_resources);
            this.tabControl1.Controls.Add(this.db_tab_results);
            this.tabControl1.Controls.Add(this.db_tab_tests);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(796, 457);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // DB_view_Close_button
            // 
            this.DB_view_Close_button.Location = new System.Drawing.Point(680, 477);
            this.DB_view_Close_button.Name = "DB_view_Close_button";
            this.DB_view_Close_button.Size = new System.Drawing.Size(75, 23);
            this.DB_view_Close_button.TabIndex = 3;
            this.DB_view_Close_button.Text = "Закрыть";
            this.DB_view_Close_button.UseVisualStyleBackColor = true;
            this.DB_view_Close_button.Click += new System.EventHandler(this.DB_view_Close_button_Click);
            // 
            // DB_viewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 522);
            this.Controls.Add(this.DB_view_Close_button);
            this.Controls.Add(this.Save_DB_to_CSV_button);
            this.Controls.Add(this.tabControl1);
            this.Name = "DB_viewer";
            this.Text = "База Данных";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.db_tab_tests.ResumeLayout(false);
            this.db_tab_tests.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tests)).EndInit();
            this.db_tab_results.ResumeLayout(false);
            this.db_tab_results.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_results)).EndInit();
            this.db_tab_resources.ResumeLayout(false);
            this.db_tab_resources.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_resources)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Save_DB_to_CSV_button;
        private System.Windows.Forms.TabPage db_tab_tests;
        private System.Windows.Forms.Button tests_add_record_button;
        private System.Windows.Forms.TextBox script_tests_textbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox description_tests_textbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button tests_update_record_button;
        private System.Windows.Forms.TextBox name_tests_textbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button test_delete_record_button;
        private System.Windows.Forms.TextBox id_tests_textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView_tests;
        private System.Windows.Forms.TabPage db_tab_results;
        private System.Windows.Forms.Button results_record_update_button;
        private System.Windows.Forms.TextBox tags_results_textbox;
        private System.Windows.Forms.TextBox id_results_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button result_delete_record_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_results;
        private System.Windows.Forms.TabPage db_tab_resources;
        private System.Windows.Forms.TextBox birth_resurses_textbox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox title_resurses_textbox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox mname_resurses_textbox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox fname_resurses_textbox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button resources_insert_record_button;
        private System.Windows.Forms.Button resources_update_record_button;
        private System.Windows.Forms.TextBox lname_resurses_textbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button resource_delete_record_button;
        private System.Windows.Forms.TextBox id_resources_textbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView_resources;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button DB_view_Close_button;
    }
}