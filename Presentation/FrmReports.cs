using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phumla_Kamnandi_GRP_12.Presentation
{
    public partial class FrmReports : Form
    {
        private ServiceLocator _services;
        private string _lastGeneratedReport = string.Empty;

        public FrmReports()
        {
            InitializeComponent();
            _services = ServiceLocator.Instance;
            InitializeForm();
        }

        private void InitializeForm()
        {
          
            FromLabel.Visible = false;
            ToLabel.Visible = false;
            DatePickerStart.Visible = false;
            DatePickerEnd.Visible = false;

            AlltimeRB.Checked = true;

           

           
            GenerateReportButton.Click += GenerateReportButton_Click;
            saveButton.Click += saveButton_Click;
        }

        private void DateRangeOption_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (!rb.Checked) return;

            
            bool showDatePickers = rb == SpecificRB;
            FromLabel.Visible = showDatePickers;
            ToLabel.Visible = showDatePickers;
            DatePickerStart.Visible = showDatePickers;
            DatePickerEnd.Visible = showDatePickers;
        }


        
        private void GenerateReportButton_Click(object sender, EventArgs e)
        {
            
            if (!OccupancyReportRadioButton.Checked && !RevenueRadioButton.Checked)
            {
                MessageBox.Show("Please select a report type", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           
            DateTime startDate, endDate;
            if (AlltimeRB.Checked)
            {
                startDate = new DateTime(2023, 5, 1);
                endDate = DateTime.Today;
            }
            else if (todayRB.Checked)
            {
                startDate = DateTime.Today;
                endDate = DateTime.Today;
            }
            else if (SpecificRB.Checked)
            {
                startDate = DatePickerStart.Value.Date;
                endDate = DatePickerEnd.Value.Date;

                if (startDate > endDate)
                {
                    MessageBox.Show("Start date must be before end date", "Validation",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please select a date range option", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
               
                if (OccupancyReportRadioButton.Checked)
                {
                    GenerateOccupancyReport(startDate, endDate);
                }
                else
                {
                    GenerateRevenueReport(startDate, endDate);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating report: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #region report generation
        private void GenerateOccupancyReport(DateTime startDate, DateTime endDate)
        {
            ReportRichTextBox.Clear();
            _lastGeneratedReport = string.Empty;

            if ((endDate - startDate).TotalDays > 1000)
            {
                MessageBox.Show("Selected date range is too large. Please narrow it down to 2 years or less.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Task.Run(() =>
            {
            try
            {
                var report = _services.ReportingService.GenerateOccupancyReport(startDate, endDate);
                int fallbackTotalRooms = _services.RoomRepository.GetAll().Count;

                StringBuilder reportText = new StringBuilder();

                reportText.AppendLine("═══════════════════════════════════════════════════════════════════════");
                reportText.AppendLine("                        OCCUPANCY REPORT                               ");
                reportText.AppendLine("═══════════════════════════════════════════════════════════════════════");
                reportText.AppendLine();
                reportText.AppendLine($"Period: {startDate:yyyy-MM-dd} to {endDate:yyyy-MM-dd}");
                reportText.AppendLine($"Generated: {DateTime.Now:yyyy-MM-dd HH:mm:ss}");
                reportText.AppendLine();
                reportText.AppendLine("─────────────────────────────────────────────────────────────────────");
                reportText.AppendLine($"{"Date",-15} {"Total Rooms",12} {"Occupied",10} {"Available",10} {"Occupancy %",15}");
                reportText.AppendLine("─────────────────────────────────────────────────────────────────────");

                foreach (var daily in report.DailyOccupancies)
                {
                    reportText.AppendLine($"{daily.Date:yyyy-MM-dd,-15} {daily.TotalRooms,12} {daily.OccupiedRooms,10} {daily.AvailableRooms,10} {daily.OccupancyPercentage,14:F2}%");
                }

                reportText.AppendLine("─────────────────────────────────────────────────────────────────────");
                    if (report.DailyOccupancies.Any())
                    {
                        int totalRoomsForAverage = report.DailyOccupancies.FirstOrDefault()?.TotalRooms ?? fallbackTotalRooms;

                        reportText.AppendLine();
                        reportText.AppendLine("SUMMARY");
                        reportText.AppendLine("─────────────────────────────────────────────────────────────────────");
                        reportText.AppendLine($"Total Room Nights:     {report.TotalRoomNights}");
                        reportText.AppendLine($"Average Occupancy:     {report.AverageOccupancy:F2}%");
                        reportText.AppendLine($"Total Rooms:           {totalRoomsForAverage}");
                        reportText.AppendLine("═══════════════════════════════════════════════════════════════════════");
                    }
                    else
                    {
                        this.Invoke((MethodInvoker)delegate
                        {
                            MessageBox.Show("No occupancy data found for the selected period.", "No Data",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        });
                        return;
                    }

                    _lastGeneratedReport = reportText.ToString();

                    this.Invoke((MethodInvoker)delegate
                    {
                        ReportRichTextBox.Text = _lastGeneratedReport;

                        MessageBox.Show($"Occupancy Report Generated\n\n" +
                            $"Period: {startDate:yyyy-MM-dd} to {endDate:yyyy-MM-dd}\n" +
                            $"Average Occupancy: {report.AverageOccupancy:F2}%\n" +
                            $"Total Room Nights: {report.TotalRoomNights}",
                            "Report Generated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    });
                }
                catch (Exception ex)
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        MessageBox.Show($"Error generating occupancy report: {ex.Message}", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    });
                }
            });
        }
        private void GenerateRevenueReport(DateTime startDate, DateTime endDate)
        {
            ReportRichTextBox.Clear();
            _lastGeneratedReport = string.Empty;

            if ((endDate - startDate).TotalDays > 1000)
            {
                MessageBox.Show("Selected date range is too large. Please narrow it down to 2 years or less.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Task.Run(() =>
            {
                try
                {
                    var report = _services.ReportingService.GenerateRevenueReport(startDate, endDate);

                    if (report.TotalBookings == 0)
                    {
                        this.Invoke((MethodInvoker)delegate
                        {
                            MessageBox.Show("No bookings found for the selected period.", "No Data",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        });
                        return;
                    }

                    StringBuilder reportText = new StringBuilder();

                    reportText.AppendLine("═══════════════════════════════════════════════════════════════════════");
                    reportText.AppendLine("                         REVENUE REPORT                                ");
                    reportText.AppendLine("═══════════════════════════════════════════════════════════════════════");
                    reportText.AppendLine();
                    reportText.AppendLine($"Report Period:              {startDate:yyyy-MM-dd} to {endDate:yyyy-MM-dd}");
                    reportText.AppendLine($"Generated:                  {DateTime.Now:yyyy-MM-dd HH:mm:ss}");
                    reportText.AppendLine();
                    reportText.AppendLine("─────────────────────────────────────────────────────────────────────");
                    reportText.AppendLine("FINANCIAL SUMMARY");
                    reportText.AppendLine("─────────────────────────────────────────────────────────────────────");
                    reportText.AppendLine();
                    reportText.AppendLine($"Total Bookings:             {report.TotalBookings}");
                    reportText.AppendLine($"Total Revenue:              {report.TotalRevenue:C2}");
                    reportText.AppendLine($"Total Deposits Received:    {report.TotalDepositsReceived:C2}");
                    reportText.AppendLine($"Average Booking Value:      {report.AverageBookingValue:C2}");
                    reportText.AppendLine();
                    reportText.AppendLine("═══════════════════════════════════════════════════════════════════════");

                    _lastGeneratedReport = reportText.ToString();

                    this.Invoke((MethodInvoker)delegate
                    {
                        ReportRichTextBox.Text = _lastGeneratedReport;

                        MessageBox.Show($"Revenue Report Generated\n\n" +
                            $"Total Bookings: {report.TotalBookings}\n" +
                            $"Total Revenue: {report.TotalRevenue:C2}\n" +
                            $"Average Booking: {report.AverageBookingValue:C2}",
                            "Report Generated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    });
                }
                catch (Exception ex)
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        MessageBox.Show($"Error generating revenue report: {ex.Message}", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    });
                }
            });
        }
        #endregion
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_lastGeneratedReport))
            {
                MessageBox.Show("No report data to save. Please generate a report first.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog saveDialog = new SaveFileDialog
            {
                Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*",
                DefaultExt = "txt",
                FileName = $"Report_{DateTime.Now:yyyyMMdd_HHmmss}.txt"
            };

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.WriteAllText(saveDialog.FileName, _lastGeneratedReport);

                    MessageBox.Show($"Report saved successfully to:\n{saveDialog.FileName}",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving report: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void SpecificRB_CheckedChanged(object sender, EventArgs e)
        {
            DateRangeOption_CheckedChanged(sender, e);
        }

        private void todayRB_CheckedChanged(object sender, EventArgs e)
        {
            DateRangeOption_CheckedChanged(sender, e);
        }

        private void AlltimeRB_CheckedChanged(object sender, EventArgs e)
        {
            DateRangeOption_CheckedChanged(sender, e);
        }

        private void DatePickerEnd_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void DatePickerStart_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void FrmReports_Load(object sender, EventArgs e)
        {

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ReportRichTextBox.Clear();
            _lastGeneratedReport = string.Empty;
        }
    }
}