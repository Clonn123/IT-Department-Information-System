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
    public partial class Меню__обычный_ : Form
    {
        string empId;
        public Меню__обычный_(string EmpId)
        {
            InitializeComponent();
            InteractionWithDB db = new InteractionWithDB();
            this.empId = EmpId;
            SqlDataAdapter da1 = new SqlDataAdapter($"select * from Device where Code_of_employee = {empId}", db.GetConnection());
            DataTable tbl1 = new DataTable();
            da1.Fill(tbl1);
            BoxDev.DataSource = tbl1;
            BoxDev.DisplayMember = "Name";// столбец для отображения
            BoxDev.ValueMember = "Device_id";//столбец с id
            BoxDev.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            SqlDataAdapter da2 = new SqlDataAdapter($"select Cartridge.* from Cartridge, Device where Cartridge.The_code_of_the_device = Device.Device_id AND Device.Code_of_employee = {empId}", db.GetConnection());
            DataTable tbl2 = new DataTable();
            da2.Fill(tbl2);
            BoxDoc.DataSource = tbl2;
            BoxDoc.DisplayMember = "Individual_cartridge_code";// столбец для отображения
            BoxDoc.ValueMember = "Individual_cartridge_code";//столбец с id
            BoxDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        }

        private void Меню__обычный__FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void bRepDev_Click(object sender, EventArgs e)
        {
            Заявка_на_оборудование frm = new Заявка_на_оборудование(empId);
            frm.ShowDialog();
        }

        private void bRepCar_Click(object sender, EventArgs e)
        {
            Заявка_на_картриджи frm = new Заявка_на_картриджи(empId);
            frm.ShowDialog();
        }
    }
}
