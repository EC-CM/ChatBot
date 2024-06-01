using AIMLbot;
using Application = System.Windows.Forms.Application;
using System.Threading;
//using WinForms = System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;

namespace chatter
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Thread winFormsThread = new Thread(() =>
            { // Start the form in a separate thread.
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new frmChatWindow());
            });
            winFormsThread.SetApartmentState(ApartmentState.STA);
            winFormsThread.Start();

        }
    }
}

