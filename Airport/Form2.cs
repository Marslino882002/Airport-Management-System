using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
namespace Airport

{
    public partial class Form2 : Form
    {

        

        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            void StorePasswordHashToFile(string password)
            {
                using (SHA256 sha256 = SHA256.Create())
                {
                    byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
                    byte[] passwordHashBytes = sha256.ComputeHash(passwordBytes);
                    string passwordHash = Convert.ToBase64String(passwordHashBytes);

                    // Write the password hash to a text file
                    File.WriteAllText("password.txt", passwordHash);
                }
            }




            string Text = File.ReadAllText("username.txt");
            string[] str = Text.Split('@');
            string username = str[0];
            string password = str[1];



            string enteredUsername = textBox1.Text;
            string enteredPassword = textBox2.Text;



            if (textBox1.Text == username && textBox2.Text == password)
            {
                StorePasswordHashToFile(enteredPassword);

                Form3 targetform = new Form3();
                this.Hide();
                targetform.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password, Try Agin", "error",
                MessageBoxButtons.OK
                , MessageBoxIcon.Error);
            }


        }

        

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 formain = new Form1();
            formain.ShowDialog(this);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
