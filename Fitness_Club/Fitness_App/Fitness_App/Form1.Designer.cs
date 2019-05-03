namespace Fitness_App
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.password = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.TextBox();
            this.register = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.Username);
            this.panel1.Controls.Add(this.register);
            this.panel1.Controls.Add(this.login);
            this.panel1.Location = new System.Drawing.Point(403, 262);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 200);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.password.Location = new System.Drawing.Point(23, 90);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(254, 30);
            this.password.TabIndex = 5;
            // 
            // Username
            // 
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Username.Location = new System.Drawing.Point(23, 36);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(254, 30);
            this.Username.TabIndex = 4;
            this.Username.TextChanged += new System.EventHandler(this.Username_TextChanged);
            // 
            // register
            // 
            this.register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.register.ForeColor = System.Drawing.Color.Black;
            this.register.Location = new System.Drawing.Point(157, 144);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(120, 40);
            this.register.TabIndex = 3;
            this.register.Text = "Register";
            this.register.UseVisualStyleBackColor = false;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login.Location = new System.Drawing.Point(23, 144);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(120, 40);
            this.login.TabIndex = 2;
            this.login.Text = "Log In";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InfoText;
            this.ClientSize = new System.Drawing.Size(1084, 681);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button register;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox Username;
    }
}

