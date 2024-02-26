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


namespace ProjectTrial.Presentation
{
    public partial class Lec2 : MaterialForm
    {
        readonly MaterialSkinManager skinManager;
        public Lec2()
        {
            InitializeComponent();
            grdStd1.CellClick += grdStd1_CellClick;


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

        private void grdStd1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = grdStd1.Rows[e.RowIndex];

                // Get values from the selected row
                txtRegNo1.Text = row.Cells["RegNo"].Value.ToString();
                txtStdName.Text = row.Cells["Name"].Value.ToString();
            }
        }

        private string attendance;

        private void Lec2_Load_1(object sender, EventArgs e)
        {
            DataTable myTable = Teachers_Portal.attedanceTable;
            grdStd1.DataSource = myTable;

        }

        private void btnUpdateAttendance_Click(object sender, EventArgs e)
        {
            string cid = Teachers_Portal.courseID;

            if (switchIsPresent.Checked) { attendance = "Present"; }
            grdatt1.DataSource = Connection.Attendance(attendance, txtRegNo1.Text, txtAtID.Text, cid);
            MessageBox.Show("Attendance of " + txtRegNo1.Text + " Updated!");
            txtRegNo1.Clear();
            txtStdName.Clear();
            switchIsPresent.Checked = false;
        }

        private void DateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            Attendance a = new Attendance(txtAtID.Text, DateTimePicker1.Value);
            Connection.AttendanceDate(a);
        }

        private void btnShowAttendance_Click_1(object sender, EventArgs e)
        {
            grdatt1.DataSource = Connection.AttendanceStatus(txtAtID.Text);
        }

        private void gunaButton2_Click_1(object sender, EventArgs e)
        {
            Teachers_Portal portal = new Teachers_Portal();
            portal.Show();
            this.Hide();
        }

        private void btnTeacherLogOut_Click_1(object sender, EventArgs e)
        {
            TeacherLogin login = new TeacherLogin();
            login.Show();
            this.Hide();

        }
    }
}
