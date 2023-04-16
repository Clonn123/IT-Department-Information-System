using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TreeWithSQL;

namespace Course_project
{
    public partial class Авторизация__стартовая_ : Form
    {
        public Авторизация__стартовая_()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Авторизация__существующий_ mainForm = new Авторизация__существующий_();
            mainForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Авторизация mainForm = new Авторизация();
            mainForm.Show();
        }
    }
}
