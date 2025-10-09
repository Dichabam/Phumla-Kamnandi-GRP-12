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
            GenerateBookingReference();
            RefreshBookings();
        }

        private void RefreshBookings()
        {   
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT BookingReference, GuestId, RoomNumber, CheckInDate, CheckOutDate, NumberOfAdults, NumberOfChildren,TotalAmount, DepositAmount, DepositPaid, Status, PaymentStatus, BookingDate, DepositDueDate,SpecialRequests, IsSingleOccupancy, CreditCardLastFour FROM Booking";

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
            int guest = int.Parse(GuestIdtextBox.Text);
            int roomnumber = int.Parse(RoomNumbertextBox.Text);
            DateTime checkin = DateTime.Parse(CheckInDatetextBox.Text);
            DateTime checkout = DateTime.Parse(CheckoutDatetextBox.Text);
            int numberofadults = int.Parse(AdulttextBox.Text);
            int numberofchildren = int.Parse(ChildrentextBox.Text);
            decimal totalamount= decimal.Parse(TotalAmounttextBox.Text);
            decimal depositamount = decimal.Parse(DepositAmounttextBox.Text);
            decimal depositpaid = decimal.Parse(DepositPaidtextBox.Text);
            String status =    StatustextBox.Text;
            String paymentstatus = PaymentStatustextBox.Text;
            DateTime bookingdate = DateTime.Parse(BookingDatetextBox.Text);
            DateTime  depositdue = DateTime.Parse(DepositDuetextBox.Text);
            String specialrequest = SpecialRequesttextBox.Text;
            String occupancy = OccupancytextBox.Text;
            int creditcardnumber = int.Parse(CreditCardtextBox.Text);
 #endregion

           
            SqlConnection connection = new SqlConnection(connectionString);
            string query = @"INSERT INTO Booking (BookingReference, GuestId, RoomNumber, CheckInDate, CheckOutDate, NumberOfAdults, NumberOfChildren,
                     TotalAmount, DepositAmount, DepositPaid, Status, PaymentStatus, BookingDate, DepositDueDate, 
                     SpecialRequests, IsSingleOccupancy, CreditCardLastFour) 
                    VALUES (@BookingReference, @GuestId, @RoomNumber, @CheckInDate, @CheckOutDate, @NumberOfAdults, 
                    @NumberOfChildren, @TotalAmount, @DepositAmount, @DepositPaid, @Status, @PaymentStatus, 
                    @BookingDate, @DepositDueDate, @SpecialRequests, @IsSingleOccupancy, @CreditCardLastFour)";


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
            DialogResult confirm = MessageBox.Show(
                    "Are you sure you want to Update this booking?",
                    "Confirm Update",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
                   

            if(confirm == DialogResult.Yes)
            {

              
                using (SqlConnection connection = new SqlConnection(connectionString))
                {   
                    HideInputFields();
                    string query = @"UPDATE Booking 
                                         SET RoomNumber=@RoomNumber, CheckInDate=@CheckInDate, CheckOutDate=@CheckOutDate,
                                             NumberOfAdults=@NumberOfAdults, NumberOfChildren=@NumberOfChildren,
                                             TotalAmount=@TotalAmount, Status=@Status, PaymentStatus=@PaymentStatus
                                         WHERE BookingReference=@BookingReference";

                    SqlCommand cmd = new SqlCommand(query, connection);

                    SqlCommand bookingcommand = new SqlCommand(query, connection);
                   
                    bookingcommand.Parameters.AddWithValue("@RoomNumber", int.Parse(RoomNumbertextBox.Text));
                    bookingcommand.Parameters.AddWithValue("@CheckOutDate", DateTime.Parse(CheckoutDatetextBox.Text));
                    bookingcommand.Parameters.AddWithValue("@NumberOfAdults", int.Parse(AdulttextBox.Text));
                    bookingcommand.Parameters.AddWithValue("@NumberOfChildren", int.Parse(ChildrentextBox.Text));
                    bookingcommand.Parameters.AddWithValue("@TotalAmount", decimal.Parse(TotalAmounttextBox.Text));
                    bookingcommand.Parameters.AddWithValue("@Status", StatustextBox.Text);
                    bookingcommand.Parameters.AddWithValue("@PaymentStatus", PaymentStatustextBox.Text);
                    bookingcommand.Parameters.AddWithValue("@BookingReference", BookingReferencetextBox.Text);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Booking updated successfully!");
                    RefreshBookings();
                   
                }
            }
            else
            {
                
                MessageBox.Show("Update aborted.");
            }
        }

        private void CancelBookingButton_Click(object sender, EventArgs e)
        {
            StatustextBox.Text = "Cancelled";
        }

        private void FirstNamelabel_Click(object sender, EventArgs e)
        {

        }

        private void HideInputFields()
        {
            BookingReferencetextBox.Enabled = true;
            GuestIdtextBox.Enabled = true;
            RoomNumbertextBox.Enabled = true;
            CheckInDatetextBox.Enabled = true;
            CheckoutDatetextBox.Enabled = true;
            AdulttextBox.Enabled = false;
            ChildrentextBox.Enabled = false;
            TotalAmounttextBox.Enabled = false;
            DepositAmounttextBox.Enabled = false;
            DepositPaidtextBox.Enabled = false;
            StatustextBox.Enabled = false;
            PaymentStatustextBox.Enabled = false;
            BookingDatetextBox.Enabled = false;
            DepositDuetextBox.Enabled = false;
            SpecialRequesttextBox.Enabled = false;
            OccupancytextBox.Enabled = false;
            CreditCardtextBox.Enabled = false;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BookingDatetextBox_ValueChanged(object sender, EventArgs e)
        {

        }

        private void GenerateBookingReference()
        {
            Random random = new Random();
            string bookingRef = "PK-" + random.Next(100000, 999999);
            BookingReferencetextBox.Text = bookingRef;
        }

        private void StatustextBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
