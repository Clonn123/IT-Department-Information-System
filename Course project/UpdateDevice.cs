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
    public partial class UpdateDevice : Form
    {
        string id;
        string empId;

        public UpdateDevice(string id, string empId, string name)
        {
            InitializeComponent();
            InteractionWithDB db = new InteractionWithDB();
            this.id = id;
            this.empId = empId;
            SqlDataAdapter da = new SqlDataAdapter("Select E.Surname + ' ' + E.Firstname + ' ' + E.[Father's_name] as ФИО, Employee_code from Employee E ", db.GetConnection());
            DataTable tbl = new DataTable();
            da.Fill(tbl);
            BoxCode.DataSource = tbl;
            BoxCode.DisplayMember = "ФИО";// столбец для отображения
            BoxCode.ValueMember = "Employee_code";//столбец с id
            BoxCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            name = name.Substring(10);
            textBoxName.Text = name;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "")
            {
                MessageBox.Show("Вы не ввели наимнование");
                return;
            }
            if (textBoxStatus.Text == "")
            {
                MessageBox.Show("Вы не ввели статус");
                return;
            }
            string name, status;
            int idEmp = (int)BoxCode.SelectedValue;
            name = textBoxName.Text;
            status = textBoxStatus.Text;
            InteractionWithDB db = new InteractionWithDB();
            db.OpenConnection(); var sqlq = $"UPDATE Device SET Name = @name, Code_of_employee = {idEmp}, Device_status = @status WHERE Device_id = {id}";
            var cmd = new SqlCommand(sqlq, db.GetConnection());
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@status", status);
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
