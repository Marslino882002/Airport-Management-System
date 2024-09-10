using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;

namespace Airport
{
    public partial class DisplayForm : Form
    {
        private BinaryReader br;
        public DisplayForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {


            Form3 targetform = new Form3();
            this.Hide();
            targetform.Show();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            displayFNtextBox.Text = Info.filename;

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           BinaryReader br = new BinaryReader(File.Open(Info.filename,
      FileMode.Open, FileAccess.Read));
            int num_of_records = (int)br.BaseStream.Length / Info.rec_size;
            if (num_of_records > 0) // If The file Not Empty
            {
                button1.Text = "Next";// Change the Button Text

                br.BaseStream.Seek(Info.count, SeekOrigin.Begin);
                // Move to Specific Position in a File
                textBox1.Text = br.ReadInt32().ToString();
                // Read ID and display it in the ID text Box
                textBox4.Text = br.ReadString(); // Read Name
                textBox2.Text = br.ReadString(); // Read Tel
                textBox5.Text = br.ReadInt32().ToString(); // Read Year
                textBox3.Text = br.ReadString(); // Read Gender

                 NumOfRecLabel.Text = num_of_records.ToString();

                FileSizeLabel.Text = br.BaseStream.Length.ToString()
                    ;
                if ((Info.count / Info.rec_size) >= (num_of_records - 1))
                    // If I reach the End of file , Go to the Beginning of file
                    Info.count = 0;
                else
                    Info.count += Info.rec_size;


            }
            else MessageBox.Show("Empty File");
            br.Close();

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Get the values from the text boxes
            int id;
            string name;
            string tel;
            int year;
            string gender;

            if (!int.TryParse(textBox1.Text, out id) ||
                string.IsNullOrWhiteSpace(textBox4.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                !int.TryParse(textBox5.Text, out year) ||
                string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Please enter valid data for all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            name = textBox4.Text;
            tel = textBox2.Text;
            gender = textBox3.Text;

            // Open the file in read-write mode
            try
            {
                using (BinaryWriter bw = new BinaryWriter(File.Open(Info.filename, FileMode.Open, FileAccess.ReadWrite)))
                {
                    // Calculate the position of the record based on the ID
                    long recordPosition = (id - 1) * Info.rec_size;

                    // Check if the record position is within the file length
                    if (recordPosition >= 0 && recordPosition < bw.BaseStream.Length)
                    {
                        // Move to the record position
                        bw.BaseStream.Seek(recordPosition, SeekOrigin.Begin);

                        // Write the updated values to the file
                        bw.Write(id);
                        bw.Write(name);
                        bw.Write(tel);
                        bw.Write(year);
                        bw.Write(gender);

                        // Display a success message
                        MessageBox.Show("Record modified successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // Display an error message if the record position is out of bounds
                        MessageBox.Show("Invalid record ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (IOException ex)
            {
                // Display an error message if there was an IO exception
                MessageBox.Show("An error occurred while accessing the file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)

        {
            
        }

        private void DisplayForm_Load(object sender, EventArgs e)
        {
            displayFNtextBox.Text = Info.filename;
        }
    }
}