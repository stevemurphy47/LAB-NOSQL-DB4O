
namespace BT_LAB05_CSDL_NC
{
    partial class Form_Program
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
            this.button_Employee = new System.Windows.Forms.Button();
            this.button_Dependent = new System.Windows.Forms.Button();
            this.button_Department = new System.Windows.Forms.Button();
            this.button_Project = new System.Windows.Forms.Button();
            this.button_WorksOn = new System.Windows.Forms.Button();
            this.button_Query = new System.Windows.Forms.Button();
            this.button_EditDatFile = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Employee
            // 
            this.button_Employee.Location = new System.Drawing.Point(8, 175);
            this.button_Employee.Name = "button_Employee";
            this.button_Employee.Size = new System.Drawing.Size(134, 34);
            this.button_Employee.TabIndex = 0;
            this.button_Employee.Text = "EMPLOYEE";
            this.button_Employee.UseVisualStyleBackColor = true;
            this.button_Employee.Click += new System.EventHandler(this.button_Employee_Click);
            // 
            // button_Dependent
            // 
            this.button_Dependent.Location = new System.Drawing.Point(8, 215);
            this.button_Dependent.Name = "button_Dependent";
            this.button_Dependent.Size = new System.Drawing.Size(134, 34);
            this.button_Dependent.TabIndex = 1;
            this.button_Dependent.Text = "DEPENDENT";
            this.button_Dependent.UseVisualStyleBackColor = true;
            this.button_Dependent.Click += new System.EventHandler(this.button_Dependent_Click);
            // 
            // button_Department
            // 
            this.button_Department.Location = new System.Drawing.Point(148, 175);
            this.button_Department.Name = "button_Department";
            this.button_Department.Size = new System.Drawing.Size(149, 34);
            this.button_Department.TabIndex = 2;
            this.button_Department.Text = "DEPARTMENT";
            this.button_Department.UseVisualStyleBackColor = true;
            this.button_Department.Click += new System.EventHandler(this.button_Department_Click);
            // 
            // button_Project
            // 
            this.button_Project.Location = new System.Drawing.Point(148, 215);
            this.button_Project.Name = "button_Project";
            this.button_Project.Size = new System.Drawing.Size(149, 34);
            this.button_Project.TabIndex = 3;
            this.button_Project.Text = "PROJECT";
            this.button_Project.UseVisualStyleBackColor = true;
            this.button_Project.Click += new System.EventHandler(this.button_Project_Click);
            // 
            // button_WorksOn
            // 
            this.button_WorksOn.Location = new System.Drawing.Point(303, 175);
            this.button_WorksOn.Name = "button_WorksOn";
            this.button_WorksOn.Size = new System.Drawing.Size(149, 34);
            this.button_WorksOn.TabIndex = 4;
            this.button_WorksOn.Text = "WORKSON";
            this.button_WorksOn.UseVisualStyleBackColor = true;
            this.button_WorksOn.Click += new System.EventHandler(this.button_WorksOn_Click);
            // 
            // button_Query
            // 
            this.button_Query.Location = new System.Drawing.Point(303, 215);
            this.button_Query.Name = "button_Query";
            this.button_Query.Size = new System.Drawing.Size(149, 34);
            this.button_Query.TabIndex = 5;
            this.button_Query.Text = "QUERY";
            this.button_Query.UseVisualStyleBackColor = true;
            this.button_Query.Click += new System.EventHandler(this.button_Query_Click);
            // 
            // button_EditDatFile
            // 
            this.button_EditDatFile.Location = new System.Drawing.Point(8, 255);
            this.button_EditDatFile.Name = "button_EditDatFile";
            this.button_EditDatFile.Size = new System.Drawing.Size(218, 34);
            this.button_EditDatFile.TabIndex = 6;
            this.button_EditDatFile.Text = "EDIT DAT FILE";
            this.button_EditDatFile.UseVisualStyleBackColor = true;
            this.button_EditDatFile.Click += new System.EventHandler(this.button_EditDatFile_Click);
            // 
            // button_Exit
            // 
            this.button_Exit.Location = new System.Drawing.Point(232, 255);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(220, 34);
            this.button_Exit.TabIndex = 7;
            this.button_Exit.Text = "EXIT";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(26, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 54);
            this.label1.TabIndex = 8;
            this.label1.Text = "Elmasri-Navathe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(107, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 54);
            this.label2.TabIndex = 9;
            this.label2.Text = "COMPANY";
            // 
            // Form_Program
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 302);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.button_EditDatFile);
            this.Controls.Add(this.button_Query);
            this.Controls.Add(this.button_WorksOn);
            this.Controls.Add(this.button_Project);
            this.Controls.Add(this.button_Department);
            this.Controls.Add(this.button_Dependent);
            this.Controls.Add(this.button_Employee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_Program";
            this.Text = "Program";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Employee;
        private System.Windows.Forms.Button button_Dependent;
        private System.Windows.Forms.Button button_Department;
        private System.Windows.Forms.Button button_Project;
        private System.Windows.Forms.Button button_WorksOn;
        private System.Windows.Forms.Button button_Query;
        private System.Windows.Forms.Button button_EditDatFile;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}