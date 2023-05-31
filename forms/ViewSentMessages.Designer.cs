namespace CSharpMessenger.forms
{
    partial class ViewSentMessages
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
            mySentMessages = new DataGridView();
            backButton = new Button();
            sentLabel = new Label();
            messageBindingSource = new BindingSource(components);
            touseridDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            messagetextDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)mySentMessages).BeginInit();
            ((System.ComponentModel.ISupportInitialize)messageBindingSource).BeginInit();
            SuspendLayout();
            // 
            // mySentMessages
            // 
            mySentMessages.AllowUserToAddRows = false;
            mySentMessages.AutoGenerateColumns = false;
            mySentMessages.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            mySentMessages.Columns.AddRange(new DataGridViewColumn[] { touseridDataGridViewTextBoxColumn, messagetextDataGridViewTextBoxColumn });
            mySentMessages.DataSource = messageBindingSource;
            mySentMessages.Location = new Point(12, 51);
            mySentMessages.Name = "mySentMessages";
            mySentMessages.ReadOnly = true;
            mySentMessages.RowHeadersWidth = 51;
            mySentMessages.RowTemplate.Height = 29;
            mySentMessages.Size = new Size(776, 314);
            mySentMessages.TabIndex = 0;
            // 
            // backButton
            // 
            backButton.Location = new Point(12, 409);
            backButton.Name = "backButton";
            backButton.Size = new Size(94, 29);
            backButton.TabIndex = 1;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // sentLabel
            // 
            sentLabel.AutoSize = true;
            sentLabel.Location = new Point(12, 9);
            sentLabel.Name = "sentLabel";
            sentLabel.Size = new Size(130, 20);
            sentLabel.TabIndex = 2;
            sentLabel.Text = "My Sent Messages";
            // 
            // messageBindingSource
            // 
            messageBindingSource.DataSource = typeof(models.Message);
            // 
            // touseridDataGridViewTextBoxColumn
            // 
            touseridDataGridViewTextBoxColumn.DataPropertyName = "touserid";
            touseridDataGridViewTextBoxColumn.HeaderText = "To";
            touseridDataGridViewTextBoxColumn.MinimumWidth = 6;
            touseridDataGridViewTextBoxColumn.Name = "touseridDataGridViewTextBoxColumn";
            touseridDataGridViewTextBoxColumn.ReadOnly = true;
            touseridDataGridViewTextBoxColumn.Width = 125;
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
            // ViewSentMessages
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(sentLabel);
            Controls.Add(backButton);
            Controls.Add(mySentMessages);
            Name = "ViewSentMessages";
            Text = "ViewSentMessages";
            ((System.ComponentModel.ISupportInitialize)mySentMessages).EndInit();
            ((System.ComponentModel.ISupportInitialize)messageBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView mySentMessages;
        private Button backButton;
        private Label sentLabel;
        private DataGridViewTextBoxColumn touseridDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn messagetextDataGridViewTextBoxColumn;
        private BindingSource messageBindingSource;
    }
}