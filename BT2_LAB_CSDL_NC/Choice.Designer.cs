
namespace BT2_LAB_CSDL_NC
{
    partial class FrmChoice
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
            this.button_Course = new System.Windows.Forms.Button();
            this.button_Student = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Course
            // 
            this.button_Course.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Course.Location = new System.Drawing.Point(12, 26);
            this.button_Course.Name = "button_Course";
            this.button_Course.Size = new System.Drawing.Size(140, 63);
            this.button_Course.TabIndex = 0;
            this.button_Course.Text = "Course";
            this.button_Course.UseVisualStyleBackColor = true;
            this.button_Course.Click += new System.EventHandler(this.button_Course_Click);
            // 
            // button_Student
            // 
            this.button_Student.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Student.Location = new System.Drawing.Point(200, 26);
            this.button_Student.Name = "button_Student";
            this.button_Student.Size = new System.Drawing.Size(140, 63);
            this.button_Student.TabIndex = 1;
            this.button_Student.Text = "Student";
            this.button_Student.UseVisualStyleBackColor = true;
            this.button_Student.Click += new System.EventHandler(this.button_Student_Click);
            // 
            // FrmChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 101);
            this.Controls.Add(this.button_Student);
            this.Controls.Add(this.button_Course);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmChoice";
            this.Text = "Choice";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Course;
        private System.Windows.Forms.Button button_Student;
    }
}