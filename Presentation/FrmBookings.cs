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
           

            // update DB
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = @"UPDATE Booking 
                             SET RoomNumber = @RoomNumber,
                                 CheckInDate = @CheckInDate,
                                 CheckOutDate = @CheckOutDate,
                                 NumberOfAdults = @NumberOfAdults,
                                 NumberOfChildren = @NumberOfChildren,
                                 TotalAmount = @TotalAmount,
                                 Status = @Status,
                                 PaymentStatus = @PaymentStatus
                             WHERE BookingReference = @BookingReference";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@RoomNumber", roomnumber);
                        cmd.Parameters.AddWithValue("@CheckInDate", checkin);
                        cmd.Parameters.AddWithValue("@CheckOutDate", checkout);
                        cmd.Parameters.AddWithValue("@NumberOfAdults", numberofadults);
                        cmd.Parameters.AddWithValue("@NumberOfChildren", numberofchildren);
                        cmd.Parameters.AddWithValue("@TotalAmount", totalamount);
                        cmd.Parameters.AddWithValue("@Status", status);
                        cmd.Parameters.AddWithValue("@PaymentStatus", paymentstatus);
                        cmd.Parameters.AddWithValue("@BookingReference", bookingRef);

                        connection.Open();
                        int rows = cmd.ExecuteNonQuery();
                        connection.Close();

                        if (rows > 0)
                        {
                            MessageBox.Show("Booking updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No booking was updated. Please verify the booking reference.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }

                // Reset UI: hide edit fields and restore button text
                HideAllFields();
               
                RefreshBookings();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating booking: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        private void CancelBookingButton_Click(object sender, EventArgs e)
        {
            
        }

        private void FirstNamelabel_Click(object sender, EventArgs e)
        {

        }

        private void HideAllFields()
        {
            BookingReferencetextBox.Visible = false;
            BookingReferncelabel.Visible = false;

            GuestIdtextBox.Visible = false;
            GuestIdlabel.Visible = false;

            RoomNumbertextBox.Visible = false;
            RoomNumberlabel.Visible = false;

            CheckInDatetextBox.Visible = false;
            CheckInDatelabel.Visible = false;

            CheckoutDatetextBox.Visible = false;
            CheckOutDatelabel.Visible = false;

            AdulttextBox.Visible = false;
            Adultslabel.Visible = false;

            ChildrentextBox.Visible = false;
            Childrenlabel.Visible = false;

            TotalAmounttextBox.Visible = false;
            TotalAmountlabel.Visible = false;

            DepositAmounttextBox.Visible = false;
            DepositAmountlabel.Visible = false;

            DepositPaidtextBox.Visible = false;
            DepositPaidlabel.Visible = false;

            StatustextBox.Visible = false;
            Statuslabel.Visible = false;

            PaymentStatustextBox.Visible = false;
            PaymentStatuslabel.Visible = false;

            BookingDatetextBox.Visible = false;
            BookingDatelabel.Visible = false;

            DepositDuetextBox.Visible = false;
            DepositDuelabel.Visible = false;

            SpecialRequesttextBox.Visible = false;
            SpecialRequestlabel.Visible = false;

            OccupancytextBox.Visible = false;
            Occupancylabel.Visible = false;

            CreditCardtextBox.Visible = false;
            CreditCardlabel.Visible = false;
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
