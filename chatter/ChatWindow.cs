using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AIMLbot;

namespace chatter
{
    public partial class frmChatWindow : Form
    {
        private Bot AI;
        private User myUser;
        private int tbInputField_Height;
        private int formHeight;

        public frmChatWindow()
        {
            InitializeComponent();

            // Prevent back colour of button changing to white upon hover.
            btnSendMessage.FlatAppearance.MouseOverBackColor = btnSendMessage.BackColor;
            btnSendMessage.BackColorChanged += (s, e) =>
            {
                btnSendMessage.FlatAppearance.MouseOverBackColor = btnSendMessage.BackColor;
            };

            tbInputField_Height = tbInputField.Height;
            formHeight = this.Height;

            AI = new Bot(); // This defines the object "AI" To hold the bot's infomation

            AI.loadSettings(); // This loads the settings from the config folder

            AI.loadAIMLFromFiles(); // This loads the AIML files from the aiml folder

            AI.isAcceptingUserInput = false; // This switches off the bot to stop the user entering input while the bot is loading

            myUser = new User("Username", AI); // This creates a new User called "Username", using the object "AI"'s information.

            AI.isAcceptingUserInput = true; // This swithces the user input back on
        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            string userMessage = tbInputField.Text;
            tbInputField.Text = "";


            // Deal with multi-line input
            string displayMessage = userMessage;
            if (userMessage.Contains(Environment.NewLine))
            {
                string[] lines = userMessage.Split(new[] { Environment.NewLine },
                    StringSplitOptions.None);

                List<string> indentedLines = new List<string>();
                indentedLines.Add(lines[0]);

                for (int i = 1; i < lines.Length; i++)
                {
                    indentedLines.Add("         " + lines[i]);
                }

                displayMessage = string.Join(Environment.NewLine, indentedLines);

            }

            // Display user message
            //rtbChatHistory.AppendText("You: " + userMessage + Environment.NewLine);
            AppendColouredText("You: " + displayMessage + Environment.NewLine, Color.White);

            // Process user message
            Request r = new Request(userMessage, myUser, AI);
            Result res = AI.Chat(r);

            // Display bot response
            //rtbChatHistory.AppendText("Bot: " + res.Output + Environment.NewLine);
            AppendColouredText("Bot: " + res.Output + Environment.NewLine, ColorTranslator.FromHtml("#19c37d"));
        }

        private void AppendColouredText(string text, Color color)
        {

            rtbChatHistory.SelectionColor = color;
            rtbChatHistory.AppendText(text);
            rtbChatHistory.SelectionColor = rtbChatHistory.ForeColor;
        }


        private void btnSendMessage_MouseEnter(object sender, EventArgs e)
        {
            // Customize the button appearance on hover
            btnSendMessage.BackgroundImage = Properties.Resources.ChatGPT_Send_Button;
        }

        private void btnSendMessage_MouseLeave(object sender, EventArgs e)
        {
            // Restore the original appearance when the mouse leaves
            btnSendMessage.BackgroundImage = Properties.Resources.ChatGPT_Send_Button_White;
        }

        private void tbInputField_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is Enter
            if (e.KeyChar == (char)Keys.Enter)
            {
                if ((Control.ModifierKeys & Keys.Shift) == 0)
                {
                    // Suppress the default Enter key behavior(newline)
                    e.Handled = true;

                    // Perform the event as if the user clicked the button
                    btnSendMessage_Click(sender, EventArgs.Empty);
                }
            }
        }


        private void tbInputField_TextChanged(object sender, EventArgs e)
        { // CAN'T GET SCALING TO WORK PROPERLY
            int lineCount = tbInputField.GetLineFromCharIndex(tbInputField.Text.Length) + 1;
            //tbInputField.Height = lineCount * tbInputField_Height;
            //this.Height = formHeight + ((lineCount-1) * tbInputField.Height);
        }

    }

}
