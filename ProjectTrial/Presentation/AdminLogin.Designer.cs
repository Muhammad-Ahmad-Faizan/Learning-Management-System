
namespace ProjectTrial
{
    partial class AdminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLogin));
            this.btnBack1 = new System.Windows.Forms.Button();
            this.lblHeading1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtUserNameadmin = new System.Windows.Forms.TextBox();
            this.lblUserName1 = new System.Windows.Forms.Label();
            this.lblPassword1 = new System.Windows.Forms.Label();
            this.txtpaswrdAdmin = new System.Windows.Forms.TextBox();
            this.btnAdminLogin = new System.Windows.Forms.Button();
            this.lblReset1 = new System.Windows.Forms.Label();
            this.lblmngstd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdminBack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBackToHome = new System.Windows.Forms.Button();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse2 = new Guna.UI.WinForms.GunaElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack1
            // 
            this.btnBack1.Location = new System.Drawing.Point(17, 590);
            this.btnBack1.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack1.Name = "btnBack1";
            this.btnBack1.Size = new System.Drawing.Size(100, 34);
            this.btnBack1.TabIndex = 0;
            this.btnBack1.Text = "Back";
            this.btnBack1.UseVisualStyleBackColor = true;
            this.btnBack1.Click += new System.EventHandler(this.btnBack1_Click);
            // 
            // lblHeading1
            // 
            this.lblHeading1.AutoSize = true;
            this.lblHeading1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading1.ForeColor = System.Drawing.Color.Orange;
            this.lblHeading1.Location = new System.Drawing.Point(466, 83);
            this.lblHeading1.Name = "lblHeading1";
            this.lblHeading1.Size = new System.Drawing.Size(69, 26);
            this.lblHeading1.TabIndex = 3;
            this.lblHeading1.Text = "Admin";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(435, 112);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(134, 137);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // txtUserNameadmin
            // 
            this.txtUserNameadmin.Location = new System.Drawing.Point(371, 294);
            this.txtUserNameadmin.Name = "txtUserNameadmin";
            this.txtUserNameadmin.Size = new System.Drawing.Size(253, 27);
            this.txtUserNameadmin.TabIndex = 5;
            this.txtUserNameadmin.TextChanged += new System.EventHandler(this.txtUserName1_TextChanged);
            // 
            // lblUserName1
            // 
            this.lblUserName1.AutoSize = true;
            this.lblUserName1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName1.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblUserName1.Location = new System.Drawing.Point(367, 272);
            this.lblUserName1.Name = "lblUserName1";
            this.lblUserName1.Size = new System.Drawing.Size(83, 19);
            this.lblUserName1.TabIndex = 6;
            this.lblUserName1.Text = "User Name";
            // 
            // lblPassword1
            // 
            this.lblPassword1.AutoSize = true;
            this.lblPassword1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword1.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblPassword1.Location = new System.Drawing.Point(367, 340);
            this.lblPassword1.Name = "lblPassword1";
            this.lblPassword1.Size = new System.Drawing.Size(74, 19);
            this.lblPassword1.TabIndex = 8;
            this.lblPassword1.Text = "Password";
            // 
            // txtpaswrdAdmin
            // 
            this.txtpaswrdAdmin.Location = new System.Drawing.Point(371, 362);
            this.txtpaswrdAdmin.Name = "txtpaswrdAdmin";
            this.txtpaswrdAdmin.PasswordChar = '*';
            this.txtpaswrdAdmin.Size = new System.Drawing.Size(253, 27);
            this.txtpaswrdAdmin.TabIndex = 7;
            // 
            // btnAdminLogin
            // 
            this.btnAdminLogin.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAdminLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdminLogin.FlatAppearance.BorderSize = 0;
            this.btnAdminLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminLogin.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminLogin.ForeColor = System.Drawing.Color.White;
            this.btnAdminLogin.Location = new System.Drawing.Point(435, 422);
            this.btnAdminLogin.Name = "btnAdminLogin";
            this.btnAdminLogin.Size = new System.Drawing.Size(134, 35);
            this.btnAdminLogin.TabIndex = 9;
            this.btnAdminLogin.Text = "Login";
            this.btnAdminLogin.UseVisualStyleBackColor = false;
            this.btnAdminLogin.Click += new System.EventHandler(this.btnAdminLogin_Click);
            // 
            // lblReset1
            // 
            this.lblReset1.AutoSize = true;
            this.lblReset1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblReset1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReset1.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblReset1.Location = new System.Drawing.Point(478, 460);
            this.lblReset1.Name = "lblReset1";
            this.lblReset1.Size = new System.Drawing.Size(46, 19);
            this.lblReset1.TabIndex = 10;
            this.lblReset1.Text = "Reset";
            this.lblReset1.Click += new System.EventHandler(this.lblReset1_Click);
            // 
            // lblmngstd
            // 
            this.lblmngstd.AutoSize = true;
            this.lblmngstd.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.lblmngstd.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblmngstd.Location = new System.Drawing.Point(51, 208);
            this.lblmngstd.Name = "lblmngstd";
            this.lblmngstd.Size = new System.Drawing.Size(190, 23);
            this.lblmngstd.TabIndex = 11;
            this.lblmngstd.Text = "Manage Students Data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(51, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Manage Teachers Data";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCyan;
            this.panel1.Controls.Add(this.btnAdminBack);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnBackToHome);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblmngstd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 484);
            this.panel1.TabIndex = 1;
            // 
            // btnAdminBack
            // 
            this.btnAdminBack.BackColor = System.Drawing.Color.Black;
            this.btnAdminBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdminBack.FlatAppearance.BorderSize = 0;
            this.btnAdminBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminBack.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminBack.ForeColor = System.Drawing.Color.White;
            this.btnAdminBack.Location = new System.Drawing.Point(12, 434);
            this.btnAdminBack.Name = "btnAdminBack";
            this.btnAdminBack.Size = new System.Drawing.Size(134, 35);
            this.btnAdminBack.TabIndex = 11;
            this.btnAdminBack.Text = "Back";
            this.btnAdminBack.UseVisualStyleBackColor = false;
            this.btnAdminBack.Click += new System.EventHandler(this.btnAdminBack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(72, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // btnBackToHome
            // 
            this.btnBackToHome.BackColor = System.Drawing.Color.White;
            this.btnBackToHome.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnBackToHome.FlatAppearance.BorderSize = 2;
            this.btnBackToHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToHome.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToHome.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnBackToHome.Location = new System.Drawing.Point(12, 484);
            this.btnBackToHome.Name = "btnBackToHome";
            this.btnBackToHome.Size = new System.Drawing.Size(134, 35);
            this.btnBackToHome.TabIndex = 12;
            this.btnBackToHome.Text = "Back To Home";
            this.btnBackToHome.UseVisualStyleBackColor = false;
            this.btnBackToHome.Click += new System.EventHandler(this.button2_Click);
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 9;
            this.gunaElipse1.TargetControl = this.btnAdminLogin;
            // 
            // gunaElipse2
            // 
            this.gunaElipse2.Radius = 9;
            this.gunaElipse2.TargetControl = this.btnAdminBack;
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(755, 551);
            this.Controls.Add(this.lblReset1);
            this.Controls.Add(this.btnAdminLogin);
            this.Controls.Add(this.lblPassword1);
            this.Controls.Add(this.txtpaswrdAdmin);
            this.Controls.Add(this.lblUserName1);
            this.Controls.Add(this.txtUserNameadmin);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblHeading1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBack1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "AdminLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Login";
            this.Load += new System.EventHandler(this.AdminLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack1;
        private System.Windows.Forms.Label lblHeading1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtUserNameadmin;
        private System.Windows.Forms.Label lblUserName1;
        private System.Windows.Forms.Label lblPassword1;
        private System.Windows.Forms.TextBox txtpaswrdAdmin;
        private System.Windows.Forms.Button btnAdminLogin;
        private System.Windows.Forms.Label lblReset1;
        private System.Windows.Forms.Label lblmngstd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBackToHome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.Button btnAdminBack;
        private Guna.UI.WinForms.GunaElipse gunaElipse2;
    }
}