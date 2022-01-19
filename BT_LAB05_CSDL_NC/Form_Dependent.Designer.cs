
namespace BT_LAB05_CSDL_NC
{
    partial class Form_Dependent
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
            this.dataGridView_Dependent = new System.Windows.Forms.DataGridView();
            this.button_Back = new System.Windows.Forms.Button();
            this.groupBox_Function = new System.Windows.Forms.GroupBox();
            this.button_Modify = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.openFileDialog_Dependent = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Dependent)).BeginInit();
            this.groupBox_Function.SuspendLayout();
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
            // dataGridView_Dependent
            // 
            this.dataGridView_Dependent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Dependent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Dependent.Location = new System.Drawing.Point(12, 187);
            this.dataGridView_Dependent.Name = "dataGridView_Dependent";
            this.dataGridView_Dependent.RowHeadersWidth = 62;
            this.dataGridView_Dependent.RowTemplate.Height = 33;
            this.dataGridView_Dependent.Size = new System.Drawing.Size(1086, 387);
            this.dataGridView_Dependent.TabIndex = 1;
            // 
            // button_Back
            // 
            this.button_Back.Location = new System.Drawing.Point(124, 70);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(112, 34);
            this.button_Back.TabIndex = 2;
            this.button_Back.Text = "BACK";
            this.button_Back.UseVisualStyleBackColor = true;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // groupBox_Function
            // 
            this.groupBox_Function.Controls.Add(this.button_Modify);
            this.groupBox_Function.Controls.Add(this.button_Delete);
            this.groupBox_Function.Controls.Add(this.button_Add);
            this.groupBox_Function.Controls.Add(this.button_Back);
            this.groupBox_Function.Location = new System.Drawing.Point(12, 64);
            this.groupBox_Function.Name = "groupBox_Function";
            this.groupBox_Function.Size = new System.Drawing.Size(249, 117);
            this.groupBox_Function.TabIndex = 3;
            this.groupBox_Function.TabStop = false;
            this.groupBox_Function.Text = "FUNCTION";
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
            this.button_Delete.TabIndex = 3;
            this.button_Delete.Text = "DELETE";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // openFileDialog_Dependent
            // 
            this.openFileDialog_Dependent.FileName = "openFileDialog_Dependent";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(403, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 54);
            this.label1.TabIndex = 4;
            this.label1.Text = "DEPENDENT";
            // 
            // Form_Dependent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 586);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox_Function);
            this.Controls.Add(this.dataGridView_Dependent);
            this.Name = "Form_Dependent";
            this.Text = "Dependent";
            this.Load += new System.EventHandler(this.Form_Dependent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Dependent)).EndInit();
            this.groupBox_Function.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.DataGridView dataGridView_Dependent;
        private System.Windows.Forms.Button button_Back;
        private System.Windows.Forms.GroupBox groupBox_Function;
        private System.Windows.Forms.Button button_Modify;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.OpenFileDialog openFileDialog_Dependent;
        private System.Windows.Forms.Label label1;
    }
}