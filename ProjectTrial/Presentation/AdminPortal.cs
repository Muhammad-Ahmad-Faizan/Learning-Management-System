using MaterialSkin;
using MaterialSkin.Controls;
using ProjectTrial.BusinessLayer;
using ProjectTrial.DataLayer;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProjectTrial.Presentation
{
    public partial class AdminPortal : MaterialForm
    {
        private readonly MaterialSkinManager skinManager;
        public static string TeacherID { get; set; }
        public AdminPortal()
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
            UpdateStudentCount();

            UpdateTeacherCount(); 
        }

        private void AdminPortal_Load(object sender, EventArgs e)
        {

            cmbBloodGroup.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDepartment.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSpecialization.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStudentGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTBloodGroup.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTGender.DropDownStyle = ComboBoxStyle.DropDownList;
            
        }

        // ------------------------->Manage Student Methods<-------------------------
        private void btnTShow_Click(object sender, EventArgs e)
        {
            gridTeacher.DataSource = Connection.GetTeacherTable();
            UpdateTeacherCount();
        }

        private void btnTAdd_Click(object sender, EventArgs e)
        {
            
            Teacher teacher = new Teacher(txtQualification.Text, txtTDesignation.Text, txtTeacherID.Text, txtTName.Text, int.Parse(txtTCnic.Text), cmbTGender.Text, cmbTBloodGroup.Text, txtTReligion.Text, txtTPhone.Text, txtTEmail.Text, txtTAddress.Text, txtTPassword.Text);
            Connection.InsertTeacher(teacher);
            TeacherID = txtTeacherID.Text;

            MessageBox.Show("Added!");
            txtQualification.Clear();
            txtTDesignation.Clear();
            txtTeacherID.Clear();
            txtTName.Clear();
            txtTCnic.Clear();
            txtTReligion.Clear();
            txtTPhone.Clear();
            txtTEmail.Clear();
            txtTPassword.Clear();
            txtTAddress.Clear();
            //cmbTGender.Items.Clear();
            cmbTGender.SelectedIndex = -1;
            //cmbTBloodGroup.Items.Clear();
            cmbTBloodGroup.SelectedIndex = -1;


            AssignCourse c = new AssignCourse();
            c.Show();



        }

        private void GridTeacher_SelectionChanged(object sender, EventArgs e)
        {

            if (gridTeacher.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = gridTeacher.SelectedRows[0];


            }
        }

        private void gridTeacher_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow Row = this.gridTeacher.Rows[e.RowIndex];

                // Assign the values to the textboxes and comboboxes
                txtTeacherID.Text = Row.Cells["TID"].Value.ToString();
                txtTName.Text = Row.Cells["Name"].Value.ToString();
                txtTCnic.Text = Row.Cells["CNIC"].Value.ToString();
                cmbTGender.Text = Row.Cells["Gender"].Value.ToString();
                cmbTBloodGroup.Text = Row.Cells["BloodGroup"].Value.ToString();
                txtTReligion.Text = Row.Cells["Religion"].Value.ToString();
                txtQualification.Text = Row.Cells["Qualification"].Value.ToString();
                txtTDesignation.Text = Row.Cells["Designation"].Value.ToString();
                txtTPhone.Text = Row.Cells["Phone"].Value.ToString();
                txtTEmail.Text = Row.Cells["Email"].Value.ToString();
                txtTAddress.Text = Row.Cells["Address"].Value.ToString();
                txtTPassword.Text = Row.Cells["Password"].Value.ToString();
                // Continue for all fields...
            }
        }

        private void btnTUpdate_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher(txtQualification.Text, txtTDesignation.Text, txtTeacherID.Text, txtTName.Text, int.Parse(txtTCnic.Text), cmbTGender.Text, cmbTBloodGroup.Text, txtTReligion.Text, txtTPhone.Text, txtTEmail.Text, txtTAddress.Text, txtTPassword.Text);
            Connection.UpdateTeacher(teacher);
            MessageBox.Show("Updated!");
            txtQualification.Clear();
            txtTDesignation.Clear();
            txtTeacherID.Clear();
            txtTName.Clear();
            txtTCnic.Clear();
            txtTReligion.Clear();
            txtTPhone.Clear();
            txtTEmail.Clear();
            txtTPassword.Clear();
            txtTAddress.Clear();
           // cmbTGender.Items.Clear();
            cmbTGender.SelectedIndex = -1;
           // cmbTBloodGroup.Items.Clear();
           cmbTBloodGroup.SelectedIndex = -1;
            UpdateTeacherCount();
        }

        private void btnTDel_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher(txtQualification.Text, txtTDesignation.Text, txtTeacherID.Text, txtTName.Text, int.Parse(txtTCnic.Text), cmbTGender.Text, cmbTBloodGroup.Text, txtTReligion.Text, txtTPhone.Text, txtTEmail.Text, txtTAddress.Text, txtTPassword.Text);

            Connection.DeleteTeacher(teacher);
            MessageBox.Show("Deleted!");
            txtQualification.Clear();
            txtTDesignation.Clear();
            txtTeacherID.Clear();
            txtTName.Clear();
            txtTCnic.Clear();
            txtTReligion.Clear();
            txtTPhone.Clear();
            txtTEmail.Clear();
            txtTPassword.Clear();
            txtTAddress.Clear();
            cmbTGender.SelectedIndex = -1;
           // cmbTBloodGroup.Items.Clear();
            cmbTBloodGroup.SelectedIndex = -1;

            UpdateTeacherCount();
        }


        // ------------------------->Manage Student Methods<-------------------------
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Student std = new Student(txtRegNumber.Text, txtStudentName.Text, txtFatherName.Text, txtStdFContact.Text, txtBatch.Text, cmbDepartment.Text, cmbSpecialization.Text,  int.Parse(txtCnic.Text), cmbStudentGender.Text, cmbBloodGroup.Text, txtStdReligion.Text, txtStdPhone.Text, txtStdEmail.Text, txtStdAddress.Text, txtStdPassword.Text);

            Connection.InsertStudent(std);
            MessageBox.Show("Student Added!");
            txtRegNumber.Clear();
            txtFatherName.Clear();
            txtStdFContact.Clear();
            txtBatch.Clear();
            cmbDepartment.Items.Clear();
            cmbDepartment.SelectedIndex = -1;
            cmbSpecialization.Items.Clear();
            cmbSpecialization.SelectedIndex = -1;
            txtStudentName.Clear();
            txtCnic.Clear();
            cmbStudentGender.Items.Clear();
            cmbStudentGender.SelectedIndex = -1;
            cmbBloodGroup.Items.Clear();
            cmbBloodGroup.SelectedIndex = -1;
            txtStdReligion.Clear();
            txtStdPhone.Clear();
            txtStdEmail.Clear();
            txtStdAddress.Clear();
            txtStdPassword.Clear();

            UpdateStudentCount();

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            gridStudent.DataSource = Connection.GetStudentTable();
            UpdateStudentCount();
        }

        private void gridStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.gridStudent.Rows[e.RowIndex];

                // Get values from the selected row
                txtRegNumber.Text = row.Cells["RegNo"].Value.ToString();
                txtStudentName.Text = row.Cells["Name"].Value.ToString();
                txtCnic.Text = row.Cells["CNIC"].Value.ToString();
                cmbStudentGender.Text = row.Cells["Gender"].Value.ToString();
                cmbBloodGroup.Text = row.Cells["BloodGroup"].Value.ToString();
                txtStdReligion.Text = row.Cells["Religion"].Value.ToString();
                txtStdPhone.Text = row.Cells["Phone"].Value.ToString();
                txtStdEmail.Text = row.Cells["Email"].Value.ToString();
                txtStdAddress.Text = row.Cells["Address"].Value.ToString();
                txtFatherName.Text = row.Cells["FatherName"].Value.ToString();
                txtStdFContact.Text = row.Cells["Contact"].Value.ToString();
                txtBatch.Text = row.Cells["Batch"].Value.ToString();
                cmbDepartment.Text = row.Cells["Department"].Value.ToString();
                cmbSpecialization.Text = row.Cells["Specialization"].Value.ToString();
                txtStdPassword.Text = row.Cells["Password"].Value.ToString();

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Student std = new Student(txtRegNumber.Text, txtStudentName.Text, txtFatherName.Text, txtStdFContact.Text, txtBatch.Text, cmbDepartment.Text, cmbSpecialization.Text,  int.Parse(txtCnic.Text), cmbStudentGender.Text, cmbBloodGroup.Text, txtStdReligion.Text, txtStdPhone.Text, txtStdEmail.Text, txtStdAddress.Text, txtStdPassword.Text);
            Connection.UpdateStudent(std);
            MessageBox.Show("Student Updated!");
            txtRegNumber.Clear();
            txtFatherName.Clear();
            txtStdFContact.Clear();
            txtBatch.Clear();
            cmbDepartment.Items.Clear();
            cmbDepartment.SelectedIndex = -1;
            cmbSpecialization.Items.Clear();
            cmbSpecialization.SelectedIndex = -1;
            txtStudentName.Clear();
            txtCnic.Clear();
            cmbStudentGender.Items.Clear();
            cmbStudentGender.SelectedIndex = -1;
            cmbBloodGroup.Items.Clear();
            cmbBloodGroup.SelectedIndex = -1;
            txtStdReligion.Clear();
            txtStdPhone.Clear();
            txtStdEmail.Clear();
            txtStdAddress.Clear();
            txtStdPassword.Clear();

            UpdateStudentCount();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Student std = new Student(txtRegNumber.Text, txtStudentName.Text, txtFatherName.Text, txtStdFContact.Text, txtBatch.Text, cmbDepartment.Text, cmbSpecialization.Text, int.Parse(txtCnic.Text), cmbStudentGender.Text, cmbBloodGroup.Text, txtStdReligion.Text, txtStdPhone.Text, txtStdEmail.Text, txtStdAddress.Text, txtStdPassword.Text);
            Connection.DeleteStudent(std);
            MessageBox.Show("Student Deleted!");
            txtRegNumber.Clear();
            txtFatherName.Clear();
            txtStdFContact.Clear();
            txtBatch.Clear();
            cmbDepartment.Items.Clear();
            cmbDepartment.SelectedIndex = -1;
            cmbSpecialization.Items.Clear();
            cmbSpecialization.SelectedIndex = -1;
            txtStudentName.Clear();
            txtCnic.Clear();
            cmbStudentGender.Items.Clear();
            cmbStudentGender.SelectedIndex = -1;
            cmbBloodGroup.Items.Clear();
            cmbBloodGroup.SelectedIndex = -1;
            txtStdReligion.Clear();
            txtStdPhone.Clear();
            txtStdEmail.Clear();
            txtStdAddress.Clear();
            txtStdPassword.Clear();

            UpdateStudentCount();

        }

      
        private void UpdateStudentCount()
        {
            int studentCount = Connection.CountStudent();

            lblTotalStd.Text = studentCount.ToString();
        }
        private void UpdateTeacherCount()
        {
            int teacherCount = Connection.CountTeacher();

            lblTotalTeacher.Text = teacherCount.ToString();
        }


        private void btnAdminLogOut_Click(object sender, EventArgs e)
        {
            AdminLogin logout = new AdminLogin();
            logout.Show();
            this.Hide();
        }
    }
}
