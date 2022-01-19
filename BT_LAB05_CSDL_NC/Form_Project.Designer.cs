
namespace BT_LAB05_CSDL_NC
{
    partial class Form_Project
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
            this.dataGridView_Project = new System.Windows.Forms.DataGridView();
            this.button_ControledBy = new System.Windows.Forms.Button();
            this.button_Modify = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox_Insert = new System.Windows.Forms.GroupBox();
            this.openFileDialog_Project = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Project)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox_Insert.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(6, 30);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(112, 34);
            this.button_Add.TabIndex = 0;
            this.button_Add.Text = "ADD";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Back
            // 
            this.button_Back.Location = new System.Drawing.Point(124, 70);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(112, 34);
            this.button_Back.TabIndex = 1;
            this.button_Back.Text = "BACK";
            this.button_Back.UseVisualStyleBackColor = true;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // dataGridView_Project
            // 
            this.dataGridView_Project.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Project.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Project.Location = new System.Drawing.Point(12, 192);
            this.dataGridView_Project.Name = "dataGridView_Project";
            this.dataGridView_Project.RowHeadersWidth = 62;
            this.dataGridView_Project.RowTemplate.Height = 33;
            this.dataGridView_Project.Size = new System.Drawing.Size(1234, 389);
            this.dataGridView_Project.TabIndex = 2;
            // 
            // button_ControledBy
            // 
            this.button_ControledBy.Location = new System.Drawing.Point(6, 30);
            this.button_ControledBy.Name = "button_ControledBy";
            this.button_ControledBy.Size = new System.Drawing.Size(150, 34);
            this.button_ControledBy.TabIndex = 3;
            this.button_ControledBy.Text = "CONTROLED_BY";
            this.button_ControledBy.UseVisualStyleBackColor = true;
            this.button_ControledBy.Click += new System.EventHandler(this.button_ControledBy_Click);
            // 
            // button_Modify
            // 
            this.button_Modify.Location = new System.Drawing.Point(6, 70);
            this.button_Modify.Name = "button_Modify";
            this.button_Modify.Size = new System.Drawing.Size(112, 34);
            this.button_Modify.TabIndex = 4;
            this.button_Modify.Text = "MODIFY";
            this.button_Modify.UseVisualStyleBackColor = true;
            this.button_Modify.Click += new System.EventHandler(this.button_Modify_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(124, 30);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(112, 34);
            this.button_Delete.TabIndex = 5;
            this.button_Delete.Text = "DELETE";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_Add);
            this.groupBox1.Controls.Add(this.button_Modify);
            this.groupBox1.Controls.Add(this.button_Delete);
            this.groupBox1.Controls.Add(this.button_Back);
            this.groupBox1.Location = new System.Drawing.Point(12, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 118);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FUNCTION";
            // 
            // groupBox_Insert
            // 
            this.groupBox_Insert.Controls.Add(this.button_ControledBy);
            this.groupBox_Insert.Location = new System.Drawing.Point(264, 68);
            this.groupBox_Insert.Name = "groupBox_Insert";
            this.groupBox_Insert.Size = new System.Drawing.Size(163, 118);
            this.groupBox_Insert.TabIndex = 7;
            this.groupBox_Insert.TabStop = false;
            this.groupBox_Insert.Text = "INSERT";
            // 
            // openFileDialog_Project
            // 
            this.openFileDialog_Project.FileName = "openFileDialog_Project";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(554, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 54);
            this.label1.TabIndex = 8;
            this.label1.Text = "PROJECT";
            // 
            // Form_Project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 593);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox_Insert);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView_Project);
            this.Name = "Form_Project";
            this.Text = "Project";
            this.Load += new System.EventHandler(this.Form_Project_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Project)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox_Insert.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Back;
        private System.Windows.Forms.DataGridView dataGridView_Project;
        private System.Windows.Forms.Button button_ControledBy;
        private System.Windows.Forms.Button button_Modify;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox_Insert;
        private System.Windows.Forms.OpenFileDialog openFileDialog_Project;
        private System.Windows.Forms.Label label1;
    }
}