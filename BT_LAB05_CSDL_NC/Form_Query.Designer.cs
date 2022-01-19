
namespace BT_LAB05_CSDL_NC
{
    partial class Form_Query
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
            this.groupBox_Query = new System.Windows.Forms.GroupBox();
            this.button_HostonProject = new System.Windows.Forms.Button();
            this.button_Male = new System.Windows.Forms.Button();
            this.button_TDepartmment = new System.Windows.Forms.Button();
            this.button_ANameProject = new System.Windows.Forms.Button();
            this.dataGridView_Query = new System.Windows.Forms.DataGridView();
            this.button_Back = new System.Windows.Forms.Button();
            this.groupBox_Function = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_Query.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Query)).BeginInit();
            this.groupBox_Function.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Query
            // 
            this.groupBox_Query.Controls.Add(this.button_HostonProject);
            this.groupBox_Query.Controls.Add(this.button_Male);
            this.groupBox_Query.Controls.Add(this.button_TDepartmment);
            this.groupBox_Query.Controls.Add(this.button_ANameProject);
            this.groupBox_Query.Location = new System.Drawing.Point(12, 66);
            this.groupBox_Query.Name = "groupBox_Query";
            this.groupBox_Query.Size = new System.Drawing.Size(332, 114);
            this.groupBox_Query.TabIndex = 10;
            this.groupBox_Query.TabStop = false;
            this.groupBox_Query.Text = "QUERY";
            // 
            // button_HostonProject
            // 
            this.button_HostonProject.Location = new System.Drawing.Point(160, 30);
            this.button_HostonProject.Name = "button_HostonProject";
            this.button_HostonProject.Size = new System.Drawing.Size(167, 34);
            this.button_HostonProject.TabIndex = 6;
            this.button_HostonProject.Text = "HOSTON PROJECT";
            this.button_HostonProject.UseVisualStyleBackColor = true;
            this.button_HostonProject.Click += new System.EventHandler(this.button_HostonProject_Click);
            // 
            // button_Male
            // 
            this.button_Male.Location = new System.Drawing.Point(6, 30);
            this.button_Male.Name = "button_Male";
            this.button_Male.Size = new System.Drawing.Size(148, 34);
            this.button_Male.TabIndex = 1;
            this.button_Male.Text = "MALE";
            this.button_Male.UseVisualStyleBackColor = true;
            this.button_Male.Click += new System.EventHandler(this.button_Male_Click);
            // 
            // button_TDepartmment
            // 
            this.button_TDepartmment.Location = new System.Drawing.Point(6, 70);
            this.button_TDepartmment.Name = "button_TDepartmment";
            this.button_TDepartmment.Size = new System.Drawing.Size(148, 34);
            this.button_TDepartmment.TabIndex = 4;
            this.button_TDepartmment.Text = "T DEPARTMENT";
            this.button_TDepartmment.UseVisualStyleBackColor = true;
            this.button_TDepartmment.Click += new System.EventHandler(this.button_TDepartmment_Click);
            // 
            // button_ANameProject
            // 
            this.button_ANameProject.Location = new System.Drawing.Point(160, 70);
            this.button_ANameProject.Name = "button_ANameProject";
            this.button_ANameProject.Size = new System.Drawing.Size(167, 34);
            this.button_ANameProject.TabIndex = 5;
            this.button_ANameProject.Text = "A NAME PROJECT";
            this.button_ANameProject.UseVisualStyleBackColor = true;
            this.button_ANameProject.Click += new System.EventHandler(this.button_ANameProject_Click);
            // 
            // dataGridView_Query
            // 
            this.dataGridView_Query.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Query.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Query.Location = new System.Drawing.Point(12, 186);
            this.dataGridView_Query.Name = "dataGridView_Query";
            this.dataGridView_Query.RowHeadersWidth = 62;
            this.dataGridView_Query.RowTemplate.Height = 33;
            this.dataGridView_Query.Size = new System.Drawing.Size(776, 308);
            this.dataGridView_Query.TabIndex = 11;
            // 
            // button_Back
            // 
            this.button_Back.Location = new System.Drawing.Point(6, 30);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(148, 34);
            this.button_Back.TabIndex = 7;
            this.button_Back.Text = "BACK";
            this.button_Back.UseVisualStyleBackColor = true;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // groupBox_Function
            // 
            this.groupBox_Function.Controls.Add(this.button_Back);
            this.groupBox_Function.Location = new System.Drawing.Point(350, 66);
            this.groupBox_Function.Name = "groupBox_Function";
            this.groupBox_Function.Size = new System.Drawing.Size(159, 114);
            this.groupBox_Function.TabIndex = 12;
            this.groupBox_Function.TabStop = false;
            this.groupBox_Function.Text = "Function";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(310, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 54);
            this.label1.TabIndex = 13;
            this.label1.Text = "QUERY";
            // 
            // Form_Query
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 506);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox_Function);
            this.Controls.Add(this.dataGridView_Query);
            this.Controls.Add(this.groupBox_Query);
            this.Name = "Form_Query";
            this.Text = "Query";
            this.Load += new System.EventHandler(this.Form_Query_Load);
            this.groupBox_Query.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Query)).EndInit();
            this.groupBox_Function.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Query;
        private System.Windows.Forms.Button button_HostonProject;
        private System.Windows.Forms.Button button_Male;
        private System.Windows.Forms.Button button_TDepartmment;
        private System.Windows.Forms.Button button_ANameProject;
        private System.Windows.Forms.DataGridView dataGridView_Query;
        private System.Windows.Forms.Button button_Back;
        private System.Windows.Forms.GroupBox groupBox_Function;
        private System.Windows.Forms.Label label1;
    }
}