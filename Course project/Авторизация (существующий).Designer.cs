namespace Course_project
{
    partial class Авторизация__существующий_
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.bAuth = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.TextBox();
            this.notRegister = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Введите имя пользователя";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(247, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Введите имя пользователя и пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Введите пароль";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(126, 75);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(330, 22);
            this.Password.TabIndex = 12;
            // 
            // bAuth
            // 
            this.bAuth.Location = new System.Drawing.Point(126, 114);
            this.bAuth.Name = "bAuth";
            this.bAuth.Size = new System.Drawing.Size(233, 30);
            this.bAuth.TabIndex = 11;
            this.bAuth.Text = "Завершить авторизацию";
            this.bAuth.UseVisualStyleBackColor = true;
            this.bAuth.Click += new System.EventHandler(this.bAuth_Click);
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(199, 42);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(257, 22);
            this.Login.TabIndex = 20;
            // 
            // notRegister
            // 
            this.notRegister.AutoSize = true;
            this.notRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.notRegister.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notRegister.Location = new System.Drawing.Point(139, 153);
            this.notRegister.Name = "notRegister";
            this.notRegister.Size = new System.Drawing.Size(208, 19);
            this.notRegister.TabIndex = 21;
            this.notRegister.Text = "Еще не зарегестрированны?";
            this.notRegister.Click += new System.EventHandler(this.notRegister_Click);
            // 
            // Авторизация__существующий_
            // 
            this.AcceptButton = this.bAuth;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 181);
            this.Controls.Add(this.notRegister);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.bAuth);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Авторизация__существующий_";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация существующего пользователя";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Авторизация__существующий__FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button bAuth;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.Label notRegister;
    }
}