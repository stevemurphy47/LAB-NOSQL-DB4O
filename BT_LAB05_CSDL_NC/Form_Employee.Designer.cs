
namespace BT_LAB05_CSDL_NC
{
    partial class Form_Employee
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
            this.button_Add = new System.Windows.Forms.Button();
            this.dataGridView_Employee = new System.Windows.Forms.DataGridView();
            this.button_Back = new System.Windows.Forms.Button();
            this.button_Manager = new System.Windows.Forms.Button();
            this.button_WorksFor = new System.Windows.Forms.Button();
            this.button_Supervisors = new System.Windows.Forms.Button();
            this.groupBox_Insert = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Modify = new System.Windows.Forms.Button();
            this.openFileDialog_Employee = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Employee)).BeginInit();
            this.groupBox_Insert.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(6, 30);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(124, 34);
            this.button_Add.TabIndex = 1;
            this.button_Add.Text = "ADD";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // dataGridView_Employee
            // 
            this.dataGridView_Employee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Employee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Employee.Location = new System.Drawing.Point(12, 195);
            this.dataGridView_Employee.Name = "dataGridView_Employee";
            this.dataGridView_Employee.RowHeadersWidth = 62;
            this.dataGridView_Employee.RowTemplate.Height = 33;
            this.dataGridView_Employee.Size = new System.Drawing.Size(1252, 346);
            this.dataGridView_Employee.TabIndex = 2;
            // 
            // button_Back
            // 
            this.button_Back.Location = new System.Drawing.Point(136, 70);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(112, 34);
            this.button_Back.TabIndex = 3;
            this.button_Back.Text = "BACK";
            this.button_Back.UseVisualStyleBackColor = true;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // button_Manager
            // 
            this.button_Manager.Location = new System.Drawing.Point(6, 30);
            this.button_Manager.Name = "button_Manager";
            this.button_Manager.Size = new System.Drawing.Size(141, 34);
            this.button_Manager.TabIndex = 4;
            this.button_Manager.Text = "MANAGER";
            this.button_Manager.UseVisualStyleBackColor = true;
            this.button_Manager.Click += new System.EventHandler(this.button_Manager_Click);
            // 
            // button_WorksFor
            // 
            this.button_WorksFor.Location = new System.Drawing.Point(6, 70);
            this.button_WorksFor.Name = "button_WorksFor";
            this.button_WorksFor.Size = new System.Drawing.Size(141, 34);
            this.button_WorksFor.TabIndex = 5;
            this.button_WorksFor.Text = "WORKSFOR";
            this.button_WorksFor.UseVisualStyleBackColor = true;
            this.button_WorksFor.Click += new System.EventHandler(this.button_WorksFor_Click);
            // 
            // button_Supervisors
            // 
            this.button_Supervisors.Location = new System.Drawing.Point(153, 30);
            this.button_Supervisors.Name = "button_Supervisors";
            this.button_Supervisors.Size = new System.Drawing.Size(141, 34);
            this.button_Supervisors.TabIndex = 6;
            this.button_Supervisors.Text = "SUPERVISORS";
            this.button_Supervisors.UseVisualStyleBackColor = true;
            this.button_Supervisors.Click += new System.EventHandler(this.button_Supervisors_Click);
            // 
            // groupBox_Insert
            // 
            this.groupBox_Insert.Controls.Add(this.button_Supervisors);
            this.groupBox_Insert.Controls.Add(this.button_Manager);
            this.groupBox_Insert.Controls.Add(this.button_WorksFor);
            this.groupBox_Insert.Location = new System.Drawing.Point(274, 75);
            this.groupBox_Insert.Name = "groupBox_Insert";
            this.groupBox_Insert.Size = new System.Drawing.Size(304, 114);
            this.groupBox_Insert.TabIndex = 7;
            this.groupBox_Insert.TabStop = false;
            this.groupBox_Insert.Text = "INSERT";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_Back);
            this.groupBox1.Controls.Add(this.button_Add);
            this.groupBox1.Controls.Add(this.button_Delete);
            this.groupBox1.Controls.Add(this.button_Modify);
            this.groupBox1.Location = new System.Drawing.Point(12, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 114);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FUNCTION";
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(136, 30);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(112, 34);
            this.button_Delete.TabIndex = 4;
            this.button_Delete.Text = "DELETE";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Modify
            // 
            this.button_Modify.Location = new System.Drawing.Point(6, 70);
            this.button_Modify.Name = "button_Modify";
            this.button_Modify.Size = new System.Drawing.Size(124, 34);
            this.button_Modify.TabIndex = 5;
            this.button_Modify.Text = "MODIFY";
            this.button_Modify.UseVisualStyleBackColor = true;
            this.button_Modify.Click += new System.EventHandler(this.button_Modify_Click);
            // 
            // openFileDialog_Employee
            // 
            this.openFileDialog_Employee.FileName = "openFileDialog_Employee";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(489, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 54);
            this.label1.TabIndex = 9;
            this.label1.Text = "EMPLOYEE";
            // 
            // Form_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 553);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox_Insert);
            this.Controls.Add(this.dataGridView_Employee);
            this.Name = "Form_Employee";
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Form_Employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Employee)).EndInit();
            this.groupBox_Insert.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.DataGridView dataGridView_Employee;
        private System.Windows.Forms.Button button_Back;
        private System.Windows.Forms.Button button_Manager;
        private System.Windows.Forms.Button button_WorksFor;
        private System.Windows.Forms.Button button_Supervisors;
        private System.Windows.Forms.GroupBox groupBox_Insert;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Modify;
        private System.Windows.Forms.OpenFileDialog openFileDialog_Employee;
        private System.Windows.Forms.Label label1;
    }
}