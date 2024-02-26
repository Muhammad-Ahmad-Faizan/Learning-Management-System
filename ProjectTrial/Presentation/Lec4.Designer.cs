
namespace ProjectTrial.Presentation
{
    partial class Lec4
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lec4));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdStd1 = new Guna.UI.WinForms.GunaDataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            this.btnTeacherLogOut = new Guna.UI.WinForms.GunaButton();
            this.switchIsPresent = new Guna.UI.WinForms.GunaWinSwitch();
            this.txtStdName = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtRegNo1 = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaElipse2 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.btnUpdateAttendance = new Guna.UI.WinForms.GunaButton();
            this.txtAtID = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.grdatt1 = new Guna.UI.WinForms.GunaDataGridView();
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.DateTimePicker1 = new Guna.UI.WinForms.GunaDateTimePicker();
            this.btnShowAttendance = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdStd1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdatt1)).BeginInit();
            this.gunaElipsePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdStd1
            // 
            this.grdStd1.AllowUserToAddRows = false;
            this.grdStd1.AllowUserToDeleteRows = false;
            this.grdStd1.AllowUserToResizeColumns = false;
            this.grdStd1.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.grdStd1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.grdStd1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdStd1.BackgroundColor = System.Drawing.Color.White;
            this.grdStd1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdStd1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grdStd1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 13F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdStd1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.grdStd1.ColumnHeadersHeight = 30;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdStd1.DefaultCellStyle = dataGridViewCellStyle9;
            this.grdStd1.EnableHeadersVisualStyles = false;
            this.grdStd1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grdStd1.Location = new System.Drawing.Point(546, 116);
            this.grdStd1.Name = "grdStd1";
            this.grdStd1.ReadOnly = true;
            this.grdStd1.RowHeadersVisible = false;
            this.grdStd1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdStd1.ShowCellErrors = false;
            this.grdStd1.ShowEditingIcon = false;
            this.grdStd1.ShowRowErrors = false;
            this.grdStd1.Size = new System.Drawing.Size(549, 530);
            this.grdStd1.TabIndex = 67;
            this.grdStd1.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.grdStd1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.grdStd1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.grdStd1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.grdStd1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.grdStd1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.grdStd1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.grdStd1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grdStd1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.grdStd1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grdStd1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.grdStd1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.grdStd1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.grdStd1.ThemeStyle.HeaderStyle.Height = 30;
            this.grdStd1.ThemeStyle.ReadOnly = true;
            this.grdStd1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.grdStd1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grdStd1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.grdStd1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.grdStd1.ThemeStyle.RowsStyle.Height = 22;
            this.grdStd1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grdStd1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(35, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 19);
            this.label1.TabIndex = 68;
            this.label1.Text = "Current Date:";
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 6;
            this.gunaElipse1.TargetControl = this.grdStd1;
            // 
            // gunaButton2
            // 
            this.gunaButton2.AnimationHoverSpeed = 0.07F;
            this.gunaButton2.AnimationSpeed = 0.03F;
            this.gunaButton2.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton2.BaseColor = System.Drawing.Color.White;
            this.gunaButton2.BorderColor = System.Drawing.Color.DodgerBlue;
            this.gunaButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gunaButton2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.gunaButton2.Image = null;
            this.gunaButton2.ImageSize = new System.Drawing.Size(36, 32);
            this.gunaButton2.Location = new System.Drawing.Point(1116, 29);
            this.gunaButton2.Name = "gunaButton2";
            this.gunaButton2.OnHoverBaseColor = System.Drawing.Color.DodgerBlue;
            this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.White;
            this.gunaButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton2.OnHoverImage = null;
            this.gunaButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton2.Radius = 9;
            this.gunaButton2.Size = new System.Drawing.Size(102, 31);
            this.gunaButton2.TabIndex = 70;
            this.gunaButton2.Text = "Back To Portal";
            this.gunaButton2.Click += new System.EventHandler(this.gunaButton2_Click);
            // 
            // btnTeacherLogOut
            // 
            this.btnTeacherLogOut.AnimationHoverSpeed = 0.07F;
            this.btnTeacherLogOut.AnimationSpeed = 0.03F;
            this.btnTeacherLogOut.BaseColor = System.Drawing.Color.Orange;
            this.btnTeacherLogOut.BorderColor = System.Drawing.Color.White;
            this.btnTeacherLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTeacherLogOut.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnTeacherLogOut.FocusedColor = System.Drawing.Color.Empty;
            this.btnTeacherLogOut.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTeacherLogOut.ForeColor = System.Drawing.Color.White;
            this.btnTeacherLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnTeacherLogOut.Image")));
            this.btnTeacherLogOut.ImageSize = new System.Drawing.Size(20, 20);
            this.btnTeacherLogOut.Location = new System.Drawing.Point(1238, 27);
            this.btnTeacherLogOut.Name = "btnTeacherLogOut";
            this.btnTeacherLogOut.OnHoverBaseColor = System.Drawing.Color.SteelBlue;
            this.btnTeacherLogOut.OnHoverBorderColor = System.Drawing.Color.White;
            this.btnTeacherLogOut.OnHoverForeColor = System.Drawing.Color.White;
            this.btnTeacherLogOut.OnHoverImage = null;
            this.btnTeacherLogOut.OnPressedColor = System.Drawing.Color.Black;
            this.btnTeacherLogOut.Size = new System.Drawing.Size(92, 35);
            this.btnTeacherLogOut.TabIndex = 74;
            this.btnTeacherLogOut.Text = "Log Out";
            this.btnTeacherLogOut.Click += new System.EventHandler(this.btnTeacherLogOut_Click);
            // 
            // switchIsPresent
            // 
            this.switchIsPresent.BaseColor = System.Drawing.SystemColors.Control;
            this.switchIsPresent.CheckedOffColor = System.Drawing.Color.Silver;
            this.switchIsPresent.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.switchIsPresent.FillColor = System.Drawing.Color.White;
            this.switchIsPresent.Location = new System.Drawing.Point(181, 196);
            this.switchIsPresent.Name = "switchIsPresent";
            this.switchIsPresent.Size = new System.Drawing.Size(40, 22);
            this.switchIsPresent.TabIndex = 10;
            // 
            // txtStdName
            // 
            this.txtStdName.BackColor = System.Drawing.Color.White;
            this.txtStdName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStdName.FocusedLineColor = System.Drawing.Color.DodgerBlue;
            this.txtStdName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtStdName.LineColor = System.Drawing.Color.DodgerBlue;
            this.txtStdName.LineSize = 2;
            this.txtStdName.Location = new System.Drawing.Point(181, 135);
            this.txtStdName.Name = "txtStdName";
            this.txtStdName.PasswordChar = '\0';
            this.txtStdName.SelectedText = "";
            this.txtStdName.Size = new System.Drawing.Size(240, 30);
            this.txtStdName.TabIndex = 9;
            // 
            // txtRegNo1
            // 
            this.txtRegNo1.BackColor = System.Drawing.Color.White;
            this.txtRegNo1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRegNo1.FocusedLineColor = System.Drawing.Color.DodgerBlue;
            this.txtRegNo1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtRegNo1.LineColor = System.Drawing.Color.DodgerBlue;
            this.txtRegNo1.LineSize = 2;
            this.txtRegNo1.Location = new System.Drawing.Point(181, 74);
            this.txtRegNo1.Name = "txtRegNo1";
            this.txtRegNo1.PasswordChar = '\0';
            this.txtRegNo1.SelectedText = "";
            this.txtRegNo1.Size = new System.Drawing.Size(240, 30);
            this.txtRegNo1.TabIndex = 8;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.gunaLabel4.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel4.Location = new System.Drawing.Point(15, 193);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(103, 25);
            this.gunaLabel4.TabIndex = 7;
            this.gunaLabel4.Text = "Is Present:";
            // 
            // gunaElipse2
            // 
            this.gunaElipse2.Radius = 9;
            this.gunaElipse2.TargetControl = this.btnTeacherLogOut;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.gunaLabel3.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel3.Location = new System.Drawing.Point(15, 135);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(145, 25);
            this.gunaLabel3.TabIndex = 2;
            this.gunaLabel3.Text = "Student Name:";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.gunaLabel1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.gunaLabel1.Location = new System.Drawing.Point(15, 13);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(164, 25);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Mark Attendance";
            // 
            // btnUpdateAttendance
            // 
            this.btnUpdateAttendance.AnimationHoverSpeed = 0.07F;
            this.btnUpdateAttendance.AnimationSpeed = 0.03F;
            this.btnUpdateAttendance.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdateAttendance.BaseColor = System.Drawing.Color.White;
            this.btnUpdateAttendance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnUpdateAttendance.BorderSize = 2;
            this.btnUpdateAttendance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateAttendance.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUpdateAttendance.FocusedColor = System.Drawing.Color.Empty;
            this.btnUpdateAttendance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnUpdateAttendance.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnUpdateAttendance.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateAttendance.Image")));
            this.btnUpdateAttendance.ImageSize = new System.Drawing.Size(36, 32);
            this.btnUpdateAttendance.Location = new System.Drawing.Point(120, 267);
            this.btnUpdateAttendance.Name = "btnUpdateAttendance";
            this.btnUpdateAttendance.OnHoverBaseColor = System.Drawing.Color.DodgerBlue;
            this.btnUpdateAttendance.OnHoverBorderColor = System.Drawing.Color.White;
            this.btnUpdateAttendance.OnHoverForeColor = System.Drawing.Color.White;
            this.btnUpdateAttendance.OnHoverImage = null;
            this.btnUpdateAttendance.OnPressedColor = System.Drawing.Color.Black;
            this.btnUpdateAttendance.Radius = 20;
            this.btnUpdateAttendance.Size = new System.Drawing.Size(187, 42);
            this.btnUpdateAttendance.TabIndex = 6;
            this.btnUpdateAttendance.Text = "Update Attendence";
            this.btnUpdateAttendance.Click += new System.EventHandler(this.btnUpdateAttendance_Click);
            // 
            // txtAtID
            // 
            this.txtAtID.BackColor = System.Drawing.Color.White;
            this.txtAtID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAtID.FocusedLineColor = System.Drawing.Color.DodgerBlue;
            this.txtAtID.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtAtID.LineColor = System.Drawing.Color.DodgerBlue;
            this.txtAtID.LineSize = 2;
            this.txtAtID.Location = new System.Drawing.Point(586, 80);
            this.txtAtID.Name = "txtAtID";
            this.txtAtID.PasswordChar = '\0';
            this.txtAtID.SelectedText = "";
            this.txtAtID.Size = new System.Drawing.Size(240, 30);
            this.txtAtID.TabIndex = 73;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.gunaLabel5.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel5.Location = new System.Drawing.Point(375, 83);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(205, 25);
            this.gunaLabel5.TabIndex = 72;
            this.gunaLabel5.Text = "Enter Attendance ID.:";
            // 
            // grdatt1
            // 
            this.grdatt1.AllowUserToAddRows = false;
            this.grdatt1.AllowUserToDeleteRows = false;
            this.grdatt1.AllowUserToResizeColumns = false;
            this.grdatt1.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.grdatt1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.grdatt1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdatt1.BackgroundColor = System.Drawing.Color.White;
            this.grdatt1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdatt1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grdatt1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 13F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdatt1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.grdatt1.ColumnHeadersHeight = 30;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdatt1.DefaultCellStyle = dataGridViewCellStyle12;
            this.grdatt1.EnableHeadersVisualStyles = false;
            this.grdatt1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grdatt1.Location = new System.Drawing.Point(1116, 116);
            this.grdatt1.Name = "grdatt1";
            this.grdatt1.ReadOnly = true;
            this.grdatt1.RowHeadersVisible = false;
            this.grdatt1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdatt1.ShowCellErrors = false;
            this.grdatt1.ShowEditingIcon = false;
            this.grdatt1.ShowRowErrors = false;
            this.grdatt1.Size = new System.Drawing.Size(186, 530);
            this.grdatt1.TabIndex = 76;
            this.grdatt1.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.grdatt1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.grdatt1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.grdatt1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.grdatt1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.grdatt1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.grdatt1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.grdatt1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grdatt1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.grdatt1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grdatt1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.grdatt1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.grdatt1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.grdatt1.ThemeStyle.HeaderStyle.Height = 30;
            this.grdatt1.ThemeStyle.ReadOnly = true;
            this.grdatt1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.grdatt1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grdatt1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.grdatt1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.grdatt1.ThemeStyle.RowsStyle.Height = 22;
            this.grdatt1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grdatt1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.White;
            this.gunaElipsePanel1.Controls.Add(this.switchIsPresent);
            this.gunaElipsePanel1.Controls.Add(this.txtStdName);
            this.gunaElipsePanel1.Controls.Add(this.txtRegNo1);
            this.gunaElipsePanel1.Controls.Add(this.gunaLabel4);
            this.gunaElipsePanel1.Controls.Add(this.gunaLabel3);
            this.gunaElipsePanel1.Controls.Add(this.gunaLabel2);
            this.gunaElipsePanel1.Controls.Add(this.gunaLabel1);
            this.gunaElipsePanel1.Controls.Add(this.btnUpdateAttendance);
            this.gunaElipsePanel1.Location = new System.Drawing.Point(57, 177);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Radius = 20;
            this.gunaElipsePanel1.Size = new System.Drawing.Size(450, 321);
            this.gunaElipsePanel1.TabIndex = 75;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.gunaLabel2.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel2.Location = new System.Drawing.Point(15, 76);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(172, 25);
            this.gunaLabel2.TabIndex = 1;
            this.gunaLabel2.Text = "Registeration No.:";
            // 
            // DateTimePicker1
            // 
            this.DateTimePicker1.BackColor = System.Drawing.Color.Transparent;
            this.DateTimePicker1.BaseColor = System.Drawing.Color.DodgerBlue;
            this.DateTimePicker1.BorderColor = System.Drawing.Color.Empty;
            this.DateTimePicker1.BorderSize = 0;
            this.DateTimePicker1.CustomFormat = null;
            this.DateTimePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.DateTimePicker1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DateTimePicker1.ForeColor = System.Drawing.Color.White;
            this.DateTimePicker1.Location = new System.Drawing.Point(39, 116);
            this.DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateTimePicker1.Name = "DateTimePicker1";
            this.DateTimePicker1.OnHoverBaseColor = System.Drawing.Color.White;
            this.DateTimePicker1.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DateTimePicker1.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DateTimePicker1.OnPressedColor = System.Drawing.Color.Black;
            this.DateTimePicker1.Radius = 6;
            this.DateTimePicker1.Size = new System.Drawing.Size(223, 30);
            this.DateTimePicker1.TabIndex = 69;
            this.DateTimePicker1.Text = "Friday, 12 January 2024";
            this.DateTimePicker1.Value = new System.DateTime(2024, 1, 12, 0, 10, 29, 271);
            this.DateTimePicker1.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // btnShowAttendance
            // 
            this.btnShowAttendance.AnimationHoverSpeed = 0.07F;
            this.btnShowAttendance.AnimationSpeed = 0.03F;
            this.btnShowAttendance.BackColor = System.Drawing.Color.Transparent;
            this.btnShowAttendance.BaseColor = System.Drawing.Color.White;
            this.btnShowAttendance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnShowAttendance.BorderSize = 2;
            this.btnShowAttendance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowAttendance.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnShowAttendance.FocusedColor = System.Drawing.Color.Empty;
            this.btnShowAttendance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnShowAttendance.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnShowAttendance.Image = ((System.Drawing.Image)(resources.GetObject("btnShowAttendance.Image")));
            this.btnShowAttendance.ImageSize = new System.Drawing.Size(36, 32);
            this.btnShowAttendance.Location = new System.Drawing.Point(1116, 670);
            this.btnShowAttendance.Name = "btnShowAttendance";
            this.btnShowAttendance.OnHoverBaseColor = System.Drawing.Color.Black;
            this.btnShowAttendance.OnHoverBorderColor = System.Drawing.Color.White;
            this.btnShowAttendance.OnHoverForeColor = System.Drawing.Color.White;
            this.btnShowAttendance.OnHoverImage = null;
            this.btnShowAttendance.OnPressedColor = System.Drawing.Color.Black;
            this.btnShowAttendance.Radius = 20;
            this.btnShowAttendance.Size = new System.Drawing.Size(187, 42);
            this.btnShowAttendance.TabIndex = 71;
            this.btnShowAttendance.Text = "Show Attendence";
            this.btnShowAttendance.Click += new System.EventHandler(this.btnShowAttendance_Click);
            // 
            // Lec4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 740);
            this.Controls.Add(this.grdStd1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gunaButton2);
            this.Controls.Add(this.btnTeacherLogOut);
            this.Controls.Add(this.txtAtID);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.grdatt1);
            this.Controls.Add(this.gunaElipsePanel1);
            this.Controls.Add(this.DateTimePicker1);
            this.Controls.Add(this.btnShowAttendance);
            this.Name = "Lec4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lecture 04 Attendance";
            this.Load += new System.EventHandler(this.Lec4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdStd1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdatt1)).EndInit();
            this.gunaElipsePanel1.ResumeLayout(false);
            this.gunaElipsePanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaDataGridView grdStd1;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaButton gunaButton2;
        private Guna.UI.WinForms.GunaButton btnTeacherLogOut;
        private Guna.UI.WinForms.GunaWinSwitch switchIsPresent;
        private Guna.UI.WinForms.GunaLineTextBox txtStdName;
        private Guna.UI.WinForms.GunaLineTextBox txtRegNo1;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaElipse gunaElipse2;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaButton btnUpdateAttendance;
        private Guna.UI.WinForms.GunaLineTextBox txtAtID;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaDataGridView grdatt1;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaDateTimePicker DateTimePicker1;
        private Guna.UI.WinForms.GunaButton btnShowAttendance;
    }
}