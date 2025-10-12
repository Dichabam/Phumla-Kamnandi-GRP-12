using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phumla_Kamnandi_GRP_12.Presentation
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void makeBookingButton_Click(object sender, EventArgs e)
        {
            var dashboard = Application.OpenForms.OfType<Dashboard>().FirstOrDefault();
            if (dashboard != null)
            {
                dashboard.NavigateToBookings();
            }
        }

        private void ViewGuestButton_Click(object sender, EventArgs e)
        {
            var dashboard = Application.OpenForms.OfType<Dashboard>().FirstOrDefault();
            if (dashboard != null)
            {
                dashboard.NavigateToGuest();
            }
        }

        private void EnquiryButton_Click(object sender, EventArgs e)
        {
            string pricingSummary =
                    "🌤️ Seasonal Pricing Summary:\n\n" +
                    "🔹 Low Season (R550/night):\n" +
                    "   - December 1–7\n" +
                    "   - February, March, May, September, October, November\n\n" +
                    "🔸 Mid Season (R750/night):\n" +
                    "   - December 8–15\n" +
                    "   - January\n" +
                    "   - April (Easter period)\n\n" +
                    "🔺 High Season (R995/night):\n" +
                    "   - December 16–31\n" +
                    "   - June, July, August (Winter holidays)\n\n" +
                    "💡 Single occupancy adds 50% to the nightly rate.\n" +
                    "💡 Children discounts are under review and not yet applied.";

            MessageBox.Show(pricingSummary, "Seasonal Pricing Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
