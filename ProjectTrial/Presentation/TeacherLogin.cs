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
    public partial class TeacherLogin : MaterialForm
    {
        public static string teacherloginid { get; set; }
        public static string teacherLoginPassword { get; set; }
        private readonly MaterialSkinManager skinManager;
        public TeacherLogin()
        {
            InitializeComponent();
            skinManager = MaterialSkinManager.Instance;
            skinManager.EnforceBackcolorOnAllComponents = false;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(
                             MaterialSkin.Primary.Grey900,     
                             MaterialSkin.Primary.Grey800,     
                             MaterialSkin.Primary.Grey700,     
                             MaterialSkin.Accent.Orange400,    
                             MaterialSkin.TextShade.WHITE      
        );
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            teacherloginid = txtTeacherID.Text.ToString();
            teacherLoginPassword = txtPasswordtch.Text.ToString();
           

            SqlDataReader myReader = Connection.TeacherPortal(teacherloginid, teacherLoginPassword);
            Teacher t = new Teacher();
            if (myReader != null && myReader.HasRows && myReader.Read())
            {
               

                Teachers_Portal teacher = new Teachers_Portal();
                teacher.Show();

                this.Hide();
            }
            else
                {
                    MessageBox.Show("Invalid credentials. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        private void lblReset1_Click(object sender, EventArgs e)
        {
            txtPasswordtch.Clear();
            txtTeacherID.Clear();
        }
    }
        }


