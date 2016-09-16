using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Encrypt_a_Passwrod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static string Encript(string value)
        {
            using(MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider()) // Declear Object from MD5 Encrypting 
            {
                UTF8Encoding utf8 = new UTF8Encoding(); // Create Object from uft8 Encrypting 
                byte[] data = md5.ComputeHash(utf8.GetBytes(value)); // Encrypting Data (parameter Data)
                return Convert.ToBase64String(data); // Convert The Encrypting to string value
            }
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please Enter Your Passowrd", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            txtResult.Text = Encript(txtPassword.Text);
        }
    }
}
