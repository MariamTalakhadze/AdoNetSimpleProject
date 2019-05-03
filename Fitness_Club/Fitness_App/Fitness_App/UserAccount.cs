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

namespace Fitness_App
{
    

    public partial class UserAccount : Form
    {
        public static String User_Name;
        public static String USer_Lastname;

        public UserAccount()
        {
            InitializeComponent();
            namelbl.Text = User_Name;
            lastnamelbl.Text = USer_Lastname;
        }

        private void top_Paint(object sender, PaintEventArgs e)
        {
            PaintTransparentBackground(top, e);
            using (Brush b = new SolidBrush(Color.FromArgb(128, top.BackColor)))
            {
                e.Graphics.FillRectangle(b, e.ClipRectangle);
            }
        }
        private static void PaintTransparentBackground(Control c, PaintEventArgs e)
        {
            if (c.Parent == null || !Application.RenderWithVisualStyles)
                return;

            ButtonRenderer.DrawParentBackground(e.Graphics, c.ClientRectangle, c);
        }

        private void left_Paint(object sender, PaintEventArgs e)
        {
            PaintTransparentBackground(left, e);
            using (Brush b = new SolidBrush(Color.FromArgb(128, left.BackColor)))
            {
                e.Graphics.FillRectangle(b, e.ClipRectangle);
            }

        }

        private void rightTop_Paint(object sender, PaintEventArgs e)
        {
            PaintTransparentBackground(rightTop, e);
            using (Brush b = new SolidBrush(Color.FromArgb(128, rightTop.BackColor)))
            {
                e.Graphics.FillRectangle(b, e.ClipRectangle);
            }
        }

        private void rightBottom_Paint_1(object sender, PaintEventArgs e)
        {
            PaintTransparentBackground(rightBottom, e);
            using (Brush b = new SolidBrush(Color.FromArgb(128, rightBottom.BackColor)))
            {
                e.Graphics.FillRectangle(b, e.ClipRectangle);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Packages pac = new Packages();
            pac.Show();
        }
        Form1 form = new Form1();
        

        private void settings_Click(object sender, EventArgs e)
        {
            settings st = new settings();
            st.Show();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

    }
}
