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

    public partial class Teachers_Portal : MaterialForm
    {
        readonly MaterialSkinManager skinManager;
        public static DataTable attedanceTable { get; set; }
        public Teachers_Portal()
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

) ;
            
        }

        private string tid = TeacherLogin.teacherloginid;
        private string tpaswd = TeacherLogin.teacherLoginPassword;

        private void Teachers_Portal_Load(object sender, EventArgs e)
        {
            
            DisplayTeacherInfo();
            CourseDetail();
           LectureDetail();
        }
        private void DisplayTeacherInfo()
        {
            SqlDataReader myReader = Connection.TeacherPortal(tid, tpaswd);
            Teacher t = new Teacher();
            if (myReader != null && myReader.HasRows)
            {
                while (myReader.Read())
                {
                    lbltchTID.Text = myReader["TID"].ToString();
                    lbltchName.Text = myReader["Name"].ToString();
                    lbltchCnic.Text = myReader["CNIC"].ToString();
                    lbltchGender.Text = myReader["Gender"].ToString();
                    lbltchReligion.Text = myReader["Religion"].ToString();
                    lbltchBloodgroup.Text = myReader["BloodGroup"].ToString();
                    lbltchQualification.Text = myReader["Qualification"].ToString();
                    lbltchDesignation.Text = myReader["Designation"].ToString();
                    lbltchPhone.Text = myReader["Phone"].ToString();
                    lbltchEmail.Text = myReader["Email"].ToString();
                    lbltchAddress.Text = myReader["Address"].ToString();

                }
            }
        }
        public static string courseID { get; set; }
        public void CourseDetail()
        {
            SqlDataReader myReader = Connection.CourseDetailTP(tid);
           
                while (myReader.Read())
            {
                courseID= myReader["CID"].ToString();
                
                lblCourseID.Text = courseID;
                    lblCourseName.Text = myReader["CourseTitle"].ToString();
                lblCourseCreditHour.Text = myReader["CreditHour"].ToString();
                }
        }

        public void LectureDetail()
        {
            SqlDataReader myReader = Connection.LectureTP(tid);
            while (myReader.Read())
            {
                lbllec1.Text = myReader["Lecture1"].ToString();
                lbllec2.Text = myReader["Lecture2"].ToString();
                lbllec3.Text = myReader["Lecture3"].ToString();
                lbllec4.Text = myReader["Lecture4"].ToString();
                lbllec5.Text = myReader["Lecture5"].ToString();


            }
        }
        private void btnTeacherLogOut_Click(object sender, EventArgs e)
        {
            TeacherLogin Login = new TeacherLogin();
            Login.Show();
            this.Hide();
        }

        private void btnAttendance1_Click(object sender, EventArgs e)
        {
            attedanceTable = Connection.MarkAttendance();
            Lec1 lecture1 = new Lec1();
            lecture1.Show();
            this.Hide();
        }

        private void btnAttendance2_Click(object sender, EventArgs e)
        {
            attedanceTable = Connection.MarkAttendance();
            Lec2 lecture2 = new Lec2();
            lecture2.Show();
            this.Hide();
        }

        private void btnAttendance3_Click(object sender, EventArgs e)
        {
            attedanceTable = Connection.MarkAttendance();
            Lec3 lecture3 = new Lec3();
            lecture3.Show();
            this.Hide();
        }

        private void btnAttendance4_Click(object sender, EventArgs e)
        {
            attedanceTable = Connection.MarkAttendance();
            Lec4 lecture4 = new Lec4();
            lecture4.Show();
            this.Hide();
        }

        private void btnattendence5_Click(object sender, EventArgs e)
        {
            attedanceTable = Connection.MarkAttendance();
            Lec5 lecture5 = new Lec5();
            lecture5.Show();
            this.Hide();
        }
    }
}
