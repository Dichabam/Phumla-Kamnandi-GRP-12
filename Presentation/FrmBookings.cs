using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phumla_Kamnandi_GRP_12.Presentation
{   
    public partial class FrmBookings : Form
    {   

       public FrmBookings()
        {
            InitializeComponent();
        }

        private void FrmBookings_Load(object sender, EventArgs e)
        {
            RefreshBookings();
        }

        private void RefreshBookings()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT First Name, Surname, Email, Phone, Address,Credit Card Number,Date Registered,IsInGoodStanding";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                ShowdataGridView.DataSource = dt;
            }
        }


        private void Datelabel_Click(object sender, EventArgs e)
        {
           
        }

        private void Formlabel_Click(object sender, EventArgs e)
        {

        }

        private void CardtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DatetextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cardlabel_Click(object sender, EventArgs e)
        {

        }

        private void FormtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void MakeBookingButton_Click(object sender, EventArgs e)
        {

            String name = FirstNametextBox.Text;
            String surname = LastNametextBox.Text;
            String Phone = PhonetextBox.Text;
            String Email = EmailtextBox.Text;
            String Address = AddresstextBox.Text;
            String creditCard = LastNametextBox.Text;
            String dateRegistered = LastNametextBox.Text;
            string query = "INSERT INTO Bookings (First Name, Surname, Email, Phone, Address,Credit Card Number,Date Registered,IsInGoodStanding) " +
                       "VALUES (@First Name, @Surname, @Email, @Phone, @Address,@Credit Card Number,@Date Registered,@IsInGoodStanding)";

            SqlCommand bookingcommand = new SqlCommand(query, connection);  
            bookingcommand.Parameters.AddWithValue("(@First Name", name);
            bookingcommand.Parameters.AddWithValue("@Surname", surname);
            bookingcommand.Parameters.AddWithValue("@Email", Email);
            bookingcommand.Parameters.AddWithValue("@Phone", Phone);
            bookingcommand.Parameters.AddWithValue("@Address", Address);
            bookingcommand.Parameters.AddWithValue("@Credit Card Number", creditCard);
            bookingcommand.Parameters.AddWithValue("@Date Registered",dateRegistered);

            //connection.Open();
            bookingcommand.ExecuteNonQuery();
           // connection.Close();
           RefreshBookings();

            MessageBox.Show("Booking added successfully!");
           


        }

        private void DatetextBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UpdateBookingbutton_Click(object sender, EventArgs e)
        {
                   DialogResult confirm = MessageBox.Show(
                    "Are you sure you want to cancel this booking?",
                    "Confirm Cancellation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
                    String name = FirstNametextBox.Text;
                    String surname = LastNametextBox.Text;
                    String Phone = PhonetextBox.Text;
                    String Email= EmailtextBox.Text;
                    String Address = AddresstextBox.Text;
                    String creditCard = LastNametextBox.Text;
                    String dateRegistered = LastNametextBox.Text;

            if(confirm == DialogResult.Yes)
            {
                name.Enable = true;
            }
            else
            {
                
                MessageBox.Show("Cancellation aborted.");
            }
        }

        private void CancelBookingButton_Click(object sender, EventArgs e)
        {

        }
    }
}
