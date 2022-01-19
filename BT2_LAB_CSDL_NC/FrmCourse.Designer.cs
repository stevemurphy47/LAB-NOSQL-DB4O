
namespace BT2_LAB_CSDL_NC
{
    partial class FrmCourse
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
            this.groupBox_Course = new System.Windows.Forms.GroupBox();
            this.textBox_CourseName = new System.Windows.Forms.TextBox();
            this.textBox_CourseCode = new System.Windows.Forms.TextBox();
            this.label_CourseName = new System.Windows.Forms.Label();
            this.label_CourseCode = new System.Windows.Forms.Label();
            this.groupBox_Function = new System.Windows.Forms.GroupBox();
            this.button_Back = new System.Windows.Forms.Button();
            this.button_Modify = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Reload = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.groupBox_SearchBy = new System.Windows.Forms.GroupBox();
            this.button_Name = new System.Windows.Forms.Button();
            this.button_Code = new System.Windows.Forms.Button();
            this.dataGridView_Course = new System.Windows.Forms.DataGridView();
            this.groupBox_Course.SuspendLayout();
            this.groupBox_Function.SuspendLayout();
            this.groupBox_SearchBy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Course)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_Course
            // 
            this.groupBox_Course.Controls.Add(this.textBox_CourseName);
            this.groupBox_Course.Controls.Add(this.textBox_CourseCode);
            this.groupBox_Course.Controls.Add(this.label_CourseName);
            this.groupBox_Course.Controls.Add(this.label_CourseCode);
            this.groupBox_Course.Location = new System.Drawing.Point(12, 12);
            this.groupBox_Course.Name = "groupBox_Course";
            this.groupBox_Course.Size = new System.Drawing.Size(508, 132);
            this.groupBox_Course.TabIndex = 0;
            this.groupBox_Course.TabStop = false;
            this.groupBox_Course.Text = "Course";
            // 
            // textBox_CourseName
            // 
            this.textBox_CourseName.Location = new System.Drawing.Point(211, 89);
            this.textBox_CourseName.Name = "textBox_CourseName";
            this.textBox_CourseName.Size = new System.Drawing.Size(291, 31);
            this.textBox_CourseName.TabIndex = 3;
            // 
            // textBox_CourseCode
            // 
            this.textBox_CourseCode.Location = new System.Drawing.Point(211, 36);
            this.textBox_CourseCode.Name = "textBox_CourseCode";
            this.textBox_CourseCode.Size = new System.Drawing.Size(291, 31);
            this.textBox_CourseCode.TabIndex = 2;
            // 
            // label_CourseName
            // 
            this.label_CourseName.AutoSize = true;
            this.label_CourseName.Location = new System.Drawing.Point(33, 89);
            this.label_CourseName.Name = "label_CourseName";
            this.label_CourseName.Size = new System.Drawing.Size(119, 25);
            this.label_CourseName.TabIndex = 1;
            this.label_CourseName.Text = "Course Name";
            // 
            // label_CourseCode
            // 
            this.label_CourseCode.AutoSize = true;
            this.label_CourseCode.Location = new System.Drawing.Point(33, 39);
            this.label_CourseCode.Name = "label_CourseCode";
            this.label_CourseCode.Size = new System.Drawing.Size(114, 25);
            this.label_CourseCode.TabIndex = 0;
            this.label_CourseCode.Text = "Course Code";
            // 
            // groupBox_Function
            // 
            this.groupBox_Function.Controls.Add(this.button_Back);
            this.groupBox_Function.Controls.Add(this.button_Modify);
            this.groupBox_Function.Controls.Add(this.button_Delete);
            this.groupBox_Function.Controls.Add(this.button_Reload);
            this.groupBox_Function.Controls.Add(this.button_Add);
            this.groupBox_Function.Location = new System.Drawing.Point(12, 150);
            this.groupBox_Function.Name = "groupBox_Function";
            this.groupBox_Function.Size = new System.Drawing.Size(362, 132);
            this.groupBox_Function.TabIndex = 20;
            this.groupBox_Function.TabStop = false;
            this.groupBox_Function.Text = "Function";
            // 
            // button_Back
            // 
            this.button_Back.Location = new System.Drawing.Point(242, 30);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(112, 42);
            this.button_Back.TabIndex = 21;
            this.button_Back.Text = "BACK";
            this.button_Back.UseVisualStyleBackColor = true;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // button_Modify
            // 
            this.button_Modify.Location = new System.Drawing.Point(124, 78);
            this.button_Modify.Name = "button_Modify";
            this.button_Modify.Size = new System.Drawing.Size(112, 42);
            this.button_Modify.TabIndex = 20;
            this.button_Modify.Text = "MODIFY";
            this.button_Modify.UseVisualStyleBackColor = true;
            this.button_Modify.Click += new System.EventHandler(this.button_Modify_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(124, 30);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(112, 42);
            this.button_Delete.TabIndex = 19;
            this.button_Delete.Text = "DELETE";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Reload
            // 
            this.button_Reload.Location = new System.Drawing.Point(6, 78);
            this.button_Reload.Name = "button_Reload";
            this.button_Reload.Size = new System.Drawing.Size(112, 42);
            this.button_Reload.TabIndex = 18;
            this.button_Reload.Text = "RELOAD";
            this.button_Reload.UseVisualStyleBackColor = true;
            this.button_Reload.Click += new System.EventHandler(this.button_Reload_Click);
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(6, 30);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(112, 42);
            this.button_Add.TabIndex = 17;
            this.button_Add.Text = "ADD";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // groupBox_SearchBy
            // 
            this.groupBox_SearchBy.Controls.Add(this.button_Name);
            this.groupBox_SearchBy.Controls.Add(this.button_Code);
            this.groupBox_SearchBy.Location = new System.Drawing.Point(380, 150);
            this.groupBox_SearchBy.Name = "groupBox_SearchBy";
            this.groupBox_SearchBy.Size = new System.Drawing.Size(140, 132);
            this.groupBox_SearchBy.TabIndex = 21;
            this.groupBox_SearchBy.TabStop = false;
            this.groupBox_SearchBy.Text = "Search By";
            // 
            // button_Name
            // 
            this.button_Name.Location = new System.Drawing.Point(6, 78);
            this.button_Name.Name = "button_Name";
            this.button_Name.Size = new System.Drawing.Size(112, 42);
            this.button_Name.TabIndex = 21;
            this.button_Name.Text = "NAME";
            this.button_Name.UseVisualStyleBackColor = true;
            this.button_Name.Click += new System.EventHandler(this.button_Name_Click);
            // 
            // button_Code
            // 
            this.button_Code.Location = new System.Drawing.Point(6, 30);
            this.button_Code.Name = "button_Code";
            this.button_Code.Size = new System.Drawing.Size(112, 42);
            this.button_Code.TabIndex = 19;
            this.button_Code.Text = "CODE";
            this.button_Code.UseVisualStyleBackColor = true;
            this.button_Code.Click += new System.EventHandler(this.button_Code_Click);
            // 
            // dataGridView_Course
            // 
            this.dataGridView_Course.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Course.Location = new System.Drawing.Point(12, 300);
            this.dataGridView_Course.Name = "dataGridView_Course";
            this.dataGridView_Course.RowHeadersWidth = 62;
            this.dataGridView_Course.RowTemplate.Height = 33;
            this.dataGridView_Course.Size = new System.Drawing.Size(508, 292);
            this.dataGridView_Course.TabIndex = 22;
            this.dataGridView_Course.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Course_CellContentClick);
            // 
            // FrmCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 604);
            this.Controls.Add(this.dataGridView_Course);
            this.Controls.Add(this.groupBox_Function);
            this.Controls.Add(this.groupBox_SearchBy);
            this.Controls.Add(this.groupBox_Course);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmCourse";
            this.Text = "Course";
            this.Load += new System.EventHandler(this.FrmCourse_Load);
            this.groupBox_Course.ResumeLayout(false);
            this.groupBox_Course.PerformLayout();
            this.groupBox_Function.ResumeLayout(false);
            this.groupBox_SearchBy.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Course)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Course;
        private System.Windows.Forms.TextBox textBox_CourseName;
        private System.Windows.Forms.TextBox textBox_CourseCode;
        private System.Windows.Forms.Label label_CourseName;
        private System.Windows.Forms.Label label_CourseCode;
        private System.Windows.Forms.GroupBox groupBox_Function;
        private System.Windows.Forms.Button button_Modify;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Reload;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.GroupBox groupBox_SearchBy;
        private System.Windows.Forms.Button button_Name;
        private System.Windows.Forms.Button button_Code;
        private System.Windows.Forms.DataGridView dataGridView_Course;
        private System.Windows.Forms.Button button_Back;
    }
}

