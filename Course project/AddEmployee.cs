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
    public partial class AddEmployee : Form
    {
        string job_code;

        public AddEmployee(string jobId)
        {
            InitializeComponent();
            textBoxId.Text = $"{MainForm.employeeCount + 1}";
            textBoxId.Enabled = false;
            this.job_code = jobId;
            textBoxJob_code.Text = $"{jobId}";
            textBoxJob_code.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (textBoxFirstname.Text == "")
            {
                MessageBox.Show("Вы не ввели имя");
                return;
            }
            if (textBoxSurname.Text == "")
            {
                MessageBox.Show("Вы не ввели фамилию");
                return;
            }
            if (bLog.Text == "")
            {
                MessageBox.Show("Вы не ввели логин");
                return;
            }
            if (bPas.Text == "")
            {
                MessageBox.Show("Вы не ввели пароль");
                return;
            }

            if (checkLogin())
            {
                return;
            }

            string name, surname, fathername, pas, login;
            name = textBoxFirstname.Text;
            surname = textBoxSurname.Text;
            fathername = textBoxFather_name.Text;
            login = bLog.Text;
            pas = bPas.Text;
            InteractionWithDB db = new InteractionWithDB();
            db.OpenConnection();
            var sqlq = "";
            if (checkAdmin.Checked == false)
            {
                sqlq = $@"INSERT INTO Employee (Employee_code, Firstname, Surname, [Father's_name], Job_code, Login, Password) VALUES ({MainForm.employeeCount + 1}, @name, @surname, @fathername, {job_code}, @login, @password)";
            }
            else
            {
                sqlq = $@"INSERT INTO Employee (Employee_code, Firstname, Surname, [Father's_name], Job_code, Login, Password, Admin) VALUES ({MainForm.employeeCount + 1}, @name, @surname, @fathername, {job_code}, @login, @password, 1)";
            }
            var cmd = new SqlCommand(sqlq, db.GetConnection());
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@surname", surname);
            cmd.Parameters.AddWithValue("@fathername", fathername);
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@password", pas);
            cmd.ExecuteNonQuery();
            db.CloseConnection();
            MainForm.employeeCount++;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        public bool checkLogin()
        {
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            InteractionWithDB db = new InteractionWithDB();
            db.OpenConnection();
            var sqlq = $@"SELECT *  FROM [Employee] WHERE [Login] = @login";
            var cmd = new SqlCommand(sqlq, db.GetConnection());
            cmd.Parameters.AddWithValue("@login", bLog.Text);
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            db.CloseConnection(); //Возможно нужно после циклов

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь с таким логином уже существует в системе");
                return true;
            }
            else
            {
                MessageBox.Show("Пользователь создан");
                return false;
            }
        }
    }
}
