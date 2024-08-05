using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_System
{
    public partial class Docter : Form
    {
        public Docter()
        {
            InitializeComponent();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Docter_Load(object sender, EventArgs e)
        {
            lbldname.Text = MainClass.userName;
            DateTime nd = DateTime.Now;
            lblDate.Text = nd.ToString("yyyy , MM , dd");

            loadProductsFromDatabase();
        }
        private void loadProductsFromDatabase()
        {
            string qry = "Select * from hchannel where status = 'Pending' and cdate = '" + txtdate.Text + "' and docname = '" + lbldname.Text + "' ";
            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    AddItems("0", row["id"].ToString(), row["cname"].ToString(), row["ctel"].ToString(), row["cmail"].ToString(), row["docname"].ToString(), row["cdate"].ToString(), row["status"].ToString());
                    //AddItems("0", row["vahicalno"].ToString(), Image.FromStream(new MemoryStream(imageArray)), row["brand"].ToString(), row["name"].ToString(), row["type"].ToString(), row["price"].ToString());
                }
            }
        }
       /* public void AddItems(string id, String vehicalno, Image pic, string Brand, string name, string type, string price)
        {
            var w = new channel()
            {
                CName = name,
                Cno = vehicalno,
                CPrice = price,
                CBrand = Brand,
                CImage = pic,
                CType = type,
                id = Convert.ToInt32(id),

            };
            flowLayoutPanel1.Controls.Add(w);


            w.onSelect += (ss, ee) =>
            {
                var wdg = (channel)ss;
                //MessageBox.Show(wdg.id.ToString()+ wdg.CName + wdg.Cno);
                //MainClass.nm = wdg.CName;
                RentAdd rd = new RentAdd();
                rd.lblName.Text = wdg.CName;
                rd.lblPrice.Text = wdg.CPrice;
                rd.lblType.Text = wdg.CType;
                rd.lblveno.Text = wdg.Cno;
                rd.lblBrand.Text = wdg.CBrand;
                rd.txtImg.Image = wdg.CImage;
                MainClass.BlurBackground(rd);

            };
        }*/
        public void AddItems(string iid, string id, string cname, string ctel, string cmail, string docname, string cdate, string status)
        {
            var w = new channel()
            {
                Cname = cname,
                Ctel = ctel,
                Cmail = cmail,
                Docname = docname,
                Cdate = cdate,
                Status = status,
                id = Convert.ToInt32(id),

            };
            flowLayoutPanel1.Controls.Add(w);


            w.onSelect += (ss, ee) =>
            {
                var wdg = (channel)ss;
                //MessageBox.Show("Add");

                //MessageBox.Show(wdg.id.ToString()+ wdg.CName + wdg.Cno);
                //MainClass.nm = wdg.CName;
                Prescription rd = new Prescription();
                rd.lblcname.Text = wdg.Cname;
                rd.lbltel.Text = wdg.Ctel;
                rd.lblemail.Text = wdg.Cmail;
                rd.lbldname.Text = wdg.Docname;
                
                
                MainClass.BlurBackground(rd);


            };
        }
        /*private void GetOrders()
        {
            flowLayoutPanel1.Controls.Clear();
            string qry1 = "Select * from hchannel where status = 'Pending' and cdate = '"+lblDate.Text+"' and docname = '"+lbldname.Text+"' ";
            SqlCommand cmd1 = new SqlCommand(qry1, MainClass.con);
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            da.Fill(dt1);

            FlowLayoutPanel p1;

            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                //string x = Convert.ToString(dt1.Rows.Count);
                //MessageBox.Show(x);
                p1 = new FlowLayoutPanel();
                p1.AutoSize = true;
                p1.Width = 230;
                p1.Height = 350;
                p1.FlowDirection = FlowDirection.TopDown;
                p1.BorderStyle = BorderStyle.FixedSingle;
                p1.Margin = new Padding(10, 10, 10, 10);

                FlowLayoutPanel p2 = new FlowLayoutPanel();
                p2 = new FlowLayoutPanel();
                p2.BackColor = Color.FromArgb(50, 55, 89);
                p2.AutoSize = true;
                p2.Width = 230;
                p2.Height = 125;
                p2.FlowDirection = FlowDirection.TopDown;
                p2.Margin = new Padding(0, 0, 0, 0);

                Label lb1 = new Label();
                lb1.ForeColor = Color.White;
                lb1.Margin = new Padding(10, 10, 3, 0);
                lb1.AutoSize = true;

                Label lb2 = new Label();
                lb2.ForeColor = Color.White;
                lb2.Margin = new Padding(10, 5, 3, 0);
                lb2.AutoSize = true;

                /*Label lb3 = new Label();
                lb3.ForeColor = Color.White;
                lb3.Margin = new Padding(10, 5, 3, 0);
                lb3.AutoSize = true;

                Label lb4 = new Label();
                lb4.ForeColor = Color.White;
                lb4.Margin = new Padding(10, 5, 3, 0);
                lb4.AutoSize = true;*//*

                lb1.Text = "Client Name : " + dt1.Rows[i]["cname"].ToString();
                lb2.Text = "Channel Date : " + dt1.Rows[i]["cdate"].ToString();
                //lb3.Text = "Table : " + dt1.Rows[i].ToString();
                //lb4.Text = "Table : " + dt1.Rows[i].ToString();

                p2.Controls.Add(lb1);
                p2.Controls.Add(lb2);
                p1.Controls.Add(p2);

                Label lb5 = new Label();
                lb5.ForeColor = Color.Black;
                lb5.Margin = new Padding(10, 10, 3, 0);
                lb5.AutoSize = true;

                Label lb6 = new Label();
                lb6.ForeColor = Color.Black;
                lb6.Margin = new Padding(10, 10, 3, 0);
                lb6.AutoSize = true;


                lb5.Text = "Client Tel : " + dt1.Rows[i]["ctel"].ToString();
                lb6.Text = "Client mail : " + dt1.Rows[i]["cmail"].ToString();

                p1.Controls.Add(lb5);
                p1.Controls.Add(lb6);

                Guna.UI2.WinForms.Guna2Button b = new Guna.UI2.WinForms.Guna2Button();
                b.AutoRoundedCorners = true;
                b.Size = new Size(100, 35);
                b.FillColor = Color.FromArgb(241, 85, 126);
                b.Margin = new Padding(30, 5, 3, 10);
                b.Text = "Complete Checking";
                b.Tag = dt1.Rows[i]["saleID"].ToString();

                b.Click += new EventHandler(b_click);
                p1.Controls.Add(b);


                flowLayoutPanel1.Controls.Add(p1);

            }
        }
        private void b_click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32((sender as Guna.UI2.WinForms.Guna2Button).Tag.ToString());

            guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question;
            guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;

            if (guna2MessageDialog1.Show("Are you sure you want to complete order?") == DialogResult.Yes)
            {
                string qry3 = "Update hchannel set status = 'Complete Docter' where id = @ID";
                Hashtable ht = new Hashtable();
                ht.Add("@ID", id);

                string qry4 = "Select * from hchannel where id = '"+id+"' ";
                SqlCommand cmd4 = new SqlCommand(qry4, MainClass.con);
                DataTable dt4 = new DataTable();
                SqlDataAdapter da4 = new SqlDataAdapter(cmd4);
                da4.Fill(dt4);

                Prescription pt = new Prescription();
                pt.lblcname.Text = dt4.Rows[1].ToString();
                pt.lbldname.Text = dt4.Rows[4].ToString();
                pt.lblemail.Text = dt4.Rows[3].ToString();
                pt.lbltel.Text = dt4.Rows[2].ToString();
                 


                if (MainClass.SQl(qry3, ht) > 0)
                {
                    guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                    guna2MessageDialog1.Show("Complete Check Successfull");
                }
                pt.Show();
                GetOrders();
            }
        }*/
    }
}
