namespace Reflexes_UI
{
    partial class DB_parameters
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
            this.DB_name_label = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.db_pass = new System.Windows.Forms.TextBox();
            this.db_param_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DB_name_label
            // 
            this.DB_name_label.AutoSize = true;
            this.DB_name_label.Location = new System.Drawing.Point(12, 30);
            this.DB_name_label.Name = "DB_name_label";
            this.DB_name_label.Size = new System.Drawing.Size(38, 13);
            this.DB_name_label.TabIndex = 0;
            this.DB_name_label.Text = "Адрес";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(76, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(208, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "127.0.0.1";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(76, 59);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(208, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "secundomer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Имя базы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пароль";
            // 
            // db_pass
            // 
            this.db_pass.Location = new System.Drawing.Point(76, 96);
            this.db_pass.Name = "db_pass";
            this.db_pass.PasswordChar = '*';
            this.db_pass.Size = new System.Drawing.Size(208, 20);
            this.db_pass.TabIndex = 5;
            this.db_pass.Text = "Chountoul70";
            // 
            // db_param_close
            // 
            this.db_param_close.Location = new System.Drawing.Point(332, 94);
            this.db_param_close.Name = "db_param_close";
            this.db_param_close.Size = new System.Drawing.Size(75, 23);
            this.db_param_close.TabIndex = 6;
            this.db_param_close.Text = "OK";
            this.db_param_close.UseVisualStyleBackColor = true;
            this.db_param_close.Click += new System.EventHandler(this.db_param_close_Click);
            // 
            // DB_parameters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 141);
            this.Controls.Add(this.db_param_close);
            this.Controls.Add(this.db_pass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.DB_name_label);
            this.Name = "DB_parameters";
            this.Text = "DB_parameters";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DB_name_label;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox db_pass;
        private System.Windows.Forms.Button db_param_close;
    }
}