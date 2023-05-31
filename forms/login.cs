using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using CSharpMessenger.models;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;

namespace CSharpMessenger.forms
{
    public partial class login : Form
    {
        private MessengerContext? dbContext;
        public login()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.dbContext = new MessengerContext();
            this.dbContext.Users.Load();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            string password = textBox2.Text;

            using (var context = new MessengerContext())
            {
                var user = context.Users.FirstOrDefault(u => u.email == email);
                if (user != null)
                {
                    // User found, continue with validation
                    string hPassword = ComputeHash(password, new SHA256CryptoServiceProvider());

                    bool isMatch = string.Equals(user.password, hPassword);
                    if (isMatch)
                    {
                        var mainForm = new MainForm(user);

                        mainForm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Email Or Password");
                        return;
                    }
                }
                else
                {
                    // User not found, handle accordingly
                    MessageBox.Show("Invalid Email Or Password");
                    return;
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var createUser = new CreateNewUser();
            createUser.Show();
        }

        public string ComputeHash(string input, HashAlgorithm algorithm)
        {
            Byte[] inputBytes = Encoding.UTF8.GetBytes(input);

            Byte[] hashedBytes = algorithm.ComputeHash(inputBytes);

            return BitConverter.ToString(hashedBytes);
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
