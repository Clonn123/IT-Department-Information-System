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
    public partial class AddDevice : Form
    {
        string employeeId;

        public AddDevice(string employeeId)
        {
            InitializeComponent();
            textBoxId.Text = $"{MainForm.deviceCount + 1}";
            textBoxId.Enabled = false;
            this.employeeId = employeeId;
            textBoxCode_of_employee.Text = $"{employeeId}";
            textBoxCode_of_employee.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "")
            {
                MessageBox.Show("Вы не ввели наименование девайса");
                return;
            }
            if (textBoxDevice_status.Text == "")
            {
                MessageBox.Show("Вы не ввели статус");
                return;
            }
            string name, status;
            name = textBoxName.Text;
            status = textBoxDevice_status.Text;
            InteractionWithDB db = new InteractionWithDB();
            db.OpenConnection(); 
            var sqlq = $@"INSERT INTO Device (Device_id, Name, Code_of_employee, Device_status) VALUES ({MainForm.deviceCount + 1},@name,{employeeId},@status)";
            var cmd = new SqlCommand(sqlq, db.GetConnection());
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.ExecuteNonQuery();
            db.CloseConnection();
            MainForm.deviceCount++;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBoxCourseNumber_KeyUp(object sender, KeyEventArgs e)
        {
            if (int.TryParse(textBoxCode_of_employee.Text, out int w) || textBoxCode_of_employee.Text == "")
            {
                
            }
            else
            {
                MessageBox.Show("Вы ввели символ, вводите цифры!");
                textBoxCode_of_employee.Clear();
            }
        }
    }
}
