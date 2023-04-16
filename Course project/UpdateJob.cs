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
    public partial class UpdateJob : Form
    {
        string id;

        public UpdateJob(string id, string name)
        {
            InitializeComponent();
            this.id = id;
            name = name.Substring(10);
            textBoxName.Text = name;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "")
            {
                MessageBox.Show("Вы не ввели наименование");
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
                db.OpenConnection();
                var sqlq = $"UPDATE Job_title SET Name = @name, Salary = {textBoxSalary.Text} WHERE Job_code = {id}";
                var cmd = new SqlCommand(sqlq, db.GetConnection());
                cmd.Parameters.AddWithValue("@name", name);
                cmd.ExecuteNonQuery();
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
