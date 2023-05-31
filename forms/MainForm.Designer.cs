namespace CSharpMessenger.forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            userMessages = new DataGridView();
            fromuseridDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            messagetextDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            messageBindingSource = new BindingSource(components);
            logout = new Button();
            viewSent = new Button();
            Send = new Button();
            Title = new Label();
            ((System.ComponentModel.ISupportInitialize)userMessages).BeginInit();
            ((System.ComponentModel.ISupportInitialize)messageBindingSource).BeginInit();
            SuspendLayout();
            // 
            // userMessages
            // 
            userMessages.AllowUserToAddRows = false;
            userMessages.AutoGenerateColumns = false;
            userMessages.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userMessages.Columns.AddRange(new DataGridViewColumn[] { fromuseridDataGridViewTextBoxColumn, messagetextDataGridViewTextBoxColumn });
            userMessages.DataSource = messageBindingSource;
            userMessages.Location = new Point(14, 56);
            userMessages.Name = "userMessages";
            userMessages.ReadOnly = true;
            userMessages.RowHeadersWidth = 51;
            userMessages.RowTemplate.Height = 29;
            userMessages.Size = new Size(774, 316);
            userMessages.TabIndex = 0;
            userMessages.CellContentClick += userMessages_CellContentClick;
            // 
            // fromuseridDataGridViewTextBoxColumn
            // 
            fromuseridDataGridViewTextBoxColumn.DataPropertyName = "fromuserid";
            fromuseridDataGridViewTextBoxColumn.HeaderText = "From";
            fromuseridDataGridViewTextBoxColumn.MinimumWidth = 6;
            fromuseridDataGridViewTextBoxColumn.Name = "fromuseridDataGridViewTextBoxColumn";
            fromuseridDataGridViewTextBoxColumn.ReadOnly = true;
            fromuseridDataGridViewTextBoxColumn.Width = 125;
            // 
            // messagetextDataGridViewTextBoxColumn
            // 
            messagetextDataGridViewTextBoxColumn.DataPropertyName = "messagetext";
            messagetextDataGridViewTextBoxColumn.HeaderText = "Message";
            messagetextDataGridViewTextBoxColumn.MinimumWidth = 6;
            messagetextDataGridViewTextBoxColumn.Name = "messagetextDataGridViewTextBoxColumn";
            messagetextDataGridViewTextBoxColumn.ReadOnly = true;
            messagetextDataGridViewTextBoxColumn.Width = 500;
            // 
            // messageBindingSource
            // 
            messageBindingSource.DataSource = typeof(models.Message);
            // 
            // logout
            // 
            logout.Location = new Point(694, 12);
            logout.Name = "logout";
            logout.Size = new Size(94, 29);
            logout.TabIndex = 1;
            logout.Text = "logout";
            logout.UseVisualStyleBackColor = true;
            logout.Click += logout_Click;
            // 
            // viewSent
            // 
            viewSent.Location = new Point(141, 399);
            viewSent.Name = "viewSent";
            viewSent.Size = new Size(94, 29);
            viewSent.TabIndex = 2;
            viewSent.Text = "View Sent";
            viewSent.UseVisualStyleBackColor = true;
            viewSent.Click += viewSent_Click;
            // 
            // Send
            // 
            Send.Location = new Point(14, 399);
            Send.Name = "Send";
            Send.Size = new Size(94, 29);
            Send.TabIndex = 3;
            Send.Text = "Send";
            Send.UseVisualStyleBackColor = true;
            Send.Click += Send_Click;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Location = new Point(14, 16);
            Title.Name = "Title";
            Title.Size = new Size(97, 20);
            Title.TabIndex = 4;
            Title.Text = "My Messages";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Title);
            Controls.Add(Send);
            Controls.Add(viewSent);
            Controls.Add(logout);
            Controls.Add(userMessages);
            Name = "MainForm";
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)userMessages).EndInit();
            ((System.ComponentModel.ISupportInitialize)messageBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView userMessages;
        private Button logout;
        private Button viewSent;
        private Button Send;
        private Label Title;
        private BindingSource messageBindingSource;
        private DataGridViewTextBoxColumn fromuseridDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn messagetextDataGridViewTextBoxColumn;
    }
}