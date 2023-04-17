namespace Course_project
{
    partial class Заявка_на_оборудование
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
            this.bRep = new System.Windows.Forms.Button();
            this.BoxDev = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bRep
            // 
            this.bRep.Location = new System.Drawing.Point(80, 51);
            this.bRep.Name = "bRep";
            this.bRep.Size = new System.Drawing.Size(293, 23);
            this.bRep.TabIndex = 37;
            this.bRep.Text = "Создать заявку на ремонт оборудования";
            this.bRep.UseVisualStyleBackColor = true;
            this.bRep.Click += new System.EventHandler(this.bRep_Click);
            // 
            // BoxDev
            // 
            this.BoxDev.FormattingEnabled = true;
            this.BoxDev.Location = new System.Drawing.Point(188, 12);
            this.BoxDev.Name = "BoxDev";
            this.BoxDev.Size = new System.Drawing.Size(234, 24);
            this.BoxDev.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 16);
            this.label3.TabIndex = 49;
            this.label3.Text = "Выберите оборудование:";
            // 
            // Заявка_на_оборудование
            // 
            this.AcceptButton = this.bRep;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 86);
            this.Controls.Add(this.BoxDev);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bRep);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Заявка_на_оборудование";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заявка на ремонт оборудования";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bRep;
        private System.Windows.Forms.ComboBox BoxDev;
        private System.Windows.Forms.Label label3;
    }
}