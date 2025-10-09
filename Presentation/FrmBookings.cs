using Phumla_Kamnandi_GRP_12.Properties;
using System;
using System.Collections;
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
        private readonly string connectionString = Settings.Default.PhumlaKamnandiDBConnectionString;
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
                SqlDataAdapter da = new SqlDataAdapter(query,con);
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
       
        // Method to handle the Make Booking button click event
        private void MakeBookingButton_Click(object sender, EventArgs e)
        {
 #region booking textbox fields
            String bookingRef = BookingReferencetextBox.Text;
            String guest = GuestIdtextBox.Text;
            String roomnumber = RoomNumbertextBox.Text;
            String checkin = CheckInDatetextBox.Text;
            String checkout = CheckoutDatetextBox.Text;
            String numberofadults = AdulttextBox.Text;
            String numberofchildren = ChildrentextBox.Text;
            String totalamount= TotalAmounttextBox.Text;
            String depositamount = DepositAmounttextBox.Text;
            String depositpaid = DepositPaidtextBox.Text;
            String status =     StatustextBox.Text;
            String paymentstatus = PaymentStatustextBox.Text;
            String bookingdate = BookingDatetextBox.Text;
            String depositdue = DepositDuetextBox.Text;
            String specialrequest = SpecialRequesttextBox.Text;
            String occupancy = OccupancytextBox.Text;
            String creditcardnumber = CreditCardtextBox.Text;
 #endregion

           
            SqlConnection connection = new SqlConnection(connectionString);
            string query = @"INSERT INTO Booking (BookingReference, GuestId, RoomNumber, CheckInDate, CheckOutDate, NumberOfAdults, NumberOfChildren,
                     TotalAmount, DepositAmount, DepositPaid, Status, PaymentStatus, BookingDate, DepositDueDate, 
                     SpecialRequest, IsSingleOccupancy, CreditCardLastFour) 
                    VALUES (@BookingReference, @GuestId, @RoomNumber, @CheckInDate, @CheckOutDate, @NumberOfAdults, 
                    @NumberOfChildren, @TotalAmount, @DepositAmount, @DepositPaid, @Status, @PaymentStatus, 
                    @BookingDate, @DepositDueDate, @SpecialRequest, @IsSingleOccupancy, @CreditCardLastFour)";


            SqlCommand bookingcommand = new SqlCommand(query,connection);
            bookingcommand.Parameters.AddWithValue("@BookingReference", bookingRef);
            bookingcommand.Parameters.AddWithValue("@GuestId", guest);
            bookingcommand.Parameters.AddWithValue("@RoomNumber", roomnumber);
            bookingcommand.Parameters.AddWithValue("@CheckInDate", checkin);
            bookingcommand.Parameters.AddWithValue("@CheckOutDate", checkout);
            bookingcommand.Parameters.AddWithValue("@NumberOfAdults", numberofadults);
            bookingcommand.Parameters.AddWithValue("@NumberOfChildren", numberofchildren);
            bookingcommand.Parameters.AddWithValue("@TotalAmount", totalamount);
            bookingcommand.Parameters.AddWithValue("@DepositAmount", depositamount);
            bookingcommand.Parameters.AddWithValue("@DepositPaid", depositpaid);
            bookingcommand.Parameters.AddWithValue("@Status", status);
            bookingcommand.Parameters.AddWithValue("@PaymentStatus", paymentstatus);
            bookingcommand.Parameters.AddWithValue("@BookingDate", bookingdate);
            bookingcommand.Parameters.AddWithValue("@DepositDueDate", depositdue);
            bookingcommand.Parameters.AddWithValue("@SpecialRequest", specialrequest);
            bookingcommand.Parameters.AddWithValue("@IsSingleOccupancy", occupancy);
            bookingcommand.Parameters.AddWithValue("@CreditCardLastFour", creditcardnumber);

            try
            {
                connection.Open();
                bookingcommand.ExecuteNonQuery();
                MessageBox.Show("Booking added successfully!");
                RefreshBookings();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }


        }

        private void DatetextBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // Method to handle the Update Booking button click event
        private void UpdateBookingbutton_Click(object sender, EventArgs e)
        {
            #region booking fields textboxes 
            String bookingRef = BookingReferencetextBox.Text;
            String guest = GuestIdtextBox.Text;
            String roomnumber = RoomNumbertextBox.Text;
            String checkin = CheckInDatetextBox.Text;
            String checkout = CheckoutDatetextBox.Text;
            String numberofadults = AdulttextBox.Text;
            String numberofchildren = ChildrentextBox.Text;
            String totalamount = TotalAmounttextBox.Text;
            String depositamount = DepositAmounttextBox.Text;
            String depositpaid = DepositPaidtextBox.Text;
            String status = StatustextBox.Text;
            String paymentstatus = PaymentStatustextBox.Text;
            String bookingdate = BookingDatetextBox.Text;
            String depositdue = DepositDuetextBox.Text;
            String specialrequest = SpecialRequesttextBox.Text;
            String occupancy = OccupancytextBox.Text;
            String creditcardnumber = CreditCardtextBox.Text;
            #endregion

            SqlConnection connection = new SqlConnection(connectionString);
            String query = "UPDATE Bookings SET First Name=@First Name, Surname=@Surname, Email=@Email, Phone=@Phone, +" +
                "Address=@Address,Credit Card Number=@Credit Card Number,Date Registered=@Date Registered,+" +
                "IsInGoodStanding=@IsInGoodStanding WHERE Phone=@Phone";

            SqlCommand bookingcommand = new SqlCommand(query,connection);


            DialogResult confirm = MessageBox.Show(
                    "Are you sure you want to Update this booking?",
                    "Confirm Update",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
                   

            if(confirm == DialogResult.Yes)
            {
               BookingReferncelabel.Enabled = true; BookingReferencetextBox.Enabled = true;
                GuestIdlabel.Enabled = true; GuestIdtextBox.Enabled = true; 

                CheckInDatetextBox.Enabled = true; CheckInDatetextBox.Enabled = true; 
                CheckoutDatetextBox.Enabled = true; CheckOutDatelabel.Enabled = true;

                Adultslabel.Enabled = true; AdulttextBox.Enabled = true; 
                Childrenlabel.Enabled = true; ChildrentextBox.Enabled = true;

                TotalAmountlabel.Enabled = true; TotalAmounttextBox.Enabled = true;
                DepositAmountlabel.Enabled = true; DepositAmounttextBox.Enabled=true;

                DepositPaidlabel.Enabled = true; DepositPaidtextBox.Enabled = true; 
                StatustextBox.Enabled = true; Statuslabel.Enabled = true;   

                PaymentStatustextBox.Enabled = false; PaymentStatuslabel.Enabled = false;
                BookingDatetextBox.Enabled = true; BookingDatelabel.Enabled = true;

                DepositDuetextBox.Enabled = false; DepositDuelabel.Enabled = false;
                SpecialRequesttextBox.Enabled = false; SpecialRequestlabel.Enabled = false;

                OccupancytextBox.Enabled = true; Occupancylabel.Enabled = true;
                CreditCardtextBox.Enabled = false; CreditCardlabel.Enabled = false;


                RoomNumbertextBox.Enabled = false;RoomNumberlabel.Enabled = false;

                connection.Open();
                bookingcommand.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Booking updated successfully!");
                RefreshBookings();
            }
            else
            {
                
                MessageBox.Show("Update aborted.");
            }
        }

        private void CancelBookingButton_Click(object sender, EventArgs e)
        {

        }

        private void FirstNamelabel_Click(object sender, EventArgs e)
        {

        }
    }
}
