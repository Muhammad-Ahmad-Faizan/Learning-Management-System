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
using MaterialSkin;
using MaterialSkin.Controls;
using ProjectTrial.DataLayer;
using ProjectTrial.Presentation;
namespace ProjectTrial
{
    public partial class AdminLogin : MaterialForm
    {
        private readonly MaterialSkinManager skinManager;
        public AdminLogin()
        {
            InitializeComponent();
            skinManager = MaterialSkinManager.Instance;
            skinManager.EnforceBackcolorOnAllComponents = false;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            //skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.BlueGrey700, MaterialSkin.Primary.BlueGrey800, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Accent.Blue100, MaterialSkin.TextShade.BLACK);
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(
     MaterialSkin.Primary.Grey900,     // Header and side panel color
     MaterialSkin.Primary.Grey800,     // Header and side panel color (dark shade)
     MaterialSkin.Primary.Grey700,     // Header and side panel color (light shade)
     MaterialSkin.Accent.Orange400,      // Accent color (you can adjust this as needed)
     MaterialSkin.TextShade.WHITE      // Text color (white)
        );
        }

        private void btnBack1_Click(object sender, EventArgs e)
        {

            Home h = new Home();
            h.Show();
            this.Hide();

        }

        private void txtUserName1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {

        }

        private void lblReset1_Click(object sender, EventArgs e)
        {
            txtpaswrdAdmin.Clear();
            txtUserNameadmin.Clear();
        }

        private void btnAdminBack_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
           SqlDataReader myReader = Connection.AdminPortal(txtUserNameadmin.Text, txtpaswrdAdmin.Text);

            if (myReader != null && myReader.HasRows && myReader.Read())
            {


                AdminPortal admin = new AdminPortal();
                admin.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid credentials. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
