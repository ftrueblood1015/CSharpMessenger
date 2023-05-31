using CSharpMessenger.models;
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
    public partial class ViewSentMessages : Form
    {
        User user;
        public ViewSentMessages(User user)
        {
            InitializeComponent();
            this.user = user;
            using (var context = new MessengerContext())
            {
                this.mySentMessages.DataSource = context.Messages.Where(x => x.fromuserid == this.user.email).ToArray();
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
