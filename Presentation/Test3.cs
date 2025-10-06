using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phumla_Kamnandi_GRP_12.Presentation
{
    internal class Test3
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Console.WriteLine("Phumla Kamnandi - Group 12");
            //Console.WriteLine("Form Display Test\n");

            //// Show Login form first
            //Console.WriteLine("Opening Login form...");
            //using (Login loginForm = new Login())
            //{
            //    Application.Run(loginForm);
            //}

            // After Login form closes, show Dashboard
            Console.WriteLine("Opening Dashboard form...");
            using (Dashbaord dashboardForm = new Dashbaord())
            {
                Application.Run(dashboardForm);
            }

            Console.WriteLine("All forms closed. Program ending.");
        }
    }
}