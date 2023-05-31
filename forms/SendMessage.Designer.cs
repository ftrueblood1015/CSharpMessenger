namespace CSharpMessenger.forms
{
    partial class SendMessage
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
            cancelButton = new Button();
            sendButton = new Button();
            userLabel = new Label();
            textBox1 = new TextBox();
            listBox1 = new ListBox();
            messageLabel = new Label();
            initialBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)initialBindingSource).BeginInit();
            SuspendLayout();
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(12, 261);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(94, 29);
            cancelButton.TabIndex = 0;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // sendButton
            // 
            sendButton.Location = new Point(694, 261);
            sendButton.Name = "sendButton";
            sendButton.Size = new Size(94, 29);
            sendButton.TabIndex = 1;
            sendButton.Text = "Send";
            sendButton.UseVisualStyleBackColor = true;
            sendButton.Click += sendButton_Click;
            // 
            // userLabel
            // 
            userLabel.AutoSize = true;
            userLabel.Location = new Point(12, 9);
            userLabel.Name = "userLabel";
            userLabel.Size = new Size(38, 20);
            userLabel.TabIndex = 2;
            userLabel.Text = "User";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(19, 209);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(769, 27);
            textBox1.TabIndex = 3;
            // 
            // listBox1
            // 
            listBox1.AllowDrop = true;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(19, 40);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(299, 124);
            listBox1.TabIndex = 4;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // messageLabel
            // 
            messageLabel.AutoSize = true;
            messageLabel.Location = new Point(19, 176);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new Size(67, 20);
            messageLabel.TabIndex = 5;
            messageLabel.Text = "Message";
            // 
            // initialBindingSource
            // 
            initialBindingSource.DataSource = typeof(Migrations.Initial);
            // 
            // SendMessage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 390);
            Controls.Add(messageLabel);
            Controls.Add(listBox1);
            Controls.Add(textBox1);
            Controls.Add(userLabel);
            Controls.Add(sendButton);
            Controls.Add(cancelButton);
            Name = "SendMessage";
            Text = "SendMessage";
            ((System.ComponentModel.ISupportInitialize)initialBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cancelButton;
        private Button sendButton;
        private Label userLabel;
        private TextBox textBox1;
        private ListBox listBox1;
        private Label messageLabel;
        private BindingSource initialBindingSource;
    }
}