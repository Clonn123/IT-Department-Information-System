using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TreeWithSQL
{
    public partial class AddJob : Form
    {
        public AddJob()
        {
            InitializeComponent();
            textBoxId.Text = $"{MainForm.jobCount+1}";
            textBoxId.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {          
            if (textBoxName.Text == "")
            {
                MessageBox.Show("Вы не ввели имя");
                return;
            }
            if (textBoxSalary.Text == "")
            {
                MessageBox.Show("Вы не ввели зарплату");
                return;
            }
            int buf = 0;
            bool check;
            check = int.TryParse(textBoxSalary.Text, out buf);
            if (check == false)
            {
                MessageBox.Show("Введено не верное значение зарплаты");
                return;
            }
            else
            {
                string name;
                name = textBoxName.Text;
                InteractionWithDB db = new InteractionWithDB();
                db.OpenConnection(); var sqlq = $@"INSERT INTO Job_title (Job_code, Name, Salary) VALUES ({MainForm.jobCount + 1}, @name, '{textBoxSalary.Text}')";
                var cmd = new SqlCommand(sqlq, db.GetConnection());
                cmd.Parameters.AddWithValue("@name", name);
                cmd.ExecuteNonQuery();
                MainForm.jobCount++;
                db.CloseConnection();
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
