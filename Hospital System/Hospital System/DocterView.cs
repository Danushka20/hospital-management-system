using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_System
{
    public partial class DocterView : Form
    {
        public DocterView()
        {
            InitializeComponent();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void DocterView_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            DocterAdd da = new DocterAdd();
            da.Show();
            
        }
        public void GetData()
        {
            string qry = "Select * From docinserts where name like '%" + txtSearch.Text + "%'    ";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvName);
            lb.Items.Add(dgvspecial);
            lb.Items.Add(dgvtel);
            lb.Items.Add(dgvemail);
            lb.Items.Add(dgvuname);
            lb.Items.Add(dgvpassword);

            MainClass.LoadData(qry, guna2DataGridView1, lb);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            GetData();
        }
    }
}
