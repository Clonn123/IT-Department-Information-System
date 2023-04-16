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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TreeWithSQL
{
    public partial class UpdateCartridge : Form
    {
        string id;
        public UpdateCartridge(string idDev)
        {
            InitializeComponent();
            InteractionWithDB db = new InteractionWithDB();
            this.id = idDev;
            SqlDataAdapter da = new SqlDataAdapter($"Select * from Cartridge where The_code_of_the_device = {int.Parse(id)}", db.GetConnection());
            DataTable tbl = new DataTable();
            da.Fill(tbl);
            BoxCartridge.DataSource = tbl;
            BoxCartridge.DisplayMember = "Individual_cartridge_code";// столбец для отображения
            BoxCartridge.ValueMember = "Individual_cartridge_code";//столбец с id
            BoxCartridge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            SqlDataAdapter da2 = new SqlDataAdapter("Select * from Device", @"Data Source= DESKTOP-71E3IQV; Initial Catalog = RepairModul; Integrated Security = True;");
            DataTable tbl2 = new DataTable();
            da2.Fill(tbl2);
            BoxDevice.DataSource = tbl2;
            BoxDevice.DisplayMember = "Name";// столбец для отображения
            BoxDevice.ValueMember = "Device_id";//столбец с id
            BoxDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (BoxCartridge.Items.Count == 0)
            {
                MessageBox.Show("У вас нет картриджей которые можно изменить");
                return;
            }
            if (textBoxStatus.Text == "")
            {
                MessageBox.Show("Вы не ввели статус");
                return;
            }
            string status;
            int idDev = (int)BoxDevice.SelectedValue;
            int idCar = (int)BoxCartridge.SelectedValue;
            status = textBoxStatus.Text;
            InteractionWithDB db = new InteractionWithDB();
            db.OpenConnection();
            var sqlq = $"UPDATE Cartridge SET Cartridge_status = @status, The_code_of_the_device = {idDev} WHERE Individual_cartridge_code = {idCar}";
            var cmd = new SqlCommand(sqlq, db.GetConnection());
            cmd.Parameters.AddWithValue("@status", status);
            cmd.ExecuteNonQuery();
            db.CloseConnection();
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DelCar_Click(object sender, EventArgs e)
        {
            if (BoxCartridge.Items.Count == 0)
            {
                MessageBox.Show("У вас нет картриджей которые можно удалить");
                return;
            }
            InteractionWithDB db = new InteractionWithDB();
            db.OpenConnection();
            var sqlq = $"DELETE FROM Cartridge WHERE Individual_cartridge_code = {(int)BoxCartridge.SelectedValue}";
            var cmd = new SqlCommand(sqlq, db.GetConnection());
            cmd.ExecuteNonQuery();
            db.CloseConnection();
            SqlDataAdapter da = new SqlDataAdapter($"Select * from Cartridge where The_code_of_the_device = {int.Parse(id)}", db.GetConnection());
            DataTable tbl = new DataTable();
            da.Fill(tbl);
            BoxCartridge.DataSource = tbl;
            BoxCartridge.DisplayMember = "Individual_cartridge_code";// столбец для отображения
            BoxCartridge.ValueMember = "Individual_cartridge_code";//столбец с id
        }
    }
}
