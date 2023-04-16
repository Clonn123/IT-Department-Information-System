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
using TreeWithSQL;

namespace Course_project
{
    public partial class Заявка_на_картриджи : Form
    {
        int reqId, idCar;
        string empId;
        public Заявка_на_картриджи(string EmpId)
        {
            InitializeComponent();
            InteractionWithDB db = new InteractionWithDB();
            this.empId = EmpId;
            SqlDataAdapter da = new SqlDataAdapter($"select Cartridge.* from Cartridge, Device where Cartridge.The_code_of_the_device = Device.Device_id AND Device.Code_of_employee = {empId}", db.GetConnection());
            DataTable tbl = new DataTable();
            da.Fill(tbl);
            BoxCar.DataSource = tbl;
            BoxCar.DisplayMember = "Individual_cartridge_code";// столбец для отображения
            BoxCar.ValueMember = "Individual_cartridge_code";//столбец с id
            BoxCar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        }

        private void bRep_Click(object sender, EventArgs e) //Создание заявки
        {
            if (BoxCar.Items.Count == 0)
            {
                MessageBox.Show("У вас нет картриджей на которые можно создать заявку");
            }
            else
            {
                idCar = (int)BoxCar.SelectedValue;
                if (checkCar())
                {
                    return;
                }
                InteractionWithDB db = new InteractionWithDB();
                db.OpenConnection();
                var sqlMax = @"SELECT MAX(idReq) as Последний FROM Refueling_request";
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
                var sqlq = $@"INSERT INTO Refueling_request (idReq, Cartridge_code) VALUES (@reqId, @idCar)";
                cmd = new SqlCommand(sqlq, db.GetConnection());
                cmd.Parameters.AddWithValue("@reqId", reqId);
                cmd.Parameters.AddWithValue("@idCar", idCar);
                cmd.ExecuteNonQuery();
                db.CloseConnection();
                Close();
            }
        }

        public bool checkCar()
        {
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            InteractionWithDB db = new InteractionWithDB();
            db.OpenConnection();
            var sqlq = $@"SELECT *  FROM [Refueling_request] WHERE [Cartridge_code] = @idCar";
            var cmd = new SqlCommand(sqlq, db.GetConnection());
            cmd.Parameters.AddWithValue("@idCar", idCar);

            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            db.CloseConnection();

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Заявка на ремонт данного картриджа уже создана, ожидайте ее выполнения");
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
