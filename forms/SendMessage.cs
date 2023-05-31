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

namespace CSharpMessenger.forms
{
    public partial class SendMessage : Form
    {
        public User user;
        private MessengerContext? dbContext;
        public SendMessage(User user)
        {
            InitializeComponent();
            //getData();
            using (var context = new MessengerContext())
            {
                var users = context.Users;
                listBox1.Items.AddRange(users.Select(x => x.email).ToArray());
            }

            this.user = user;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            using (var context = new MessengerContext())
            {
                var message = new models.Message
                {
                    fromuserid = this.user.email,
                    touserid = this.listBox1.SelectedItem.ToString(),
                    messagetext = this.textBox1.Text
                };

                context.Messages.Add(message);
                context.SaveChanges();
                this.Close();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
