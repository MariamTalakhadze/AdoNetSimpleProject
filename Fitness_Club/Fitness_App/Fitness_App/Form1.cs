using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;

namespace Fitness_App
{
    public partial class Form1 : Form
    {
        public Form1()
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(Username.Text == "Personal Number"){
                Username.Text = " ";
                Username.ForeColor = System.Drawing.SystemColors.InfoText;
            }

        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            password.PasswordChar = '*';
            this.ActiveControl = panel1;
            password.GotFocus += new EventHandler(this.PasswordTextGotChange);
            password.LostFocus += new EventHandler(this.PasswordTextLostChange);


        }
        public void PasswordTextGotChange(object sender, EventArgs e)
        {
            TextBox tx = (TextBox)sender;
            if (tx.Text == "PassWord")
            {
                tx.Text = "";
            }
        }
        public void PasswordTextLostChange(object sender, EventArgs e)
        {
            TextBox tx = (TextBox)sender;
            if (tx.Text == "")
            {
                tx.Text = "Password";
            }
        }

        public static object Password { get; private set; }

        private void login_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(@"Data Source=POSEIDON\SQLEXPRESS;Initial Catalog=Fitness_Club;Integrated Security=True");
                SqlDataAdapter da = new SqlDataAdapter("select *  from UserInformation where PersonalNumber='" + Username.Text + "' and Password= '" + password.Text + "'", connection);
                DataTable data = new DataTable();
                da.Fill(data);
                if (data.Rows.Count == 1) { 

                    String firstName = data.Rows[0].Field<String>("Name");
                    UserAccount.User_Name = firstName;

                    String lastName = data.Rows[0].Field<String>("LastName");
                    UserAccount.USer_Lastname = lastName;

                    String PN = data.Rows[0].Field<Int64>("PersonalNumber").ToString();
                    settings.personalNumber = PN;

                    this.Hide();
                    UserAccount ua = new UserAccount();
                    ua.Show();
                }   
                
                else
                {
                    MessageBox.Show("Please enter correct personal number and password ", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Exception Found Try Again ", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private string _user;
        public string user
        { get { return this._user; } set { this._user = Username.Text; } }

        private void Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void register_Click(object sender, EventArgs e)
        {
            this.Hide();
            registrationForm regform = new registrationForm();
            regform.Show();
        }
    }
}
