
namespace ProjectTrial.Presentation
{
    partial class AssignCourse
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCourseCode = new Guna.UI.WinForms.GunaComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAssignCourse = new Guna.UI.WinForms.GunaButton();
            this.lblcourseName = new System.Windows.Forms.Label();
            this.lblCreditHour = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course Code:";
            // 
            // cmbCourseCode
            // 
            this.cmbCourseCode.BackColor = System.Drawing.Color.Transparent;
            this.cmbCourseCode.BaseColor = System.Drawing.Color.White;
            this.cmbCourseCode.BorderColor = System.Drawing.Color.DodgerBlue;
            this.cmbCourseCode.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCourseCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCourseCode.FocusedColor = System.Drawing.Color.Empty;
            this.cmbCourseCode.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCourseCode.ForeColor = System.Drawing.Color.Black;
            this.cmbCourseCode.FormattingEnabled = true;
            this.cmbCourseCode.Items.AddRange(new object[] {
            "COC-2070",
            "COC-2070L",
            "COC-2071",
            "COC-2071L",
            "COC-2072 ",
            "COC-2073",
            "MA-1001",
            "SES-2070"});
            this.cmbCourseCode.Location = new System.Drawing.Point(178, 92);
            this.cmbCourseCode.Name = "cmbCourseCode";
            this.cmbCourseCode.OnHoverItemBaseColor = System.Drawing.Color.Black;
            this.cmbCourseCode.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbCourseCode.Size = new System.Drawing.Size(196, 26);
            this.cmbCourseCode.TabIndex = 1;
            this.cmbCourseCode.SelectedIndexChanged += new System.EventHandler(this.cmbCourseCode_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Course Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Credit Hours:";
            // 
            // btnAssignCourse
            // 
            this.btnAssignCourse.AnimationHoverSpeed = 0.07F;
            this.btnAssignCourse.AnimationSpeed = 0.03F;
            this.btnAssignCourse.BackColor = System.Drawing.Color.Transparent;
            this.btnAssignCourse.BaseColor = System.Drawing.Color.DodgerBlue;
            this.btnAssignCourse.BorderColor = System.Drawing.Color.Black;
            this.btnAssignCourse.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAssignCourse.FocusedColor = System.Drawing.Color.Empty;
            this.btnAssignCourse.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAssignCourse.ForeColor = System.Drawing.Color.White;
            this.btnAssignCourse.Image = null;
            this.btnAssignCourse.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAssignCourse.Location = new System.Drawing.Point(271, 258);
            this.btnAssignCourse.Name = "btnAssignCourse";
            this.btnAssignCourse.OnHoverBaseColor = System.Drawing.Color.Black;
            this.btnAssignCourse.OnHoverBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnAssignCourse.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAssignCourse.OnHoverImage = null;
            this.btnAssignCourse.OnPressedColor = System.Drawing.Color.Black;
            this.btnAssignCourse.Radius = 20;
            this.btnAssignCourse.Size = new System.Drawing.Size(103, 42);
            this.btnAssignCourse.TabIndex = 4;
            this.btnAssignCourse.Text = "Assign Course";
            this.btnAssignCourse.Click += new System.EventHandler(this.btnAssignCourse_Click);
            // 
            // lblcourseName
            // 
            this.lblcourseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcourseName.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblcourseName.Location = new System.Drawing.Point(175, 157);
            this.lblcourseName.Name = "lblcourseName";
            this.lblcourseName.Size = new System.Drawing.Size(199, 18);
            this.lblcourseName.TabIndex = 5;
            // 
            // lblCreditHour
            // 
            this.lblCreditHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditHour.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblCreditHour.Location = new System.Drawing.Point(175, 216);
            this.lblCreditHour.Name = "lblCreditHour";
            this.lblCreditHour.Size = new System.Drawing.Size(199, 18);
            this.lblCreditHour.TabIndex = 6;
            // 
            // AssignCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 321);
            this.Controls.Add(this.lblCreditHour);
            this.Controls.Add(this.lblcourseName);
            this.Controls.Add(this.btnAssignCourse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbCourseCode);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "AssignCourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assign Course";
            this.Load += new System.EventHandler(this.AssignCourse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaComboBox cmbCourseCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaButton btnAssignCourse;
        private System.Windows.Forms.Label lblcourseName;
        private System.Windows.Forms.Label lblCreditHour;
    }
}