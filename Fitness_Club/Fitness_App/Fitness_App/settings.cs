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
    public partial class settings : Form
    {
        public static String personalNumber;

        public settings()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            PaintTransparentBackground(panel1, e);
            using (Brush b = new SolidBrush(Color.FromArgb(128, panel1.BackColor)))
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

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=POSEIDON\SQLEXPRESS;Initial Catalog=Fitness_Club;Integrated Security=True"))
            {
                Form1 form = new Form1();
                String query= "Update dbo.UserInformation SET Password=@Password Where PersonalNumber= ' "+ settings.personalNumber+"'";
                using (SqlCommand SqlCommand = new SqlCommand(query, connection))
                {
                    connection.Open();
                    if (newpas.Text == newpas2.Text && newpas.Text!="")
                    {                       
                        SqlCommand.Parameters.AddWithValue("@Password", newpas.Text);
                        int rows = SqlCommand.ExecuteNonQuery();
                       MessageBox.Show("Updated succesfully ", "alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}
