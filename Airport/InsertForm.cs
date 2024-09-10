using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using System.Reflection.Emit;
namespace Airport
{
    public partial class InsertForm : Form
    {
        public InsertForm() {InitializeComponent();}
        private void label5_Click(object sender, EventArgs e){}

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
 BinaryWriter bw = new BinaryWriter(File.Open(Info.filename, FileMode.Open, FileAccess.Write)); // We Should include using System.IO;
            //بيكتبلي الحاجات الي بكتبها لباينري جواا الباينري فاايل وبيااخد 3 بااراميتر اول واحد اسم الفايل 
            // BaseStream.Length : Get the total Length of file
            int length = (int)bw.BaseStream.Length;
         
            if (length != 0)//If the file is not empty hymshy 33 byte (recordsize) w b3d keda yktb

            {
                bw.BaseStream.Seek(length, SeekOrigin.Begin);
         //بتتحرك جواا الفاااايل بناءا علي اول باراميتر
            }

   bw.Write(int.Parse(textBoxID.Text)); // ID
            //4 Byte

           
            textBoxName.Text = textBoxName.Text.PadRight(14); // Name
            bw.Write(textBoxName.Text.Substring(0, 14)); //14 Byte +1

            bw.Write(textBoxTelephone.Text.Substring(0, 11));
            textBoxTelephone.Text = textBoxTelephone.Text.PadRight(11); //Tel
            //11  //9 dh 3aanad el doctor


            bw.Write(int.Parse(textBoxYear.Text)); //Year
            //4

            bw.Write(textBoxGender.Text.Substring(0, 1));  // Gender
            //1
            // 7asbat el Doc = 4+9+11+4+1+3 =32
            // 7asbatanaa =4 + 14 + 11 + 1 + 3 +4 =37
            MessageBox.Show(" Data is Saved Successfully ");
            bw.Close();


            // update number of records label

            length += Info.rec_size;
            textBoxID.Clear(); textBoxName.Clear(); textBoxTelephone.Clear();
            textBoxYear.Clear(); textBoxGender.Clear();
            NumOfRecLabel.Text = (length / Info.rec_size).ToString();
            //update file length label
FileSizeLabel.Text = length.ToString();

            MessageBox.Show(" Data is Saved Successfully ");
            bw.Close();


                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 targetform = new Form3();
            this.Hide();
            targetform.Show();





        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = Info.filename;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "PNG files (*.png)|*.png|JPEG files (*.jpg, *.jpeg)|*.jpg;*.jpeg|BMP files (*.bmp)|*.bmp|All files (*.*)|*.*"; openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = new Bitmap(openFileDialog.FileName);

                    MessageBox.Show("PNG image file uploaded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }




            }
            catch (Exception)
            {




            }



        }

        private void InsertForm_Load(object sender, EventArgs e)
        {
            textBox1.Text = Info.filename;

        }

        private void FileSizeLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {




        }



    }
}
