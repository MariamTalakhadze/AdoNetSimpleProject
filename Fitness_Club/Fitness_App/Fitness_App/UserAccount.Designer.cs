namespace Fitness_App
{
    partial class UserAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserAccount));
            this.top = new System.Windows.Forms.Panel();
            this.logout = new System.Windows.Forms.Label();
            this.settings = new System.Windows.Forms.Label();
            this.packages = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lastnamelbl = new System.Windows.Forms.Label();
            this.namelbl = new System.Windows.Forms.Label();
            this.pic = new System.Windows.Forms.Panel();
            this.left = new System.Windows.Forms.Panel();
            this.rightTop = new System.Windows.Forms.Panel();
            this.rightBottom = new System.Windows.Forms.Panel();
            this.top.SuspendLayout();
            this.SuspendLayout();
            // 
            // top
            // 
            this.top.BackColor = System.Drawing.Color.Black;
            this.top.Controls.Add(this.logout);
            this.top.Controls.Add(this.settings);
            this.top.Controls.Add(this.packages);
            this.top.Controls.Add(this.panel2);
            this.top.Controls.Add(this.panel1);
            this.top.Controls.Add(this.lastnamelbl);
            this.top.Controls.Add(this.namelbl);
            this.top.Controls.Add(this.pic);
            this.top.Location = new System.Drawing.Point(12, 12);
            this.top.Name = "top";
            this.top.Size = new System.Drawing.Size(1060, 116);
            this.top.TabIndex = 0;
            this.top.Paint += new System.Windows.Forms.PaintEventHandler(this.top_Paint);
            // 
            // logout
            // 
            this.logout.AutoSize = true;
            this.logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.Color.Maroon;
            this.logout.Location = new System.Drawing.Point(875, 79);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(91, 25);
            this.logout.TabIndex = 6;
            this.logout.Text = "Log out";
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // settings
            // 
            this.settings.AutoSize = true;
            this.settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settings.ForeColor = System.Drawing.Color.White;
            this.settings.Location = new System.Drawing.Point(872, 46);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(98, 25);
            this.settings.TabIndex = 5;
            this.settings.Text = "Settings";
            this.settings.Click += new System.EventHandler(this.settings_Click);
            // 
            // packages
            // 
            this.packages.AutoSize = true;
            this.packages.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.packages.ForeColor = System.Drawing.Color.White;
            this.packages.Location = new System.Drawing.Point(872, 12);
            this.packages.Name = "packages";
            this.packages.Size = new System.Drawing.Size(115, 25);
            this.packages.TabIndex = 0;
            this.packages.Text = "Packages";
            this.packages.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(790, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 100);
            this.panel2.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(277, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 100);
            this.panel1.TabIndex = 3;
            // 
            // lastnamelbl
            // 
            this.lastnamelbl.AutoSize = true;
            this.lastnamelbl.BackColor = System.Drawing.Color.Transparent;
            this.lastnamelbl.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastnamelbl.ForeColor = System.Drawing.Color.White;
            this.lastnamelbl.Location = new System.Drawing.Point(114, 71);
            this.lastnamelbl.Name = "lastnamelbl";
            this.lastnamelbl.Size = new System.Drawing.Size(117, 33);
            this.lastnamelbl.TabIndex = 2;
            this.lastnamelbl.Text = "Lastname";
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.BackColor = System.Drawing.Color.Transparent;
            this.namelbl.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelbl.ForeColor = System.Drawing.Color.White;
            this.namelbl.Location = new System.Drawing.Point(114, 41);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(75, 33);
            this.namelbl.TabIndex = 1;
            this.namelbl.Text = "Name";
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.Color.White;
            this.pic.Location = new System.Drawing.Point(17, 12);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(91, 92);
            this.pic.TabIndex = 0;
            // 
            // left
            // 
            this.left.BackColor = System.Drawing.Color.Black;
            this.left.Location = new System.Drawing.Point(12, 166);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(518, 503);
            this.left.TabIndex = 1;
            this.left.Paint += new System.Windows.Forms.PaintEventHandler(this.left_Paint);
            // 
            // rightTop
            // 
            this.rightTop.BackColor = System.Drawing.Color.Black;
            this.rightTop.Location = new System.Drawing.Point(576, 166);
            this.rightTop.Name = "rightTop";
            this.rightTop.Size = new System.Drawing.Size(496, 233);
            this.rightTop.TabIndex = 2;
            this.rightTop.Paint += new System.Windows.Forms.PaintEventHandler(this.rightTop_Paint);
            // 
            // rightBottom
            // 
            this.rightBottom.BackColor = System.Drawing.Color.Black;
            this.rightBottom.Location = new System.Drawing.Point(576, 436);
            this.rightBottom.Name = "rightBottom";
            this.rightBottom.Size = new System.Drawing.Size(496, 233);
            this.rightBottom.TabIndex = 3;
            this.rightBottom.Paint += new System.Windows.Forms.PaintEventHandler(this.rightBottom_Paint_1);
            // 
            // UserAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1084, 681);
            this.Controls.Add(this.rightBottom);
            this.Controls.Add(this.rightTop);
            this.Controls.Add(this.left);
            this.Controls.Add(this.top);
            this.Name = "UserAccount";
            this.Text = "UserAccount";
            this.top.ResumeLayout(false);
            this.top.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel top;
        private System.Windows.Forms.Panel left;
        private System.Windows.Forms.Panel rightTop;
        private System.Windows.Forms.Panel rightBottom;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label packages;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lastnamelbl;
        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.Panel pic;
        private System.Windows.Forms.Label logout;
        private System.Windows.Forms.Label settings;
    }
}