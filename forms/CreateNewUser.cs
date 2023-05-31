using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSharpMessenger.models;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;


namespace CSharpMessenger.forms
{
    public partial class CreateNewUser : Form
    {
        private MessengerContext? dbContext;
        public CreateNewUser()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.dbContext = new MessengerContext();
            this.dbContext.Users.Load();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            this.dbContext?.Dispose();
            this.dbContext = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            string password = textBox2.Text;
            string repeatPassword = textBox3.Text;

            if (password != repeatPassword)
            {
                MessageBox.Show("Passwords Do Not Match");
                return;
            }

            string hPassword = ComputeHash(password, new SHA256CryptoServiceProvider());

            using (var context = new MessengerContext())
            {
                var newUser = new User
                {
                    email = email,
                    password = hPassword,
                    firstname = textBox4.Text,
                    lastname = textBox5.Text,
                    phonenumber = textBox6.Text,
                };

                context.Users.Add(newUser);
                context.SaveChanges();
                this.Close();
            }

        }

        public string ComputeHash(string input, HashAlgorithm algorithm)
        {
            Byte[] inputBytes = Encoding.UTF8.GetBytes(input);

            Byte[] hashedBytes = algorithm.ComputeHash(inputBytes);

            return BitConverter.ToString(hashedBytes);
        }
    }
}
