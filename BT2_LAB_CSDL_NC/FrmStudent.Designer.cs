﻿
namespace BT2_LAB_CSDL_NC
{
    partial class FrmStudent
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox_Student = new System.Windows.Forms.GroupBox();
            this.dateTimePicker_BirthDate = new System.Windows.Forms.DateTimePicker();
            this.comboBox_CourseCode = new System.Windows.Forms.ComboBox();
            this.label_CourseCode = new System.Windows.Forms.Label();
            this.textBox_Age = new System.Windows.Forms.TextBox();
            this.textBox_AdYear = new System.Windows.Forms.TextBox();
            this.textBox_FirstName = new System.Windows.Forms.TextBox();
            this.textBox_LastName = new System.Windows.Forms.TextBox();
            this.textBox_StudentCode = new System.Windows.Forms.TextBox();
            this.label_Age = new System.Windows.Forms.Label();
            this.label_BirthDate = new System.Windows.Forms.Label();
            this.label_AdYear = new System.Windows.Forms.Label();
            this.label_FirstName = new System.Windows.Forms.Label();
            this.label_LastName = new System.Windows.Forms.Label();
            this.label_StudentCode = new System.Windows.Forms.Label();
            this.dataGridView_Student = new System.Windows.Forms.DataGridView();
            this.groupBox_Function = new System.Windows.Forms.GroupBox();
            this.button_Back = new System.Windows.Forms.Button();
            this.button_Modify = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Reload = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_StudentCode = new System.Windows.Forms.Button();
            this.button_Age = new System.Windows.Forms.Button();
            this.groupBox_SearchBy = new System.Windows.Forms.GroupBox();
            this.button_CourseCode = new System.Windows.Forms.Button();
            this.button_AdYear = new System.Windows.Forms.Button();
            this.button_Name = new System.Windows.Forms.Button();
            this.groupBox_Student.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Student)).BeginInit();
            this.groupBox_Function.SuspendLayout();
            this.groupBox_SearchBy.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Student
            // 
            this.groupBox_Student.Controls.Add(this.dateTimePicker_BirthDate);
            this.groupBox_Student.Controls.Add(this.comboBox_CourseCode);
            this.groupBox_Student.Controls.Add(this.label_CourseCode);
            this.groupBox_Student.Controls.Add(this.textBox_Age);
            this.groupBox_Student.Controls.Add(this.textBox_AdYear);
            this.groupBox_Student.Controls.Add(this.textBox_FirstName);
            this.groupBox_Student.Controls.Add(this.textBox_LastName);
            this.groupBox_Student.Controls.Add(this.textBox_StudentCode);
            this.groupBox_Student.Controls.Add(this.label_Age);
            this.groupBox_Student.Controls.Add(this.label_BirthDate);
            this.groupBox_Student.Controls.Add(this.label_AdYear);
            this.groupBox_Student.Controls.Add(this.label_FirstName);
            this.groupBox_Student.Controls.Add(this.label_LastName);
            this.groupBox_Student.Controls.Add(this.label_StudentCode);
            this.groupBox_Student.Location = new System.Drawing.Point(12, 12);
            this.groupBox_Student.Name = "groupBox_Student";
            this.groupBox_Student.Size = new System.Drawing.Size(683, 316);
            this.groupBox_Student.TabIndex = 0;
            this.groupBox_Student.TabStop = false;
            this.groupBox_Student.Text = "Student";
            // 
            // dateTimePicker_BirthDate
            // 
            this.dateTimePicker_BirthDate.Location = new System.Drawing.Point(219, 187);
            this.dateTimePicker_BirthDate.Name = "dateTimePicker_BirthDate";
            this.dateTimePicker_BirthDate.Size = new System.Drawing.Size(449, 31);
            this.dateTimePicker_BirthDate.TabIndex = 15;
            this.dateTimePicker_BirthDate.ValueChanged += new System.EventHandler(this.dateTimePicker_BirthDate_ValueChanged);
            // 
            // comboBox_CourseCode
            // 
            this.comboBox_CourseCode.FormattingEnabled = true;
            this.comboBox_CourseCode.Location = new System.Drawing.Point(219, 261);
            this.comboBox_CourseCode.Name = "comboBox_CourseCode";
            this.comboBox_CourseCode.Size = new System.Drawing.Size(449, 33);
            this.comboBox_CourseCode.TabIndex = 14;
            // 
            // label_CourseCode
            // 
            this.label_CourseCode.AutoSize = true;
            this.label_CourseCode.Location = new System.Drawing.Point(8, 264);
            this.label_CourseCode.Name = "label_CourseCode";
            this.label_CourseCode.Size = new System.Drawing.Size(114, 25);
            this.label_CourseCode.TabIndex = 13;
            this.label_CourseCode.Text = "Course Code";
            // 
            // textBox_Age
            // 
            this.textBox_Age.Location = new System.Drawing.Point(219, 224);
            this.textBox_Age.Name = "textBox_Age";
            this.textBox_Age.Size = new System.Drawing.Size(449, 31);
            this.textBox_Age.TabIndex = 11;
            // 
            // textBox_AdYear
            // 
            this.textBox_AdYear.Location = new System.Drawing.Point(219, 150);
            this.textBox_AdYear.Name = "textBox_AdYear";
            this.textBox_AdYear.Size = new System.Drawing.Size(449, 31);
            this.textBox_AdYear.TabIndex = 9;
            // 
            // textBox_FirstName
            // 
            this.textBox_FirstName.Location = new System.Drawing.Point(219, 113);
            this.textBox_FirstName.Name = "textBox_FirstName";
            this.textBox_FirstName.Size = new System.Drawing.Size(449, 31);
            this.textBox_FirstName.TabIndex = 8;
            // 
            // textBox_LastName
            // 
            this.textBox_LastName.Location = new System.Drawing.Point(219, 76);
            this.textBox_LastName.Name = "textBox_LastName";
            this.textBox_LastName.Size = new System.Drawing.Size(449, 31);
            this.textBox_LastName.TabIndex = 7;
            // 
            // textBox_StudentCode
            // 
            this.textBox_StudentCode.Location = new System.Drawing.Point(219, 39);
            this.textBox_StudentCode.Name = "textBox_StudentCode";
            this.textBox_StudentCode.Size = new System.Drawing.Size(449, 31);
            this.textBox_StudentCode.TabIndex = 6;
            // 
            // label_Age
            // 
            this.label_Age.AutoSize = true;
            this.label_Age.Location = new System.Drawing.Point(8, 227);
            this.label_Age.Name = "label_Age";
            this.label_Age.Size = new System.Drawing.Size(44, 25);
            this.label_Age.TabIndex = 5;
            this.label_Age.Text = "Age";
            // 
            // label_BirthDate
            // 
            this.label_BirthDate.AutoSize = true;
            this.label_BirthDate.Location = new System.Drawing.Point(8, 190);
            this.label_BirthDate.Name = "label_BirthDate";
            this.label_BirthDate.Size = new System.Drawing.Size(209, 25);
            this.label_BirthDate.TabIndex = 4;
            this.label_BirthDate.Text = "Birth Date (mm/dd/yyyy)";
            // 
            // label_AdYear
            // 
            this.label_AdYear.AutoSize = true;
            this.label_AdYear.Location = new System.Drawing.Point(8, 153);
            this.label_AdYear.Name = "label_AdYear";
            this.label_AdYear.Size = new System.Drawing.Size(155, 25);
            this.label_AdYear.TabIndex = 3;
            this.label_AdYear.Text = "Year of Admission";
            // 
            // label_FirstName
            // 
            this.label_FirstName.AutoSize = true;
            this.label_FirstName.Location = new System.Drawing.Point(8, 116);
            this.label_FirstName.Name = "label_FirstName";
            this.label_FirstName.Size = new System.Drawing.Size(97, 25);
            this.label_FirstName.TabIndex = 2;
            this.label_FirstName.Text = "First Name";
            // 
            // label_LastName
            // 
            this.label_LastName.AutoSize = true;
            this.label_LastName.Location = new System.Drawing.Point(8, 79);
            this.label_LastName.Name = "label_LastName";
            this.label_LastName.Size = new System.Drawing.Size(95, 25);
            this.label_LastName.TabIndex = 1;
            this.label_LastName.Text = "Last Name";
            // 
            // label_StudentCode
            // 
            this.label_StudentCode.AutoSize = true;
            this.label_StudentCode.Location = new System.Drawing.Point(8, 42);
            this.label_StudentCode.Name = "label_StudentCode";
            this.label_StudentCode.Size = new System.Drawing.Size(120, 25);
            this.label_StudentCode.TabIndex = 0;
            this.label_StudentCode.Text = "Student Code";
            // 
            // dataGridView_Student
            // 
            this.dataGridView_Student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Student.Location = new System.Drawing.Point(12, 373);
            this.dataGridView_Student.Name = "dataGridView_Student";
            this.dataGridView_Student.RowHeadersWidth = 62;
            this.dataGridView_Student.RowTemplate.Height = 33;
            this.dataGridView_Student.Size = new System.Drawing.Size(1069, 229);
            this.dataGridView_Student.TabIndex = 1;
            this.dataGridView_Student.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Student_CellContentClick);
            // 
            // groupBox_Function
            // 
            this.groupBox_Function.Controls.Add(this.button_Back);
            this.groupBox_Function.Controls.Add(this.button_Modify);
            this.groupBox_Function.Controls.Add(this.button_Delete);
            this.groupBox_Function.Controls.Add(this.button_Reload);
            this.groupBox_Function.Controls.Add(this.button_Add);
            this.groupBox_Function.Location = new System.Drawing.Point(701, 12);
            this.groupBox_Function.Name = "groupBox_Function";
            this.groupBox_Function.Size = new System.Drawing.Size(380, 161);
            this.groupBox_Function.TabIndex = 16;
            this.groupBox_Function.TabStop = false;
            this.groupBox_Function.Text = "Function";
            // 
            // button_Back
            // 
            this.button_Back.Location = new System.Drawing.Point(258, 42);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(112, 42);
            this.button_Back.TabIndex = 21;
            this.button_Back.Text = "BACK";
            this.button_Back.UseVisualStyleBackColor = true;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // button_Modify
            // 
            this.button_Modify.Location = new System.Drawing.Point(140, 90);
            this.button_Modify.Name = "button_Modify";
            this.button_Modify.Size = new System.Drawing.Size(112, 42);
            this.button_Modify.TabIndex = 20;
            this.button_Modify.Text = "MODIFY";
            this.button_Modify.UseVisualStyleBackColor = true;
            this.button_Modify.Click += new System.EventHandler(this.button_Modify_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(140, 42);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(112, 42);
            this.button_Delete.TabIndex = 19;
            this.button_Delete.Text = "DELETE";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Reload
            // 
            this.button_Reload.Location = new System.Drawing.Point(22, 90);
            this.button_Reload.Name = "button_Reload";
            this.button_Reload.Size = new System.Drawing.Size(112, 42);
            this.button_Reload.TabIndex = 18;
            this.button_Reload.Text = "RELOAD";
            this.button_Reload.UseVisualStyleBackColor = true;
            this.button_Reload.Click += new System.EventHandler(this.button_Reload_Click);
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(22, 42);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(112, 42);
            this.button_Add.TabIndex = 17;
            this.button_Add.Text = "ADD";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_StudentCode
            // 
            this.button_StudentCode.Location = new System.Drawing.Point(22, 30);
            this.button_StudentCode.Name = "button_StudentCode";
            this.button_StudentCode.Size = new System.Drawing.Size(112, 42);
            this.button_StudentCode.TabIndex = 19;
            this.button_StudentCode.Text = "S_CODE";
            this.button_StudentCode.UseVisualStyleBackColor = true;
            this.button_StudentCode.Click += new System.EventHandler(this.button_StudentCode_Click);
            // 
            // button_Age
            // 
            this.button_Age.Location = new System.Drawing.Point(22, 78);
            this.button_Age.Name = "button_Age";
            this.button_Age.Size = new System.Drawing.Size(112, 42);
            this.button_Age.TabIndex = 20;
            this.button_Age.Text = "AGE";
            this.button_Age.UseVisualStyleBackColor = true;
            this.button_Age.Click += new System.EventHandler(this.button_Age_Click);
            // 
            // groupBox_SearchBy
            // 
            this.groupBox_SearchBy.Controls.Add(this.button_CourseCode);
            this.groupBox_SearchBy.Controls.Add(this.button_AdYear);
            this.groupBox_SearchBy.Controls.Add(this.button_Name);
            this.groupBox_SearchBy.Controls.Add(this.button_StudentCode);
            this.groupBox_SearchBy.Controls.Add(this.button_Age);
            this.groupBox_SearchBy.Location = new System.Drawing.Point(701, 179);
            this.groupBox_SearchBy.Name = "groupBox_SearchBy";
            this.groupBox_SearchBy.Size = new System.Drawing.Size(380, 149);
            this.groupBox_SearchBy.TabIndex = 19;
            this.groupBox_SearchBy.TabStop = false;
            this.groupBox_SearchBy.Text = "Search By";
            // 
            // button_CourseCode
            // 
            this.button_CourseCode.Location = new System.Drawing.Point(258, 31);
            this.button_CourseCode.Name = "button_CourseCode";
            this.button_CourseCode.Size = new System.Drawing.Size(112, 42);
            this.button_CourseCode.TabIndex = 23;
            this.button_CourseCode.Text = "C_CODE";
            this.button_CourseCode.UseVisualStyleBackColor = true;
            this.button_CourseCode.Click += new System.EventHandler(this.button_CourseCode_Click);
            // 
            // button_AdYear
            // 
            this.button_AdYear.Location = new System.Drawing.Point(140, 78);
            this.button_AdYear.Name = "button_AdYear";
            this.button_AdYear.Size = new System.Drawing.Size(112, 42);
            this.button_AdYear.TabIndex = 22;
            this.button_AdYear.Text = "AD_YEAR";
            this.button_AdYear.UseVisualStyleBackColor = true;
            this.button_AdYear.Click += new System.EventHandler(this.button_AdYear_Click);
            // 
            // button_Name
            // 
            this.button_Name.Location = new System.Drawing.Point(140, 30);
            this.button_Name.Name = "button_Name";
            this.button_Name.Size = new System.Drawing.Size(112, 42);
            this.button_Name.TabIndex = 21;
            this.button_Name.Text = "NAME";
            this.button_Name.UseVisualStyleBackColor = true;
            this.button_Name.Click += new System.EventHandler(this.button_Name_Click);
            // 
            // FrmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 614);
            this.Controls.Add(this.groupBox_SearchBy);
            this.Controls.Add(this.groupBox_Function);
            this.Controls.Add(this.dataGridView_Student);
            this.Controls.Add(this.groupBox_Student);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmStudent";
            this.Text = "FrmStudent";
            this.Load += new System.EventHandler(this.FrmStudent_Load);
            this.groupBox_Student.ResumeLayout(false);
            this.groupBox_Student.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Student)).EndInit();
            this.groupBox_Function.ResumeLayout(false);
            this.groupBox_SearchBy.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Student;
        private System.Windows.Forms.TextBox textBox_Age;
        private System.Windows.Forms.TextBox textBox_AdYear;
        private System.Windows.Forms.TextBox textBox_FirstName;
        private System.Windows.Forms.TextBox textBox_LastName;
        private System.Windows.Forms.TextBox textBox_StudentCode;
        private System.Windows.Forms.Label label_Age;
        private System.Windows.Forms.Label label_BirthDate;
        private System.Windows.Forms.Label label_AdYear;
        private System.Windows.Forms.Label label_FirstName;
        private System.Windows.Forms.Label label_LastName;
        private System.Windows.Forms.Label label_StudentCode;
        private System.Windows.Forms.DataGridView dataGridView_Student;
        private System.Windows.Forms.GroupBox groupBox_Function;
        private System.Windows.Forms.Button button_Reload;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_StudentCode;
        private System.Windows.Forms.Button button_Age;
        private System.Windows.Forms.GroupBox groupBox_SearchBy;
        private System.Windows.Forms.Button button_Modify;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_AdYear;
        private System.Windows.Forms.Button button_Name;
        private System.Windows.Forms.Label label_CourseCode;
        private System.Windows.Forms.ComboBox comboBox_CourseCode;
        private System.Windows.Forms.Button button_Back;
        private System.Windows.Forms.Button button_CourseCode;
        private System.Windows.Forms.DateTimePicker dateTimePicker_BirthDate;
    }
}

