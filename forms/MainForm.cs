using CSharpMessenger.Migrations;
using CSharpMessenger.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpMessenger.forms
{
    public partial class MainForm : Form
    {
        public User _User;
        private MessengerContext? dbContext;
        public MainForm(User user)
        {
            InitializeComponent();
            _User = user;

            using (var context = new MessengerContext())
            {
                this.userMessages.DataSource = context.Messages.Where(x => x.touserid == this._User.email).ToArray();
            }
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Send_Click(object sender, EventArgs e)
        {
            var sendMessage = new SendMessage(this._User);
            sendMessage.Show();
        }

        private void userMessages_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void viewSent_Click(object sender, EventArgs e)
        {
            var sentForm = new ViewSentMessages(this._User);
            sentForm.Show();
        }
    }
}
