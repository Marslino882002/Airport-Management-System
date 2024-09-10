using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace Airport
{
public partial class SearchandModify : Form
{

 private int GetHashValue(int searchId)////>>>>>>>>>>"Hash Funcation"
   {
            // Implement your hash function logic here
            // Calculate the hash value based on the search ID

            // Example of a simple hash function using modulo operation
            int hashValue = searchId % Info.rec_size;

            return hashValue;
   }



        public SearchandModify()
        {
            InitializeComponent();
        }

        private void SearchandModify_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            // Get the ID of the record to modify
            if (!int.TryParse(textBox1.Text.Trim(), out int modifyId))
            {
                MessageBox.Show("Please enter a valid ID to modify.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Open the file in read-write mode
                using (BinaryReader br = new BinaryReader(File.Open(Info.filename, FileMode.Open, FileAccess.ReadWrite)))
                {
                    int num_of_records = (int)br.BaseStream.Length / Info.rec_size;
                    bool recordFound = false;

                    // Loop through each record in the file
                    for (int i = 0; i < num_of_records; i++)
                    {
                        // Move the file pointer to the beginning of the current record
                        br.BaseStream.Seek(i * Info.rec_size, SeekOrigin.Begin);

                        // Read the ID from the record
                        int id = br.ReadInt32();

                        // Compare the ID with the modify ID
                        if (id == modifyId)
                        {
                            // Move the file pointer back to the beginning of the current record
                            br.BaseStream.Seek(i * Info.rec_size, SeekOrigin.Begin);

                            // Write the modified record data
                            using (BinaryWriter bw = new BinaryWriter(br.BaseStream))
                            {
                                // Update the record fields with the modified values
                                bw.Write(modifyId);
                                bw.Write(textBox5.Text.Trim());
                                bw.Write(textBox3.Text.Trim());
                                bw.Write(int.Parse(textBox2.Text.Trim()));
                                bw.Write(textBox4.Text.Trim());
                                // Write the modified image data here if applicable
                                // bw.Write(imageData);
                            }

                            recordFound = true;
                            break;
                        }
                    }

                    // Check if a matching record was found
                    if (!recordFound)
                    {
                        MessageBox.Show("No record found with the specified ID.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Record modified successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("An error occurred while accessing the file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

 }

        private void SearchButton_Click(object sender, EventArgs e)
        {



            // Get the search ID from the text box

            //out keywoard meaning 
            if (!int.TryParse(textBox1.Text.Trim(), out int searchId))
            {
                MessageBox.Show("Please enter a valid ID to search.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

   try
            {

                /// Calculate the hash value based on the search ID
                int hashValue = GetHashValue(searchId);


                using (BinaryReader br = new BinaryReader(File.Open(Info.filename, FileMode.Open, FileAccess.Read)))
                {
                    int num_of_records = (int)br.BaseStream.Length / Info.rec_size;
                    bool recordFound = false;

                    // Loop through each record in the file
                    for (int i = 0; i < num_of_records; i++)
                    {
                        // Move the file pointer to the beginning of the current record
                        //calculate the length of the current Recodrd and stay at his start
                      br.BaseStream.Seek(i * Info.rec_size, SeekOrigin.Begin);

                        // Read the ID from the record
                        int id = br.ReadInt32();

                        // Compare the ID with the search ID
                        if (id == searchId)
                        {
                            // Display the record details in the text boxes
                            textBox1.Text = id.ToString();
                            textBox5.Text = br.ReadString();
                            textBox3.Text = br.ReadString();
                            textBox2.Text = br.ReadInt32().ToString();
                            textBox4.Text = br.ReadString();

                            //// Read the image data from the record
                            //byte[] imageData = br.ReadBytes(Info.image_size);

                            //// Display the image in the PictureBox control
                            //using (MemoryStream ms = new MemoryStream(imageData))
                            //{
                            //    pictureBox5.Image = Image.FromStream(ms);
                            //}




                            recordFound = true;
                            break;
                        }
                    }

                    // Check if a matching record was found
                    if (!recordFound)
                    {
                        MessageBox.Show("No record found with the specified ID.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("An error occurred while accessing the file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {



        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 targetform = new Form3();
            this.Hide();
            targetform.Show();

        }
    }
}
