namespace chatter
{
    partial class frmChatWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChatWindow));
            this.tbInputField = new System.Windows.Forms.TextBox();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.rtbChatHistory = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // tbInputField
            // 
            this.tbInputField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.tbInputField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbInputField.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.tbInputField.ForeColor = System.Drawing.Color.White;
            this.tbInputField.Location = new System.Drawing.Point(12, 775);
            this.tbInputField.Multiline = true;
            this.tbInputField.Name = "tbInputField";
            this.tbInputField.Size = new System.Drawing.Size(1355, 50);
            this.tbInputField.TabIndex = 4;
            this.tbInputField.TextChanged += new System.EventHandler(this.tbInputField_TextChanged);
            this.tbInputField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbInputField_KeyPress);
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.BackColor = System.Drawing.Color.Transparent;
            this.btnSendMessage.BackgroundImage = global::chatter.Properties.Resources.ChatGPT_Send_Button_White;
            this.btnSendMessage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSendMessage.FlatAppearance.BorderSize = 0;
            this.btnSendMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.192F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendMessage.Location = new System.Drawing.Point(1373, 766);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(68, 70);
            this.btnSendMessage.TabIndex = 3;
            this.btnSendMessage.UseVisualStyleBackColor = false;
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            this.btnSendMessage.MouseEnter += new System.EventHandler(this.btnSendMessage_MouseEnter);
            this.btnSendMessage.MouseLeave += new System.EventHandler(this.btnSendMessage_MouseLeave);
            // 
            // rtbChatHistory
            // 
            this.rtbChatHistory.BackColor = System.Drawing.Color.Black;
            this.rtbChatHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbChatHistory.ForeColor = System.Drawing.Color.White;
            this.rtbChatHistory.Location = new System.Drawing.Point(12, 12);
            this.rtbChatHistory.Name = "rtbChatHistory";
            this.rtbChatHistory.ReadOnly = true;
            this.rtbChatHistory.Size = new System.Drawing.Size(1429, 748);
            this.rtbChatHistory.TabIndex = 6;
            this.rtbChatHistory.Text = "";
            // 
            // frmChatWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(1453, 840);
            this.Controls.Add(this.rtbChatHistory);
            this.Controls.Add(this.btnSendMessage);
            this.Controls.Add(this.tbInputField);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmChatWindow";
            this.Text = "Chat Bot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSendMessage;
        private System.Windows.Forms.TextBox tbInputField;
        private System.Windows.Forms.RichTextBox rtbChatHistory;
    }
}