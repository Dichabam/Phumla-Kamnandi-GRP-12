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

            using (Login loginForm = new Login())
            {
                Application.Run(loginForm);
            }


            //using (Dashboard dashboardForm = new Dashboard())
            //{
            //    Application.Run(dashboardForm);
            //}

            
        }
    }
}