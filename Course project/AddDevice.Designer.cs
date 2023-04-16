namespace TreeWithSQL
{
    partial class AddDevice
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
            this.labelId = new System.Windows.Forms.Label();
            this.labelCourseId = new System.Windows.Forms.Label();
            this.labelGroupNumber = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxCode_of_employee = new System.Windows.Forms.TextBox();
            this.textBoxDevice_status = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(27, 162);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(121, 28);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(157, 162);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(121, 28);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(17, 21);
            this.labelId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(20, 16);
            this.labelId.TabIndex = 2;
            this.labelId.Text = "ID";
            // 
            // labelCourseId
            // 
            this.labelCourseId.AutoSize = true;
            this.labelCourseId.Location = new System.Drawing.Point(17, 53);
            this.labelCourseId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCourseId.Name = "labelCourseId";
            this.labelCourseId.Size = new System.Drawing.Size(106, 16);
            this.labelCourseId.TabIndex = 3;
            this.labelCourseId.Text = "Наименование";
            // 
            // labelGroupNumber
            // 
            this.labelGroupNumber.AutoSize = true;
            this.labelGroupNumber.Location = new System.Drawing.Point(17, 89);
            this.labelGroupNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGroupNumber.Name = "labelGroupNumber";
            this.labelGroupNumber.Size = new System.Drawing.Size(104, 16);
            this.labelGroupNumber.TabIndex = 4;
            this.labelGroupNumber.Text = "Код работника";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(131, 17);
            this.textBoxId.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(147, 22);
            this.textBoxId.TabIndex = 5;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(131, 53);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(147, 22);
            this.textBoxName.TabIndex = 6;
            // 
            // textBoxCode_of_employee
            // 
            this.textBoxCode_of_employee.Location = new System.Drawing.Point(131, 85);
            this.textBoxCode_of_employee.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCode_of_employee.Name = "textBoxCode_of_employee";
            this.textBoxCode_of_employee.Size = new System.Drawing.Size(147, 22);
            this.textBoxCode_of_employee.TabIndex = 7;
            this.textBoxCode_of_employee.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxCourseNumber_KeyUp);
            // 
            // textBoxDevice_status
            // 
            this.textBoxDevice_status.Location = new System.Drawing.Point(157, 115);
            this.textBoxDevice_status.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDevice_status.Name = "textBoxDevice_status";
            this.textBoxDevice_status.Size = new System.Drawing.Size(121, 22);
            this.textBoxDevice_status.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 121);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Статус устройства";
            // 
            // AddDevice
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(296, 196);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDevice_status);
            this.Controls.Add(this.textBoxCode_of_employee);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.labelGroupNumber);
            this.Controls.Add(this.labelCourseId);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddDevice";
            this.Text = "Добавление устройства";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelCourseId;
        private System.Windows.Forms.Label labelGroupNumber;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxCode_of_employee;
        private System.Windows.Forms.TextBox textBoxDevice_status;
        private System.Windows.Forms.Label label1;
    }
}