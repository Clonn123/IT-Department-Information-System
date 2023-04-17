namespace Course_project
{
    partial class Заявка_на_картриджи
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
            this.BoxCar = new System.Windows.Forms.ComboBox();
            this.bRep = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BoxCar
            // 
            this.BoxCar.FormattingEnabled = true;
            this.BoxCar.Location = new System.Drawing.Point(159, 15);
            this.BoxCar.Name = "BoxCar";
            this.BoxCar.Size = new System.Drawing.Size(212, 24);
            this.BoxCar.TabIndex = 48;
            // 
            // bRep
            // 
            this.bRep.Location = new System.Drawing.Point(42, 54);
            this.bRep.Name = "bRep";
            this.bRep.Size = new System.Drawing.Size(293, 23);
            this.bRep.TabIndex = 47;
            this.bRep.Text = "Создать заявку на заправку картриджа";
            this.bRep.UseVisualStyleBackColor = true;
            this.bRep.Click += new System.EventHandler(this.bRep_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 16);
            this.label1.TabIndex = 45;
            this.label1.Text = "Выберите картридж:";
            // 
            // Заявка_на_картриджи
            // 
            this.AcceptButton = this.bRep;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 84);
            this.Controls.Add(this.BoxCar);
            this.Controls.Add(this.bRep);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Заявка_на_картриджи";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заявка на заправку картриджа";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox BoxCar;
        private System.Windows.Forms.Button bRep;
        private System.Windows.Forms.Label label1;
    }
}