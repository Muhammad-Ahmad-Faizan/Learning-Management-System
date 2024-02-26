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
    public partial class StudentPortal : MaterialForm
    {
        readonly MaterialSkinManager skinManager;
        public StudentPortal()
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
     MaterialSkin.Accent.Blue700,      // Accent color (you can adjust this as needed)
     MaterialSkin.TextShade.WHITE      // Text color (white)


);
        }
        private string regno = StudentLogin.studentRegNum;
        private string spaswd = StudentLogin.studentPassword;
        private string cid;
   
        private void StudentPortal_Load(object sender, EventArgs e)
        {
            
            DisplayCourses();
            DisplayStudentInfo();
            StudentHeader();
            DisplayAttendance();
        }
        private void DisplayStudentInfo()
        {
            SqlDataReader myReader = Connection.StudentPortal(regno, spaswd);
            Student s = new Student();
            if (myReader != null && myReader.HasRows)
            {
                while (myReader.Read())
                {
                    lblStdName.Text = myReader["Name"].ToString();
                    lblStdCnic.Text = myReader["CNIC"].ToString();
                    lblStdGender.Text = myReader["Gender"].ToString();
                    lblStdBlood.Text = myReader["BloodGroup"].ToString();
                    lblStdReligion.Text = myReader["Religion"].ToString();
                    lblStdPhone.Text = myReader["Phone"].ToString();
                    lblStdPEmail.Text = myReader["Email"].ToString();
                    lblStdAddress.Text = myReader["Address"].ToString();
                    lblStdFName.Text = myReader["FatherName"].ToString();
                    lblFContact.Text = myReader["Contact"].ToString();
                }
            }
        }
        private void StudentHeader()
        {
            SqlDataReader myReader = Connection.StudentHeaderDisplay(regno);
            if (myReader != null && myReader.HasRows)
            {
                while (myReader.Read())
                {
                    lblBatch.Text = myReader["Batch"].ToString();
                    lblDepartment.Text = myReader["Department"].ToString();
                    lblSpecialization.Text = myReader["Specialization"].ToString();
                    lblProgram.Text = "Bachelors";
                }
            }
        }
        private void DisplayCourses()
        {
            grdStd1.DataSource = Connection.CoursesDisplaySP();
        }
       
        private void DisplayAttendance()
        {
            string[] cidValues = { "COC-2070", "COC-2071", "COC-2071L", "COC-2072", "MA-1001", "SES-2072" };  // Example CID values
            Label[] labels = { lblp1, lblp2, lblp3, lblp4, lblp5, lblp6, lblp7, lblp8 };  // Example labels

            for (int i = 0; i < cidValues.Length; i++)
            {
                cid = cidValues[i];
                SqlDataReader myReader = Connection.countAttendance(regno, cid);
                if (myReader.Read())
                {
                    labels[i].Text = myReader["TotalPresent"].ToString();
                }
                myReader.Close();
            }
        }
      
        private void lblTName_Click(object sender, EventArgs e)
        {

        }

        private void btnStudentLogOut_Click(object sender, EventArgs e)
        {
            StudentLogin login = new StudentLogin();
            login.Show();
            this.Hide();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblpre5_Click(object sender, EventArgs e)
        {

        }
    }
}
