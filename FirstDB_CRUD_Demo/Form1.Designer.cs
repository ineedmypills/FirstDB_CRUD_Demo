namespace FirstDB_CRUD_Demo
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_connect = new System.Windows.Forms.Button();
            this.tb_dbFilename = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_age = new System.Windows.Forms.TextBox();
            this.btn_left = new System.Windows.Forms.Button();
            this.btn_right = new System.Windows.Forms.Button();
            this.lb_name = new System.Windows.Forms.Label();
            this.lb_age = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(15, 70);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(232, 39);
            this.btn_connect.TabIndex = 0;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_dbFilename
            // 
            this.tb_dbFilename.Location = new System.Drawing.Point(15, 12);
            this.tb_dbFilename.Multiline = true;
            this.tb_dbFilename.Name = "tb_dbFilename";
            this.tb_dbFilename.Size = new System.Drawing.Size(232, 52);
            this.tb_dbFilename.TabIndex = 1;
            this.tb_dbFilename.TextChanged += new System.EventHandler(this.f_TextChanged);
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(12, 182);
            this.tb_name.Multiline = true;
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(232, 52);
            this.tb_name.TabIndex = 2;
            this.tb_name.TextChanged += new System.EventHandler(this.tb_name_TextChanged);
            // 
            // tb_age
            // 
            this.tb_age.Location = new System.Drawing.Point(12, 261);
            this.tb_age.Multiline = true;
            this.tb_age.Name = "tb_age";
            this.tb_age.Size = new System.Drawing.Size(232, 52);
            this.tb_age.TabIndex = 3;
            this.tb_age.TextChanged += new System.EventHandler(this.tb_age_TextChanged);
            // 
            // btn_left
            // 
            this.btn_left.Location = new System.Drawing.Point(12, 370);
            this.btn_left.Name = "btn_left";
            this.btn_left.Size = new System.Drawing.Size(113, 26);
            this.btn_left.TabIndex = 4;
            this.btn_left.Text = "<";
            this.btn_left.UseVisualStyleBackColor = true;
            this.btn_left.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_right
            // 
            this.btn_right.Location = new System.Drawing.Point(131, 370);
            this.btn_right.Name = "btn_right";
            this.btn_right.Size = new System.Drawing.Size(114, 26);
            this.btn_right.TabIndex = 5;
            this.btn_right.Text = ">";
            this.btn_right.UseVisualStyleBackColor = true;
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Location = new System.Drawing.Point(12, 166);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(35, 13);
            this.lb_name.TabIndex = 6;
            this.lb_name.Text = "Name";
            // 
            // lb_age
            // 
            this.lb_age.AutoSize = true;
            this.lb_age.Location = new System.Drawing.Point(12, 245);
            this.lb_age.Name = "lb_age";
            this.lb_age.Size = new System.Drawing.Size(26, 13);
            this.lb_age.TabIndex = 7;
            this.lb_age.Text = "Age";
            this.lb_age.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(13, 402);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(232, 40);
            this.btn_save.TabIndex = 8;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 450);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.lb_age);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.btn_right);
            this.Controls.Add(this.btn_left);
            this.Controls.Add(this.tb_age);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.tb_dbFilename);
            this.Controls.Add(this.btn_connect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.TextBox tb_dbFilename;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_age;
        private System.Windows.Forms.Button btn_left;
        private System.Windows.Forms.Button btn_right;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label lb_age;
        private System.Windows.Forms.Button btn_save;
    }
}

