
namespace BT_LAB05_CSDL_NC
{
    partial class Form_WorksOn
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
            this.dataGridView_WorksOn = new System.Windows.Forms.DataGridView();
            this.button_Modify = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.groupBox_Function = new System.Windows.Forms.GroupBox();
            this.openFileDialog_WorksOn = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_WorksOn)).BeginInit();
            this.groupBox_Function.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(6, 30);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(131, 34);
            this.button_Add.TabIndex = 0;
            this.button_Add.Text = "ADD";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Back
            // 
            this.button_Back.Location = new System.Drawing.Point(143, 70);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(130, 34);
            this.button_Back.TabIndex = 1;
            this.button_Back.Text = "BACK";
            this.button_Back.UseVisualStyleBackColor = true;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // dataGridView_WorksOn
            // 
            this.dataGridView_WorksOn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_WorksOn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_WorksOn.Location = new System.Drawing.Point(12, 203);
            this.dataGridView_WorksOn.Name = "dataGridView_WorksOn";
            this.dataGridView_WorksOn.RowHeadersWidth = 62;
            this.dataGridView_WorksOn.RowTemplate.Height = 33;
            this.dataGridView_WorksOn.Size = new System.Drawing.Size(1151, 379);
            this.dataGridView_WorksOn.TabIndex = 2;
            // 
            // button_Modify
            // 
            this.button_Modify.Location = new System.Drawing.Point(6, 70);
            this.button_Modify.Name = "button_Modify";
            this.button_Modify.Size = new System.Drawing.Size(131, 34);
            this.button_Modify.TabIndex = 3;
            this.button_Modify.Text = "MODIFY";
            this.button_Modify.UseVisualStyleBackColor = true;
            this.button_Modify.Click += new System.EventHandler(this.button_Modify_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(143, 30);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(130, 34);
            this.button_Delete.TabIndex = 4;
            this.button_Delete.Text = "DELETE";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // groupBox_Function
            // 
            this.groupBox_Function.Controls.Add(this.button_Add);
            this.groupBox_Function.Controls.Add(this.button_Modify);
            this.groupBox_Function.Controls.Add(this.button_Back);
            this.groupBox_Function.Controls.Add(this.button_Delete);
            this.groupBox_Function.Location = new System.Drawing.Point(12, 82);
            this.groupBox_Function.Name = "groupBox_Function";
            this.groupBox_Function.Size = new System.Drawing.Size(281, 115);
            this.groupBox_Function.TabIndex = 5;
            this.groupBox_Function.TabStop = false;
            this.groupBox_Function.Text = "FUNCTION";
            // 
            // openFileDialog_WorksOn
            // 
            this.openFileDialog_WorksOn.FileName = "openFileDialog_WorksOn";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(435, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 54);
            this.label1.TabIndex = 6;
            this.label1.Text = "WORKS ON";
            // 
            // Form_WorksOn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 594);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox_Function);
            this.Controls.Add(this.dataGridView_WorksOn);
            this.Name = "Form_WorksOn";
            this.Text = "WorksOn";
            this.Load += new System.EventHandler(this.Form_WorksOn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_WorksOn)).EndInit();
            this.groupBox_Function.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Back;
        private System.Windows.Forms.DataGridView dataGridView_WorksOn;
        private System.Windows.Forms.Button button_Modify;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.GroupBox groupBox_Function;
        private System.Windows.Forms.OpenFileDialog openFileDialog_WorksOn;
        private System.Windows.Forms.Label label1;
    }
}