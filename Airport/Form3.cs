using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;

namespace Airport
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            this.Hide();
            new InsertForm().Show();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(Info.filename))
            {
          MessageBox.Show("Please write a file name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Info.filename = "F:\\" + textBox1.Text + ".txt";
            File.Delete(Info.filename);
            MessageBox.Show("File is Deleted ");
            textBox1.Clear();
            errorLabel.Visible = false;


        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {

            Info.filename = "F:\\" + textBox1.Text + ".txt"; 
            // Get the file name from user if I insert file1 in FilenameTextBox ,filename = E:\\file1.txt

 if (!File.Exists(Info.filename)) // if the file does not exists
            {
                File.Create(Info.filename).Close();
                // We Should include using System.IO;
                MessageBox.Show("File is Created Successfully", "Note",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (string.IsNullOrEmpty(Info.filename))
            {
                MessageBox.Show("Please write a file name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else
                errorLabel.Visible = true; // Lable2 : visible = false 

        }



        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteBtn.Visible = true; // or write the same code of create button
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateBtn.Visible = true;
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Hide();
            new DisplayForm().Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new InsertForm().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DisplayForm f1 = new DisplayForm();
            this.Hide();
            f1.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SearchandModify().Show();






        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SearchandModify().Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void errorLabel_Click(object sender, EventArgs e)
        {
           
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
       OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select File to Copy";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string sourceFilePath = openFileDialog.FileName;

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Title = "Save Copied File As";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string destinationFilePath = saveFileDialog.FileName;

                    try
                    {
                        File.Copy(sourceFilePath, destinationFilePath, true);
                        MessageBox.Show("File copied successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while copying the file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
