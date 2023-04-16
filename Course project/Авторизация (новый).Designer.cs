namespace Course_project
{
    partial class Авторизация
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
            this.bReg = new System.Windows.Forms.Button();
            this.tSurname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tName = new System.Windows.Forms.TextBox();
            this.tFather = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Login = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.notRegister = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bReg
            // 
            this.bReg.Location = new System.Drawing.Point(115, 233);
            this.bReg.Name = "bReg";
            this.bReg.Size = new System.Drawing.Size(275, 26);
            this.bReg.TabIndex = 0;
            this.bReg.Text = "Завершить регистрацию";
            this.bReg.UseVisualStyleBackColor = true;
            this.bReg.Click += new System.EventHandler(this.bReg_Click);
            // 
            // tSurname
            // 
            this.tSurname.Location = new System.Drawing.Point(97, 43);
            this.tSurname.Name = "tSurname";
            this.tSurname.Size = new System.Drawing.Size(380, 22);
            this.tSurname.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Отчество";
            // 
            // tName
            // 
            this.tName.Location = new System.Drawing.Point(97, 78);
            this.tName.Name = "tName";
            this.tName.Size = new System.Drawing.Size(380, 22);
            this.tName.TabIndex = 6;
            // 
            // tFather
            // 
            this.tFather.Location = new System.Drawing.Point(97, 109);
            this.tFather.Name = "tFather";
            this.tFather.Size = new System.Drawing.Size(380, 22);
            this.tFather.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(260, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Введите данные нового пользователя";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Выберите должность";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(172, 203);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(305, 24);
            this.comboBox1.TabIndex = 10;
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(97, 137);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(380, 22);
            this.Login.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "Логин";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "Пароль";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(97, 170);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(380, 22);
            this.Password.TabIndex = 21;
            // 
            // notRegister
            // 
            this.notRegister.AutoSize = true;
            this.notRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.notRegister.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notRegister.Location = new System.Drawing.Point(168, 262);
            this.notRegister.Name = "notRegister";
            this.notRegister.Size = new System.Drawing.Size(188, 19);
            this.notRegister.TabIndex = 25;
            this.notRegister.Text = "Уже зарегестрированны?";
            this.notRegister.Click += new System.EventHandler(this.notRegister_Click);
            // 
            // Авторизация
            // 
            this.AcceptButton = this.bReg;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 287);
            this.Controls.Add(this.notRegister);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tFather);
            this.Controls.Add(this.tName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tSurname);
            this.Controls.Add(this.bReg);
            this.Name = "Авторизация";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создание нового пользователя";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Авторизация_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bReg;
        private System.Windows.Forms.TextBox tSurname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tName;
        private System.Windows.Forms.TextBox tFather;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label notRegister;
    }
}

