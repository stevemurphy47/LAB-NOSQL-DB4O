
namespace BT_LAB05_CSDL_NC
{
    partial class Form_Department
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
            this.button_Back = new System.Windows.Forms.Button();
            this.dataGridView_Department = new System.Windows.Forms.DataGridView();
            this.buttonManager = new System.Windows.Forms.Button();
            this.button_Projects = new System.Windows.Forms.Button();
            this.button_WorksFor = new System.Windows.Forms.Button();
            this.button_Modify = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.groupBox_Function = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.openFileDialog_Department = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Department)).BeginInit();
            this.groupBox_Function.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(6, 30);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(126, 34);
            this.button_Add.TabIndex = 0;
            this.button_Add.Text = "ADD";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Back
            // 
            this.button_Back.Location = new System.Drawing.Point(138, 70);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(105, 34);
            this.button_Back.TabIndex = 1;
            this.button_Back.Text = "BACK";
            this.button_Back.UseVisualStyleBackColor = true;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // dataGridView_Department
            // 
            this.dataGridView_Department.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Department.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Department.Location = new System.Drawing.Point(12, 194);
            this.dataGridView_Department.Name = "dataGridView_Department";
            this.dataGridView_Department.RowHeadersWidth = 62;
            this.dataGridView_Department.RowTemplate.Height = 33;
            this.dataGridView_Department.Size = new System.Drawing.Size(1228, 376);
            this.dataGridView_Department.TabIndex = 2;
            // 
            // buttonManager
            // 
            this.buttonManager.Location = new System.Drawing.Point(6, 29);
            this.buttonManager.Name = "buttonManager";
            this.buttonManager.Size = new System.Drawing.Size(126, 34);
            this.buttonManager.TabIndex = 4;
            this.buttonManager.Text = "MANAGER";
            this.buttonManager.UseVisualStyleBackColor = true;
            this.buttonManager.Click += new System.EventHandler(this.buttonManager_Click);
            // 
            // button_Projects
            // 
            this.button_Projects.Location = new System.Drawing.Point(6, 69);
            this.button_Projects.Name = "button_Projects";
            this.button_Projects.Size = new System.Drawing.Size(126, 34);
            this.button_Projects.TabIndex = 5;
            this.button_Projects.Text = "PROJECTS";
            this.button_Projects.UseVisualStyleBackColor = true;
            this.button_Projects.Click += new System.EventHandler(this.button_Projects_Click);
            // 
            // button_WorksFor
            // 
            this.button_WorksFor.Location = new System.Drawing.Point(138, 30);
            this.button_WorksFor.Name = "button_WorksFor";
            this.button_WorksFor.Size = new System.Drawing.Size(126, 34);
            this.button_WorksFor.TabIndex = 6;
            this.button_WorksFor.Text = "WORKSFOR";
            this.button_WorksFor.UseVisualStyleBackColor = true;
            this.button_WorksFor.Click += new System.EventHandler(this.button_WorksFor_Click);
            // 
            // button_Modify
            // 
            this.button_Modify.Location = new System.Drawing.Point(6, 70);
            this.button_Modify.Name = "button_Modify";
            this.button_Modify.Size = new System.Drawing.Size(126, 34);
            this.button_Modify.TabIndex = 7;
            this.button_Modify.Text = "MODIFY";
            this.button_Modify.UseVisualStyleBackColor = true;
            this.button_Modify.Click += new System.EventHandler(this.button_Modify_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(138, 30);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(105, 34);
            this.button_Delete.TabIndex = 8;
            this.button_Delete.Text = "DELETE";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // groupBox_Function
            // 
            this.groupBox_Function.Controls.Add(this.button_Add);
            this.groupBox_Function.Controls.Add(this.button_Modify);
            this.groupBox_Function.Controls.Add(this.button_Delete);
            this.groupBox_Function.Controls.Add(this.button_Back);
            this.groupBox_Function.Location = new System.Drawing.Point(12, 73);
            this.groupBox_Function.Name = "groupBox_Function";
            this.groupBox_Function.Size = new System.Drawing.Size(252, 115);
            this.groupBox_Function.TabIndex = 9;
            this.groupBox_Function.TabStop = false;
            this.groupBox_Function.Text = "FUNCTION";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonManager);
            this.groupBox1.Controls.Add(this.button_Projects);
            this.groupBox1.Controls.Add(this.button_WorksFor);
            this.groupBox1.Location = new System.Drawing.Point(270, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 115);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INSERT";
            // 
            // openFileDialog_Department
            // 
            this.openFileDialog_Department.FileName = "openFileDialog_Department";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(434, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 54);
            this.label1.TabIndex = 11;
            this.label1.Text = "DEPARTMENT";
            // 
            // Form_Department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 582);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox_Function);
            this.Controls.Add(this.dataGridView_Department);
            this.Name = "Form_Department";
            this.Text = "Department";
            this.Load += new System.EventHandler(this.Form_Department_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Department)).EndInit();
            this.groupBox_Function.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Back;
        private System.Windows.Forms.DataGridView dataGridView_Department;
        private System.Windows.Forms.Button buttonManager;
        private System.Windows.Forms.Button button_Projects;
        private System.Windows.Forms.Button button_WorksFor;
        private System.Windows.Forms.Button button_Modify;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.GroupBox groupBox_Function;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog_Department;
        private System.Windows.Forms.Label label1;
    }
}