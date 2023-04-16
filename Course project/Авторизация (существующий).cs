using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using TreeWithSQL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Course_project
{
    public partial class Авторизация__существующий_ : Form
    {
        string idEmp;
        public Авторизация__существующий_()
        {
            InitializeComponent();
        }

        private void bAuth_Click(object sender, EventArgs e)
        {
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

            string login = Login.Text;
            string password = Password.Text;
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            InteractionWithDB db = new InteractionWithDB();
            db.OpenConnection();
            var sqlq = $@"SELECT *  FROM [Employee] WHERE [Login] = @login AND [Password] = @password";
            var cmd = new SqlCommand(sqlq, db.GetConnection());
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@password", password);

            adapter.SelectCommand = cmd;
            adapter.Fill(table);

            if (table.Rows.Count > 0 )
            {
                int check = 0;
                sqlq = $@"SELECT Admin FROM [Employee] WHERE [Login] = @login";
                cmd = new SqlCommand(sqlq, db.GetConnection());
                cmd.Parameters.AddWithValue("@login", login);
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        check = int.Parse(dr["Admin"].ToString());
                    }
                }
                if (check == 0)
                {
                    sqlq = $@"SELECT *  FROM [Employee] WHERE [Login] = @login AND [Password] = @password";
                    cmd = new SqlCommand(sqlq, db.GetConnection());
                    cmd.Parameters.AddWithValue("@login", login);
                    cmd.Parameters.AddWithValue("@password", password);
                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            idEmp = dr["Employee_code"].ToString();
                        }
                    }
                    db.CloseConnection();
                    this.Hide();
                    Меню__обычный_ mainForm = new Меню__обычный_(idEmp);
                    mainForm.Show();
                }
                else
                {
                    db.CloseConnection();
                    this.Hide();
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                }
            }
            else MessageBox.Show("Логин или пароль неверны");
            db.CloseConnection();
        }

        private void notRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Авторизация register = new Авторизация();
            register.Show();           
        }

        private void Авторизация__существующий__FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
