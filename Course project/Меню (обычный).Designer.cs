namespace Course_project
{
    partial class Меню__обычный_
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
            this.bRepDev = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bRepCar = new System.Windows.Forms.Button();
            this.BoxDev = new System.Windows.Forms.ComboBox();
            this.BoxDoc = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // bRepDev
            // 
            this.bRepDev.Location = new System.Drawing.Point(82, 125);
            this.bRepDev.Name = "bRepDev";
            this.bRepDev.Size = new System.Drawing.Size(293, 31);
            this.bRepDev.TabIndex = 21;
            this.bRepDev.Text = "Создать заявку на ремонт оборудования";
            this.bRepDev.UseVisualStyleBackColor = true;
            this.bRepDev.Click += new System.EventHandler(this.bRepDev_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Добро пожаловать в главное меню!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "Ваши устройства:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "Ваши картриджы для устройств:";
            // 
            // bRepCar
            // 
            this.bRepCar.Location = new System.Drawing.Point(82, 162);
            this.bRepCar.Name = "bRepCar";
            this.bRepCar.Size = new System.Drawing.Size(293, 28);
            this.bRepCar.TabIndex = 28;
            this.bRepCar.Text = "Создать заявку на заправку картриджа";
            this.bRepCar.UseVisualStyleBackColor = true;
            this.bRepCar.Click += new System.EventHandler(this.bRepCar_Click);
            // 
            // BoxDev
            // 
            this.BoxDev.FormattingEnabled = true;
            this.BoxDev.Location = new System.Drawing.Point(141, 47);
            this.BoxDev.Name = "BoxDev";
            this.BoxDev.Size = new System.Drawing.Size(290, 24);
            this.BoxDev.TabIndex = 35;
            // 
            // BoxDoc
            // 
            this.BoxDoc.FormattingEnabled = true;
            this.BoxDoc.Location = new System.Drawing.Point(234, 86);
            this.BoxDoc.Name = "BoxDoc";
            this.BoxDoc.Size = new System.Drawing.Size(197, 24);
            this.BoxDoc.TabIndex = 36;
            // 
            // Меню__обычный_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 195);
            this.Controls.Add(this.BoxDoc);
            this.Controls.Add(this.BoxDev);
            this.Controls.Add(this.bRepCar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bRepDev);
            this.Name = "Меню__обычный_";
            this.Text = "Главное меню";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Меню__обычный__FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bRepDev;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bRepCar;
        private System.Windows.Forms.ComboBox BoxDev;
        private System.Windows.Forms.ComboBox BoxDoc;
    }
}