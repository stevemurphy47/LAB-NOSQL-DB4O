using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT_LAB05_CSDL_NC
{
    public partial class Form_DatFile : Form
    {
        public Form_DatFile()
        {
            InitializeComponent();
        }

        string file = null;

        //Load
        private void Form_DatFile_Load(object sender, EventArgs e)
        {
            richTextBox_DatFile.ReadOnly = true;
        }
        //Button
        private void button_Browser_Click(object sender, EventArgs e)
        {
            richTextBox_DatFile.ReadOnly = false;
            if (openFileDialog_DatFile.ShowDialog() == DialogResult.OK)
            {
                openFileDialog_DatFile.InitialDirectory = @"Data\";
                file = openFileDialog_DatFile.InitialDirectory;
                switch (Path.GetFileName(file))
                {
                    case "Employee.dat":
                        label_DatFile.Text = "EMPLOYEE";
                        break;
                    case "Dependents.dat":
                        label_DatFile.Text = "DEPENDENT";
                        break;
                    case "Department.dat":
                        label_DatFile.Text = "DEPARTMENT";
                        break;
                    case "Project.dat":
                        label_DatFile.Text = "PROJECT";
                        break;
                    case "WorksOn.dat":
                        label_DatFile.Text = "WORKS ON";
                        break;
                }
                richTextBox_DatFile.Text = File.ReadAllText(file);
            }
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            richTextBox_DatFile.ReadOnly = true;
            if (file == null)
            {
                MessageBox.Show("Pleas choose a file");
            }
            else
            {
                FileStream fs = new FileStream(file, FileMode.Open);
                TextWriter txt = new StreamWriter(fs);
                txt.Write(richTextBox_DatFile.Text);
                MessageBox.Show("Save file succeed");
                txt.Close();
                fs.Close();
            }
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Program program = new Form_Program();
            program.ShowDialog();
            this.Close();
        }
    }
}
