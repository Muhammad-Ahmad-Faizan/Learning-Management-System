using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectTrial.Presentation;
using MaterialSkin;
using MaterialSkin.Controls;

namespace ProjectTrial
{
    public partial class Home : MaterialForm
    {
        private readonly MaterialSkinManager skinManager;

        public Home()
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

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
          
        }

        private void lblHeadHome_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnLoginasTeacher_Click(object sender, EventArgs e)
        {
           
        }

        private void btnLoginasStudent_Click(object sender, EventArgs e)
        {
           
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void btnLoginAdmin_Click(object sender, EventArgs e)
        {
            AdminLogin a = new AdminLogin();
            a.Show();
            this.Hide();
        }

        private void btnTeacherLogin_Click(object sender, EventArgs e)
        {
            TeacherLogin T = new TeacherLogin();
            T.Show();
            this.Hide();
        }

        private void btnStdLogin_Click(object sender, EventArgs e)
        {
            StudentLogin S = new StudentLogin();
            S.Show();
            this.Hide();
        }
    }
}
