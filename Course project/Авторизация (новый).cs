using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TreeWithSQL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Course_project
{
    public partial class Авторизация : Form
    {
        public Авторизация()
        {
            InitializeComponent();
            InteractionWithDB db = new InteractionWithDB();
            SqlDataAdapter da = new SqlDataAdapter("select * from Job_title", db.GetConnection());
            DataTable tbl = new DataTable();
            da.Fill(tbl);
            comboBox1.DataSource = tbl;
            comboBox1.DisplayMember = "Name";// столбец для отображения
            comboBox1.ValueMember = "Job_code";//столбец с id
            comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        }

        private void bReg_Click(object sender, EventArgs e)
        {
            if (tName.Text == "")
            {
                MessageBox.Show("Вы не ввели имя");
                return;
            }
            if (tSurname.Text == "")
            {
                MessageBox.Show("Вы не ввели фамилию");
                return;
            }
            if (Login.Text == "")
            {
                MessageBox.Show("Вы не ввели логин");
                return;
            }
            if (Password.Text == "")
            {
                MessageBox.Show("Вы не ввели пароль");
                return;
            }

            if (checkLogin())
            {
                return;
            }

            int employeeCount = 0, job;
            string name, surname, fathername, pas, login;
            name = tName.Text;
            surname = tSurname.Text;
            fathername = tFather.Text;
            login = Login.Text;
            pas = Password.Text;
            job = (int)comboBox1.SelectedValue;
            InteractionWithDB db = new InteractionWithDB();
            db.OpenConnection();
            var sqlMax = @"SELECT MAX(Employee_code) as Последний
	                            FROM Employee";
            var cmd = new SqlCommand(sqlMax, db.GetConnection());
            using (var dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    employeeCount = int.Parse(dr["Последний"].ToString());
                }
            }
            var sqlq = $@"INSERT INTO Employee (Employee_code, Firstname, Surname, [Father's_name], Job_code, Login, Password) VALUES ({employeeCount + 1}, @name, @surname, @fathername, @job, @login, @password)";
            cmd = new SqlCommand(sqlq, db.GetConnection());
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@surname", surname);
            cmd.Parameters.AddWithValue("@fathername", fathername);
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@password", pas);
            cmd.Parameters.AddWithValue("@job", job);
            cmd.ExecuteNonQuery();
            db.CloseConnection();
            this.Hide();
            Авторизация__существующий_ mainForm = new Авторизация__существующий_();
            mainForm.Show();
        }

        public bool checkLogin()
        {
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            InteractionWithDB db = new InteractionWithDB();
            db.OpenConnection();
            var sqlq = $@"SELECT *  FROM [Employee] WHERE [Login] = @login";
            var cmd = new SqlCommand(sqlq, db.GetConnection());
            cmd.Parameters.AddWithValue("@login", Login.Text);
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

        private void Авторизация_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void notRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Авторизация__существующий_ auth = new Авторизация__существующий_();
            auth.Show();
        }
    }
}
