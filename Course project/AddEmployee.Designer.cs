namespace TreeWithSQL
{
    partial class AddEmployee
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.labelID = new System.Windows.Forms.Label();
            this.labelFacultyId = new System.Windows.Forms.Label();
            this.labelCourseNumber = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxFirstname = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxFather_name = new System.Windows.Forms.TextBox();
            this.textBoxJob_code = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bPas = new System.Windows.Forms.TextBox();
            this.bLog = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkAdmin = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(15, 276);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(117, 28);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(143, 276);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(117, 28);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(17, 21);
            this.labelID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(20, 16);
            this.labelID.TabIndex = 2;
            this.labelID.Text = "ID";
            // 
            // labelFacultyId
            // 
            this.labelFacultyId.AutoSize = true;
            this.labelFacultyId.Location = new System.Drawing.Point(17, 54);
            this.labelFacultyId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFacultyId.Name = "labelFacultyId";
            this.labelFacultyId.Size = new System.Drawing.Size(33, 16);
            this.labelFacultyId.TabIndex = 3;
            this.labelFacultyId.Text = "Имя";
            // 
            // labelCourseNumber
            // 
            this.labelCourseNumber.AutoSize = true;
            this.labelCourseNumber.Location = new System.Drawing.Point(17, 86);
            this.labelCourseNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCourseNumber.Name = "labelCourseNumber";
            this.labelCourseNumber.Size = new System.Drawing.Size(66, 16);
            this.labelCourseNumber.TabIndex = 4;
            this.labelCourseNumber.Text = "Фамилия";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(128, 17);
            this.textBoxId.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(132, 22);
            this.textBoxId.TabIndex = 5;
            // 
            // textBoxFirstname
            // 
            this.textBoxFirstname.Location = new System.Drawing.Point(128, 50);
            this.textBoxFirstname.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFirstname.Name = "textBoxFirstname";
            this.textBoxFirstname.Size = new System.Drawing.Size(132, 22);
            this.textBoxFirstname.TabIndex = 6;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(128, 82);
            this.textBoxSurname.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(132, 22);
            this.textBoxSurname.TabIndex = 7;
            // 
            // textBoxFather_name
            // 
            this.textBoxFather_name.Location = new System.Drawing.Point(128, 112);
            this.textBoxFather_name.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFather_name.Name = "textBoxFather_name";
            this.textBoxFather_name.Size = new System.Drawing.Size(132, 22);
            this.textBoxFather_name.TabIndex = 8;
            // 
            // textBoxJob_code
            // 
            this.textBoxJob_code.Location = new System.Drawing.Point(128, 142);
            this.textBoxJob_code.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxJob_code.Name = "textBoxJob_code";
            this.textBoxJob_code.Size = new System.Drawing.Size(132, 22);
            this.textBoxJob_code.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 115);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Отчество";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 145);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Код работы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 206);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "Пароль";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 176);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 28;
            this.label4.Text = "Логин";
            // 
            // bPas
            // 
            this.bPas.Location = new System.Drawing.Point(128, 203);
            this.bPas.Margin = new System.Windows.Forms.Padding(4);
            this.bPas.Name = "bPas";
            this.bPas.Size = new System.Drawing.Size(132, 22);
            this.bPas.TabIndex = 27;
            // 
            // bLog
            // 
            this.bLog.Location = new System.Drawing.Point(128, 173);
            this.bLog.Margin = new System.Windows.Forms.Padding(4);
            this.bLog.Name = "bLog";
            this.bLog.Size = new System.Drawing.Size(132, 22);
            this.bLog.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 239);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 16);
            this.label5.TabIndex = 30;
            this.label5.Text = "Пользователь администратор?";
            // 
            // checkAdmin
            // 
            this.checkAdmin.AutoSize = true;
            this.checkAdmin.Location = new System.Drawing.Point(238, 240);
            this.checkAdmin.Name = "checkAdmin";
            this.checkAdmin.Size = new System.Drawing.Size(18, 17);
            this.checkAdmin.TabIndex = 31;
            this.checkAdmin.UseVisualStyleBackColor = true;
            // 
            // AddEmployee
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(287, 317);
            this.Controls.Add(this.checkAdmin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bPas);
            this.Controls.Add(this.bLog);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxJob_code);
            this.Controls.Add(this.textBoxFather_name);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxFirstname);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.labelCourseNumber);
            this.Controls.Add(this.labelFacultyId);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление работника";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelFacultyId;
        private System.Windows.Forms.Label labelCourseNumber;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxFirstname;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxFather_name;
        private System.Windows.Forms.TextBox textBoxJob_code;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox bPas;
        private System.Windows.Forms.TextBox bLog;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkAdmin;
    }
}