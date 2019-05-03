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
    public partial class registrationForm : Form
    {
        public registrationForm()
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
        int sqlResult;

        private void register_Click(object sender, EventArgs e)
        {
            bool res = false;
            using (SqlConnection connection = new SqlConnection(@"Data Source=POSEIDON\SQLEXPRESS;Initial Catalog=Fitness_Club;Integrated Security=True"))
            {
                String query = "INSERT INTO dbo.UserInformation(Name,LastName,PhoneNumber,PersonalNumber, Password) VALUES (@Name,@LastName,@PhoneNumber, @PersonalNumber, @Password)";
                using (SqlCommand SqlCommand = new SqlCommand("Select count(*) from dbo.UserInformation Where PersonalNumber = @PersonalNumber", connection))
                {
                    SqlCommand.Parameters.AddWithValue("@PersonalNumber", PersonalNumber.Text);
                    connection.Open();
                    int records = Int32.Parse(SqlCommand.ExecuteScalar().ToString());
                    if(records==0){
                        SqlCommand.Parameters.Clear();
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            if (Password.Text == Password2.Text && Password.Text != "" && Name.Text != "" && LastName.Text != "" && MobileNumber.Text != "" && PersonalNumber.Text != "")
                            {
                                command.Parameters.AddWithValue("@Name", Name.Text);
                                command.Parameters.AddWithValue("@LastName", LastName.Text);
                                command.Parameters.AddWithValue("@PhoneNumber", MobileNumber.Text);
                                command.Parameters.AddWithValue("@PersonalNumber", PersonalNumber.Text);
                                command.Parameters.AddWithValue("@Password", Password.Text);
                                
                                int resu = command.ExecuteNonQuery();
                                if (resu < 0)
                                {
                                    MessageBox.Show("error inserting data");
                                }
                                this.Hide();
                                Form1 f = new Form1();
                                f.Show();
                                MessageBox.Show("inserted Succesfully");
                            }
                            else
                            {
                                MessageBox.Show("try again cant insert  ", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("user exists try again ", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
            
        
                

                   
                
            }

            
        }

        private void PersonalNumber_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void MobileNumber_TextChanged_1(object sender, EventArgs e)
        {
            if (PersonalNumber.Text.Length != 11)
            {
                MessageBox.Show("personal number should have 11 digits", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    
}
