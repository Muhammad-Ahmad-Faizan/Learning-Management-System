using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using ProjectTrial.BusinessLayer;
using ProjectTrial.DataLayer;
using System.Data;
using System.Data.SqlClient;

namespace ProjectTrial.Presentation
{
    public partial class AssignCourse : MaterialForm
    {
        private readonly MaterialSkinManager skinManager;
        public AssignCourse()
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
        private string Tid = AdminPortal.TeacherID;
        
        private void btnAssignCourse_Click(object sender, EventArgs e)
        {
            Connection.AssignCourse(Tid,cmbCourseCode.Text);

            MessageBox.Show(cmbCourseCode.Text +" "+ lblcourseName.Text + " assigned to " + Tid) ;

            this.Hide();
        }

        private void AssignCourse_Load(object sender, EventArgs e)
        {
            
        }

        private void cmbCourseCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataReader myReader = Connection.ShowAssignCourse(cmbCourseCode.Text);
            while (myReader.Read())
            {
                lblcourseName.Text = myReader["CourseTitle"].ToString();
                lblCreditHour.Text = myReader["CreditHour"].ToString();
            }
        }
    }
}
