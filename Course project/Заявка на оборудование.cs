using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using TreeWithSQL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Course_project
{
    public partial class Заявка_на_оборудование : Form
    {
        int reqId, idDev;
        string empId;
        public Заявка_на_оборудование(string EmpId)
        {
            InitializeComponent();
            InteractionWithDB db = new InteractionWithDB();
            this.empId = EmpId;
            SqlDataAdapter da = new SqlDataAdapter($"select * from Device where Code_of_employee = {empId}", db.GetConnection());
            DataTable tbl = new DataTable();
            da.Fill(tbl);
            BoxDev.DataSource = tbl;
            BoxDev.DisplayMember = "Name";// столбец для отображения
            BoxDev.ValueMember = "Device_id";//столбец с id
            BoxDev.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        }

        private void bRep_Click(object sender, EventArgs e) //Создание заявки
        {
            if (BoxDev.Items.Count == 0)
            {
                MessageBox.Show("У вас нет оборудования на которое можно создать заявку");
            }
            else
            {
                idDev = (int)BoxDev.SelectedValue;
                if (checkDev())
                {
                    return;
                }
                InteractionWithDB db = new InteractionWithDB();
                db.OpenConnection();
                var sqlMax = @"SELECT MAX(idReq) as Последний FROM Repair_request";
                var cmd = new SqlCommand(sqlMax, db.GetConnection());
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        if (dr.IsDBNull(0) == true)
                        {
                            reqId = 1;
                        }
                        else
                        {
                            reqId = int.Parse(dr["Последний"].ToString()) + 1;
                        }
                    }
                }
                var sqlq = $@"INSERT INTO Repair_request (idReq, Device_id) VALUES (@reqId, @idDev)";
                cmd = new SqlCommand(sqlq, db.GetConnection());
                cmd.Parameters.AddWithValue("@reqId", reqId);
                cmd.Parameters.AddWithValue("@idDev", idDev);
                cmd.ExecuteNonQuery();
                db.CloseConnection();
                Close();
            }
        }

        public bool checkDev()
        {
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            InteractionWithDB db = new InteractionWithDB();
            db.OpenConnection();
            var sqlq = $@"SELECT *  FROM [Repair_request] WHERE [Device_id] = @idDev";
            var cmd = new SqlCommand(sqlq, db.GetConnection());
            cmd.Parameters.AddWithValue("@idDev", idDev);

            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            db.CloseConnection();

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Заявка на ремонт данного оборудования уже создана, ожидайте ее выполнения");
                return true;
            }
            else
            {
                MessageBox.Show("Заявка создана");
                return false;
            }
        }
    }
}
