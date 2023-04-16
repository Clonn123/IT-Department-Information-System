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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public static int jobCount = 0;
        public static int employeeCount = 0;
        public static int deviceCount = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            обновитьДеревоToolStripMenuItem.Enabled = false;
            удалитьДеревоToolStripMenuItem.Enabled = false;
            добавитьФакультетToolStripMenuItem.Enabled = false;
        }

        private void вывестиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InteractionWithDB db = new InteractionWithDB();
            db.OpenConnection();
            var sqlq = "SELECT * FROM [Job_title]";
            var cmd = new SqlCommand(sqlq, db.GetConnection());
            using (var dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    var node = treeView.Nodes.Add(dr["Name"].ToString());
                    node.Tag = dr["Job_code"].ToString();
                    jobCount = int.Parse(dr["Job_code"].ToString());
                    node.ContextMenuStrip = contextMenuStripNodeJob;
                }
            }
            db.CloseConnection();
            вывестиToolStripMenuItem.Enabled = false;
            обновитьДеревоToolStripMenuItem.Enabled = true;
            удалитьДеревоToolStripMenuItem.Enabled = true;
            добавитьФакультетToolStripMenuItem.Enabled = true;
        }

        void LoadEmployeWithFather(TreeNode parent, string jobId)
        {
            InteractionWithDB db = new InteractionWithDB();
            db.GetConnection().Open();
            var sqlMax = @"SELECT MAX(Employee_code) as Последний
	                            FROM Employee";
            var sql = @"Select E.Surname + ' ' + E.Firstname + ' ' + E.[Father's_name] as ФИО, Employee_code
	                            from Employee E 
	                            where E.Job_code = @jobId AND E.[Father's_name] is not NULL";
            var cmd = new SqlCommand(sql, db.GetConnection());
            TreeNode node = new TreeNode();
            cmd.Parameters.AddWithValue("@jobId", jobId);
            using (var dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    node = parent.Nodes.Add(dr["ФИО"].ToString());
                    node.Tag = dr["Employee_code"].ToString();
                    node.ContextMenuStrip = contextMenuStripNodeEmployee;
                }
            }
            cmd = new SqlCommand(sqlMax, db.GetConnection());
            using (var dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    employeeCount = int.Parse(dr["Последний"].ToString());
                }
            }
            db.CloseConnection();
        }

        void LoadDevice(TreeNode parent, string EmployeeId)
        {
            InteractionWithDB db = new InteractionWithDB();
            db.OpenConnection();
            var sqlMax = @"SELECT MAX(Device_id) as Последний
	                            FROM Device";
            var sqlq = $"SELECT * FROM [Device] WHERE [Code_of_employee] = {EmployeeId}";
            var cmd = new SqlCommand(sqlq, db.GetConnection());
            TreeNode node = new TreeNode();
            using (var dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    node = parent.Nodes.Add(dr["Name"].ToString());
                    node.Tag=dr["Device_id"].ToString();
                    node.ContextMenuStrip = contextMenuStripNodeDevice;
                }
            }
            cmd = new SqlCommand(sqlMax, db.GetConnection());
            using (var dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    deviceCount = int.Parse(dr["Последний"].ToString());
                }
            }
            db.CloseConnection();
        }

        private void удалитьДеревоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeView.Nodes.Clear();
            вывестиToolStripMenuItem.Enabled = true;
            обновитьДеревоToolStripMenuItem.Enabled = false;
            удалитьДеревоToolStripMenuItem.Enabled = false;
            добавитьФакультетToolStripMenuItem.Enabled = false;
        }

        private void обновитьДеревоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            удалитьДеревоToolStripMenuItem_Click(sender, e);
            вывестиToolStripMenuItem_Click(sender, e);
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Checked == false)
            {
                if (e.Node.Parent == null)
                {
                    LoadEmployeWithFather(e.Node, e.Node.Tag.ToString());
                    e.Node.Checked = true;
                }
                else
                {
                    if (e.Node.ContextMenuStrip == contextMenuStripNodeEmployee)
                    {
                        LoadDevice(e.Node, e.Node.Tag.ToString());
                        e.Node.Checked = true;
                    }
                }
            }
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InteractionWithDB db = new InteractionWithDB();
            db.OpenConnection();
            var sqlq = $"DELETE FROM Job_title WHERE Job_code = {treeView.SelectedNode.Tag}";
            var cmd = new SqlCommand(sqlq, db.GetConnection());
            cmd.ExecuteNonQuery();
            db.CloseConnection();
            treeView.SelectedNode.Remove();
        }

        private void удалитьToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            InteractionWithDB db = new InteractionWithDB();
            db.OpenConnection();
            var sqlq = $"DELETE FROM Employee WHERE Employee_code = {treeView.SelectedNode.Tag}";
            var cmd = new SqlCommand(sqlq, db.GetConnection());
            cmd.ExecuteNonQuery();
            db.CloseConnection();
            treeView.SelectedNode.Remove();
        }

        private void удалитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            InteractionWithDB db = new InteractionWithDB();
            db.OpenConnection();
            var sqlq = $"DELETE FROM Device WHERE Device_id = {treeView.SelectedNode.Tag}";
            var cmd = new SqlCommand(sqlq, db.GetConnection());
            cmd.ExecuteNonQuery();
            db.CloseConnection();
            treeView.SelectedNode.Remove();
        }

        private void добавитьФакультетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddJob frm = new AddJob();
            frm.ShowDialog();
            обновитьДеревоToolStripMenuItem_Click(sender, e);
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEmployee frm = new AddEmployee(treeView.SelectedNode.Tag.ToString());
            frm.ShowDialog();
            UpdateNode();
        }

        private void добавитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddDevice frm = new AddDevice(treeView.SelectedNode.Tag.ToString());
            frm.ShowDialog();
            UpdateNode();
        }

        void UpdateNode()
        {
            treeView.SelectedNode.Nodes.Clear();
            if (treeView.SelectedNode.ContextMenuStrip == contextMenuStripNodeJob)
            {
                LoadEmployeWithFather(treeView.SelectedNode, treeView.SelectedNode.Tag.ToString());
            }
            else
                LoadDevice(treeView.SelectedNode, treeView.SelectedNode.Tag.ToString());
        }

        private void contextMenuStripNodeFaculty_Opening(object sender, CancelEventArgs e)
        {
            if (treeView.SelectedNode != null)
            {
                if (treeView.SelectedNode.ContextMenuStrip != contextMenuStripNodeJob)
                {
                    удалитьToolStripMenuItem.Enabled = false;
                    изменитьToolStripMenuItem.Enabled = false;
                    добавитьToolStripMenuItem.Enabled = false;
                }
                else
                {
                    удалитьToolStripMenuItem.Enabled = true;
                    изменитьToolStripMenuItem.Enabled = true;
                    добавитьToolStripMenuItem.Enabled = true;
                }
            }
            else
            {
                удалитьToolStripMenuItem.Enabled = false;
                изменитьToolStripMenuItem.Enabled = false;
                добавитьToolStripMenuItem.Enabled = false;
            }
        }

        private void contextMenuStripNodeCourse_Opening(object sender, CancelEventArgs e)
        {
            if (treeView.SelectedNode != null)
            {
                if (treeView.SelectedNode.ContextMenuStrip != contextMenuStripNodeEmployee)
                {
                    удалитьToolStripMenuItem2.Enabled = false;
                    изменитьToolStripMenuItem2.Enabled = false;
                    добавитьToolStripMenuItem1.Enabled = false;
                }
                else
                {
                    удалитьToolStripMenuItem2.Enabled = true;
                    изменитьToolStripMenuItem2.Enabled = true;
                    добавитьToolStripMenuItem1.Enabled = true;
                }
            }
            else
            {
                удалитьToolStripMenuItem2.Enabled = false;
                изменитьToolStripMenuItem2.Enabled = false;
                добавитьToolStripMenuItem1.Enabled = false;
            }
        }

        private void contextMenuStripNodeGroup_Opening(object sender, CancelEventArgs e)
        {
            if (treeView.SelectedNode != null)
            {
                if (treeView.SelectedNode.ContextMenuStrip != contextMenuStripNodeDevice)
                {
                    удалитьToolStripMenuItem1.Enabled = false;
                    изменитьToolStripMenuItem1.Enabled = false;
                    добавитьКартриджToolStripMenuItem.Enabled = false;
                    просмотретьКартриджиToolStripMenuItem.Enabled = false;
                }
                else
                {
                    удалитьToolStripMenuItem1.Enabled = true;
                    изменитьToolStripMenuItem1.Enabled = true;
                    добавитьКартриджToolStripMenuItem.Enabled = true;
                    просмотретьКартриджиToolStripMenuItem.Enabled = true;
                }
            }
            else
            {
                удалитьToolStripMenuItem1.Enabled = false;
                изменитьToolStripMenuItem1.Enabled = false;
                добавитьКартриджToolStripMenuItem.Enabled = false;
                просмотретьКартриджиToolStripMenuItem.Enabled = false;
            }
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateJob frm = new UpdateJob(treeView.SelectedNode.Tag.ToString(), treeView.SelectedNode.ToString());
            frm.ShowDialog();
            обновитьДеревоToolStripMenuItem_Click(sender, e);
        }

        private void изменитьToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            UpdateEmployee frm = new UpdateEmployee(treeView.SelectedNode.Tag.ToString(),treeView.SelectedNode.Parent.Tag.ToString(), treeView.SelectedNode.ToString());
            frm.ShowDialog();
            обновитьДеревоToolStripMenuItem_Click(sender, e);
        }

        private void изменитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UpdateDevice frm = new UpdateDevice(treeView.SelectedNode.Tag.ToString(), treeView.SelectedNode.Parent.Tag.ToString(), treeView.SelectedNode.ToString());
            frm.ShowDialog();
            обновитьДеревоToolStripMenuItem_Click(sender, e);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void добавитьКартриджToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InteractionWithDB db = new InteractionWithDB();
            string idDev = treeView.SelectedNode.Tag.ToString(), status = "Активен";
            int idCar = 1;
            db.OpenConnection();
            var sqlMax = @"SELECT MAX(Individual_cartridge_code) as Последний FROM Cartridge";
            var cmd = new SqlCommand(sqlMax, db.GetConnection());
            using (var dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    if (dr.IsDBNull(0) == true)
                    {
                        idCar = 1;
                    }
                    else
                    {
                        idCar = int.Parse(dr["Последний"].ToString()) + 1;
                    }
                }
            }
            var sqlq = $@"INSERT INTO Cartridge (Individual_cartridge_code, Cartridge_status, The_code_of_the_device) VALUES (@idCar, @status, @idDev)";
            cmd = new SqlCommand(sqlq, db.GetConnection());
            cmd.Parameters.AddWithValue("@idCar", idCar);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@idDev", idDev);
            cmd.ExecuteNonQuery();
            db.CloseConnection();
            обновитьДеревоToolStripMenuItem_Click(sender, e);
        }

        private void просмотретьКартриджиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InteractionWithDB db = new InteractionWithDB();
            db.OpenConnection();
            var sqlCheck = $@"SELECT MAX(Individual_cartridge_code) as Проверка FROM Cartridge where The_code_of_the_device = {int.Parse(treeView.SelectedNode.Tag.ToString())}";
            var cmd = new SqlCommand(sqlCheck, db.GetConnection());
            using (var dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    if (dr.IsDBNull(0) == true)
                    {
                        MessageBox.Show("У данного устройства нет картриджей");
                        return;
                    }
                    else
                    {
                        UpdateCartridge frm = new UpdateCartridge(treeView.SelectedNode.Tag.ToString());
                        frm.ShowDialog();
                        обновитьДеревоToolStripMenuItem_Click(sender, e);
                    }
                }
            }
            db.CloseConnection();
        }
    }
}
