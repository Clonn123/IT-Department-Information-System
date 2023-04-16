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
    public partial class UpdateEmployee : Form
    {
        string id;
        string job;

        public UpdateEmployee(string id, string job, string FCs)
        {
            InitializeComponent();
            InteractionWithDB db = new InteractionWithDB();
            this.id = id;
            this.job = job;
            SqlDataAdapter da = new SqlDataAdapter("select * from Job_title", db.GetConnection());
            DataTable tbl = new DataTable();
            da.Fill(tbl);
            BoxJob_code.DataSource = tbl;
            BoxJob_code.DisplayMember = "Name";// столбец для отображения
            BoxJob_code.ValueMember = "Job_code";//столбец с id
            BoxJob_code.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            FCs = FCs.Substring(10);
            string[] words = FCs.Split(new[] {' '});
            textBoxFirstname.Text = words[0];
            textBoxSurname.Text = words[1];
            textBoxFather_name.Text = words[2];
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
            string name, surname, fathername, pass, login;
            bool exists = false;
            int idJob = (int)BoxJob_code.SelectedValue;
            name = textBoxFirstname.Text;
            surname = textBoxSurname.Text;
            fathername = textBoxFather_name.Text;
            pass = bPas.Text;
            login = bLog.Text;
            InteractionWithDB db = new InteractionWithDB();
            db.OpenConnection();
            var sqlq = "";
            if (checkAdmin.Checked == false)
            {
                sqlq = $"UPDATE Employee SET Firstname = @name, Surname = @surname, [Father's_name] = @fathername, Job_code = {idJob}, Login = @login, Password = @password  WHERE [Employee_code] = {id}";
            }
            else
            {
                sqlq = $"UPDATE Employee SET Firstname = @name, Surname = @surname, [Father's_name] = @fathername, Job_code = {idJob}, Login = @login, Password = @password, Admin = 1  WHERE [Employee_code] = {id}";
            }
            var cmd = new SqlCommand(sqlq, db.GetConnection());
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@surname", surname);
            cmd.Parameters.AddWithValue("@fathername", fathername);
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@password", pass);
            cmd.ExecuteNonQuery();
            db.CloseConnection();
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
