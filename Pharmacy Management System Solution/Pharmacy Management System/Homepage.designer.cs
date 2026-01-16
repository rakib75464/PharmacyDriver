
namespace Pharmacy_Management_System
{
    partial class Homepage
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homepage));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.logOut = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonHealth = new System.Windows.Forms.Button();
            this.buttonMaBcare = new System.Windows.Forms.Button();
            this.buttonBeauty = new System.Windows.Forms.Button();
            this.buttonNatural = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "_0a6e1f44-8398-442b-92a3-e3678ecacc31.jpeg");
            this.imageList1.Images.SetKeyName(1, "13nov_resize.jpg");
            this.imageList1.Images.SetKeyName(2, "about-health-medical-medicine.jpg");
            this.imageList1.Images.SetKeyName(3, "artificial-intelligence-takes-doping-1024x455-950x422.png");
            this.imageList1.Images.SetKeyName(4, "pharmacy_050720.jpg");
            this.imageList1.Images.SetKeyName(5, "1_ZvYLbJzcdtDHk9KECPZUJQ.png");
            this.imageList1.Images.SetKeyName(6, "AdobeStock_274131656.original.original.jpg");
            this.imageList1.Images.SetKeyName(7, "Screenshot 2024-09-21 214116.png");
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(72, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pharmacy Management System";
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.searchBox.Location = new System.Drawing.Point(419, 16);
            this.searchBox.Margin = new System.Windows.Forms.Padding(2);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(300, 27);
            this.searchBox.TabIndex = 2;
            this.searchBox.Text = "Search Here...";
            this.searchBox.Enter += new System.EventHandler(this.searchBox_Enter_1);
            this.searchBox.Leave += new System.EventHandler(this.searchBox_Leave_1);
            // 
            // logOut
            // 
            this.logOut.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOut.Location = new System.Drawing.Point(723, 16);
            this.logOut.Margin = new System.Windows.Forms.Padding(2);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(76, 26);
            this.logOut.TabIndex = 3;
            this.logOut.Text = "Log Out>";
            this.logOut.UseVisualStyleBackColor = true;
            this.logOut.Click += new System.EventHandler(this.logOut_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.logOut);
            this.panel1.Controls.Add(this.searchBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 47);
            this.panel1.TabIndex = 0;
            // 
            // buttonHealth
            // 
            this.buttonHealth.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHealth.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonHealth.Image = ((System.Drawing.Image)(resources.GetObject("buttonHealth.Image")));
            this.buttonHealth.Location = new System.Drawing.Point(460, 379);
            this.buttonHealth.Margin = new System.Windows.Forms.Padding(2);
            this.buttonHealth.Name = "buttonHealth";
            this.buttonHealth.Size = new System.Drawing.Size(338, 107);
            this.buttonHealth.TabIndex = 7;
            this.buttonHealth.Text = "Health Care";
            this.buttonHealth.UseVisualStyleBackColor = true;
            this.buttonHealth.Click += new System.EventHandler(this.buttonHealth_Click);
            // 
            // buttonMaBcare
            // 
            this.buttonMaBcare.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMaBcare.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonMaBcare.Image = ((System.Drawing.Image)(resources.GetObject("buttonMaBcare.Image")));
            this.buttonMaBcare.Location = new System.Drawing.Point(118, 379);
            this.buttonMaBcare.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMaBcare.Name = "buttonMaBcare";
            this.buttonMaBcare.Size = new System.Drawing.Size(338, 107);
            this.buttonMaBcare.TabIndex = 6;
            this.buttonMaBcare.Text = "Mom and Baby Care";
            this.buttonMaBcare.UseVisualStyleBackColor = true;
            this.buttonMaBcare.Click += new System.EventHandler(this.buttonMaBcare_Click);
            // 
            // buttonBeauty
            // 
            this.buttonBeauty.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBeauty.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonBeauty.Image = ((System.Drawing.Image)(resources.GetObject("buttonBeauty.Image")));
            this.buttonBeauty.Location = new System.Drawing.Point(0, 52);
            this.buttonBeauty.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBeauty.Name = "buttonBeauty";
            this.buttonBeauty.Size = new System.Drawing.Size(114, 213);
            this.buttonBeauty.TabIndex = 5;
            this.buttonBeauty.Text = "Beauty\r\nCare";
            this.buttonBeauty.UseVisualStyleBackColor = true;
            this.buttonBeauty.Click += new System.EventHandler(this.buttonBeauty_Click);
            // 
            // buttonNatural
            // 
            this.buttonNatural.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNatural.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonNatural.Image = ((System.Drawing.Image)(resources.GetObject("buttonNatural.Image")));
            this.buttonNatural.Location = new System.Drawing.Point(0, 270);
            this.buttonNatural.Margin = new System.Windows.Forms.Padding(2);
            this.buttonNatural.Name = "buttonNatural";
            this.buttonNatural.Size = new System.Drawing.Size(114, 216);
            this.buttonNatural.TabIndex = 4;
            this.buttonNatural.Text = "Natural \r\nCare";
            this.buttonNatural.UseVisualStyleBackColor = true;
            this.buttonNatural.Click += new System.EventHandler(this.buttonNatural_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(118, 52);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(680, 322);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(801, 488);
            this.Controls.Add(this.buttonHealth);
            this.Controls.Add(this.buttonMaBcare);
            this.Controls.Add(this.buttonBeauty);
            this.Controls.Add(this.buttonNatural);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Homepage";
            this.Text = "Homepage";
            this.Load += new System.EventHandler(this.Homepage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button logOut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonNatural;
        private System.Windows.Forms.Button buttonBeauty;
        private System.Windows.Forms.Button buttonMaBcare;
        private System.Windows.Forms.Button buttonHealth;
    }
}

