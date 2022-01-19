
namespace BT_LAB05_CSDL_NC
{
    partial class Form_DatFile
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
            this.richTextBox_DatFile = new System.Windows.Forms.RichTextBox();
            this.button_Browser = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_Back = new System.Windows.Forms.Button();
            this.openFileDialog_DatFile = new System.Windows.Forms.OpenFileDialog();
            this.label_DatFile = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox_DatFile
            // 
            this.richTextBox_DatFile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox_DatFile.BackColor = System.Drawing.SystemColors.WindowText;
            this.richTextBox_DatFile.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox_DatFile.ForeColor = System.Drawing.SystemColors.Window;
            this.richTextBox_DatFile.Location = new System.Drawing.Point(12, 79);
            this.richTextBox_DatFile.Name = "richTextBox_DatFile";
            this.richTextBox_DatFile.Size = new System.Drawing.Size(776, 319);
            this.richTextBox_DatFile.TabIndex = 0;
            this.richTextBox_DatFile.Text = "";
            // 
            // button_Browser
            // 
            this.button_Browser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_Browser.Location = new System.Drawing.Point(84, 404);
            this.button_Browser.Name = "button_Browser";
            this.button_Browser.Size = new System.Drawing.Size(112, 34);
            this.button_Browser.TabIndex = 1;
            this.button_Browser.Text = "BROWSER";
            this.button_Browser.UseVisualStyleBackColor = true;
            this.button_Browser.Click += new System.EventHandler(this.button_Browser_Click);
            // 
            // button_Save
            // 
            this.button_Save.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_Save.Location = new System.Drawing.Point(342, 404);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(112, 34);
            this.button_Save.TabIndex = 2;
            this.button_Save.Text = "SAVE";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // button_Back
            // 
            this.button_Back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Back.Location = new System.Drawing.Point(590, 404);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(112, 34);
            this.button_Back.TabIndex = 3;
            this.button_Back.Text = "BACK";
            this.button_Back.UseVisualStyleBackColor = true;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // openFileDialog_DatFile
            // 
            this.openFileDialog_DatFile.FileName = "openFileDialog_DatFile";
            // 
            // label_DatFile
            // 
            this.label_DatFile.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_DatFile.AutoSize = true;
            this.label_DatFile.Font = new System.Drawing.Font("Showcard Gothic", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_DatFile.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label_DatFile.Location = new System.Drawing.Point(296, 9);
            this.label_DatFile.Name = "label_DatFile";
            this.label_DatFile.Size = new System.Drawing.Size(204, 54);
            this.label_DatFile.TabIndex = 4;
            this.label_DatFile.Text = "Dat File";
            // 
            // Form_DatFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_DatFile);
            this.Controls.Add(this.button_Back);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.button_Browser);
            this.Controls.Add(this.richTextBox_DatFile);
            this.Name = "Form_DatFile";
            this.Text = "Dat File";
            this.Load += new System.EventHandler(this.Form_DatFile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox_DatFile;
        private System.Windows.Forms.Button button_Browser;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_Back;
        private System.Windows.Forms.OpenFileDialog openFileDialog_DatFile;
        private System.Windows.Forms.Label label_DatFile;
    }
}