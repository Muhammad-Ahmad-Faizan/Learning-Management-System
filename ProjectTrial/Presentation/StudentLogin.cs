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
using ProjectTrial.BusinessLayer;
using ProjectTrial.DataLayer;

namespace ProjectTrial.Presentation
{
    public partial class StudentLogin : MaterialForm
    {
        private readonly MaterialSkinManager skinManager;
        public static string studentRegNum { get; set; }
        public static string studentPassword { get; set; }
        public StudentLogin()
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

        private void button2_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void StudentLogin_Load(object sender, EventArgs e)
        {

        }

        private void lblReset1_Click(object sender, EventArgs e)
        {
            txtStdRegNum.Clear();
            txtStdpsword.Clear();
        }

        private void btnstdLogin_Click(object sender, EventArgs e)
        {
            studentRegNum = txtStdRegNum.Text.ToString();
            studentPassword = txtStdpsword.Text.ToString();
           

            SqlDataReader myReader = Connection.StudentPortal(studentRegNum, studentPassword);
           
            if (myReader != null && myReader.HasRows && myReader.Read())
            {
              
                
                StudentPortal student = new StudentPortal();
                student.Show();

                this.Hide();
            }
            else
                {
                    MessageBox.Show("Invalid credentials. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

        }
    }
}
