using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Phumla_Kamnandi_GRP_12.Presentation
{
    public partial class FrmReports : Form
    {
        private ServiceLocator _services;

        public FrmReports()
        {
            InitializeComponent();
            _services = ServiceLocator.Instance;
            InitializeForm();
        }

        private void InitializeForm()
        {
            // Hide date controls by default
            FromLabel.Visible = false;
            ToLabel.Visible = false;
            DatePickerStart.Visible = false;
            DatePickerEnd.Visible = false;

            // Set default radio button
            AlltimeRB.Checked = true;

            // Wire up events
            GenerateReportButton.Click += GenerateReportButton_Click;
            saveButton.Click += saveButton_Click;
        }

        private void DateRangeOption_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (!rb.Checked) return;

            // Show/hide date pickers based on selection
            bool showDatePickers = rb == SpecificRB;
            FromLabel.Visible = showDatePickers;
            ToLabel.Visible = showDatePickers;
            DatePickerStart.Visible = showDatePickers;
            DatePickerEnd.Visible = showDatePickers;
        }

        private void GenerateReportButton_Click(object sender, EventArgs e)
        {
            // Validate report type selection
            if (!OccupancyReportRadioButton.Checked && !RevenueRadioButton.Checked)
            {
                MessageBox.Show("Please select a report type", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Determine date range
            DateTime startDate, endDate;
            if (AlltimeRB.Checked)
            {
                startDate = new DateTime(2020, 1, 1); // Or earliest booking date
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

            // Generate appropriate report
            if (OccupancyReportRadioButton.Checked)
            {
                GenerateOccupancyReport(startDate, endDate);
            }
            else
            {
                GenerateRevenueReport(startDate, endDate);
            }
        }

        private void GenerateOccupancyReport(DateTime startDate, DateTime endDate)
        {
            try
            {
                var report = _services.ReportingService.GenerateOccupancyReport(startDate, endDate);

                // Create DataTable for display
                DataTable dt = new DataTable();
                dt.Columns.Add("Date", typeof(string));
                dt.Columns.Add("Total Rooms", typeof(int));
                dt.Columns.Add("Occupied Rooms", typeof(int));
                dt.Columns.Add("Available Rooms", typeof(int));
                dt.Columns.Add("Occupancy %", typeof(string));

                foreach (var daily in report.DailyOccupancies)
                {
                    dt.Rows.Add(
                        daily.Date.ToString("yyyy-MM-dd"),
                        daily.TotalRooms,
                        daily.OccupiedRooms,
                        daily.AvailableRooms,
                        daily.OccupancyPercentage.ToString("F2") + "%"
                    );
                }

                // Add summary row
                dt.Rows.Add(
                    "AVERAGE",
                    report.DailyOccupancies.First().TotalRooms,
                    "",
                    "",
                    report.AverageOccupancy.ToString("F2") + "%"
                );

                ReportDataview.DataSource = dt;

                // Format summary row
                if (ReportDataview.Rows.Count > 0)
                {
                    var lastRow = ReportDataview.Rows[ReportDataview.Rows.Count - 1];
                    lastRow.DefaultCellStyle.Font = new System.Drawing.Font(ReportDataview.Font, System.Drawing.FontStyle.Bold);
                    lastRow.DefaultCellStyle.BackColor = System.Drawing.Color.LightBlue;
                }

                MessageBox.Show($"Occupancy Report Generated\n\n" +
                    $"Period: {startDate:yyyy-MM-dd} to {endDate:yyyy-MM-dd}\n" +
                    $"Average Occupancy: {report.AverageOccupancy:F2}%\n" +
                    $"Total Room Nights: {report.TotalRoomNights}",
                    "Report Generated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating report: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GenerateRevenueReport(DateTime startDate, DateTime endDate)
        {
            try
            {
                var report = _services.ReportingService.GenerateRevenueReport(startDate, endDate);

                // Create DataTable for display
                DataTable dt = new DataTable();
                dt.Columns.Add("Metric", typeof(string));
                dt.Columns.Add("Value", typeof(string));

                dt.Rows.Add("Report Period", $"{startDate:yyyy-MM-dd} to {endDate:yyyy-MM-dd}");
                dt.Rows.Add("Total Bookings", report.TotalBookings.ToString());
                dt.Rows.Add("Total Revenue", report.TotalRevenue.ToString("C2"));
                dt.Rows.Add("Total Deposits Received", report.TotalDepositsReceived.ToString("C2"));
                dt.Rows.Add("Average Booking Value", report.AverageBookingValue.ToString("C2"));

                ReportDataview.DataSource = dt;

                // Format the grid
                ReportDataview.Columns[0].Width = 250;
                ReportDataview.Columns[1].Width = 200;
                ReportDataview.Columns[0].DefaultCellStyle.Font =
                    new System.Drawing.Font(ReportDataview.Font, System.Drawing.FontStyle.Bold);

                MessageBox.Show($"Revenue Report Generated\n\n" +
                    $"Total Bookings: {report.TotalBookings}\n" +
                    $"Total Revenue: {report.TotalRevenue:C2}\n" +
                    $"Average Booking: {report.AverageBookingValue:C2}",
                    "Report Generated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating report: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void SpecificRB_CheckedChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void todayRB_CheckedChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AlltimeRB_CheckedChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DatePickerEnd_ValueChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DatePickerStart_ValueChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OccupancyReportRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (ReportDataview.DataSource == null || ReportDataview.Rows.Count == 0)
            {
                MessageBox.Show("No report data to save", "Warning",
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
                    StringBuilder sb = new StringBuilder();

                    // Add header
                    string reportType = OccupancyReportRadioButton.Checked ? "Occupancy" : "Revenue";
                    sb.AppendLine($"=== {reportType} Report ===");
                    sb.AppendLine($"Generated: {DateTime.Now:yyyy-MM-dd HH:mm:ss}");
                    sb.AppendLine();

                    // Add column headers
                    foreach (DataGridViewColumn col in ReportDataview.Columns)
                    {
                        sb.Append(col.HeaderText.PadRight(20) + "\t");
                    }
                    sb.AppendLine();
                    sb.AppendLine(new string('-', 80));

                    // Add data rows
                    foreach (DataGridViewRow row in ReportDataview.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                sb.Append((cell.Value?.ToString() ?? "").PadRight(20) + "\t");
                            }
                            sb.AppendLine();
                        }
                    }

                    File.WriteAllText(saveDialog.FileName, sb.ToString());

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

        private void RevenueRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}