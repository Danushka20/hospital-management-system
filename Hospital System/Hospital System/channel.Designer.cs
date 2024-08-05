
namespace Hospital_System
{
    partial class channel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblcname = new System.Windows.Forms.Label();
            this.lblcdate = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblcmail = new System.Windows.Forms.Label();
            this.lblctel = new System.Windows.Forms.Label();
            this.guna2ShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.guna2CirclePictureBox1);
            this.guna2ShadowPanel1.Controls.Add(this.lblctel);
            this.guna2ShadowPanel1.Controls.Add(this.lblcmail);
            this.guna2ShadowPanel1.Controls.Add(this.lblcname);
            this.guna2ShadowPanel1.Controls.Add(this.lblcdate);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(17, 18);
            this.guna2ShadowPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(590, 240);
            this.guna2ShadowPanel1.TabIndex = 4;
            this.guna2ShadowPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2ShadowPanel1_Paint);
            // 
            // lblcname
            // 
            this.lblcname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcname.Location = new System.Drawing.Point(270, 8);
            this.lblcname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcname.Name = "lblcname";
            this.lblcname.Size = new System.Drawing.Size(162, 46);
            this.lblcname.TabIndex = 3;
            this.lblcname.Text = "Client Name";
            this.lblcname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblcname.Click += new System.EventHandler(this.lblQty_Click);
            // 
            // lblcdate
            // 
            this.lblcdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcdate.Location = new System.Drawing.Point(270, 66);
            this.lblcdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcdate.Name = "lblcdate";
            this.lblcdate.Size = new System.Drawing.Size(162, 49);
            this.lblcdate.TabIndex = 0;
            this.lblcdate.Text = "Channel Date";
            this.lblcdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblcdate.Click += new System.EventHandler(this.lblPName_Click);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = global::Hospital_System.Properties.Resources.doc;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(3, 3);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(211, 229);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 4;
            this.guna2CirclePictureBox1.TabStop = false;
            this.guna2CirclePictureBox1.Click += new System.EventHandler(this.guna2CirclePictureBox1_Click);
            // 
            // lblcmail
            // 
            this.lblcmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcmail.Location = new System.Drawing.Point(270, 173);
            this.lblcmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcmail.Name = "lblcmail";
            this.lblcmail.Size = new System.Drawing.Size(162, 49);
            this.lblcmail.TabIndex = 0;
            this.lblcmail.Text = "Client email";
            this.lblcmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblcmail.Click += new System.EventHandler(this.lblPName_Click);
            // 
            // lblctel
            // 
            this.lblctel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblctel.Location = new System.Drawing.Point(270, 118);
            this.lblctel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblctel.Name = "lblctel";
            this.lblctel.Size = new System.Drawing.Size(162, 46);
            this.lblctel.TabIndex = 3;
            this.lblctel.Text = "Client Tel";
            this.lblctel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblctel.Click += new System.EventHandler(this.lblctel_Click);
            // 
            // channel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Name = "channel";
            this.Size = new System.Drawing.Size(625, 273);
            this.Load += new System.EventHandler(this.channel_Load);
            this.guna2ShadowPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private System.Windows.Forms.Label lblcname;
        private System.Windows.Forms.Label lblcdate;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Label lblctel;
        private System.Windows.Forms.Label lblcmail;
    }
}
