// Services/ReportingService.cs
using Phumla_Kamnandi_GRP_12.Business.Entities;
using Phumla_Kamnandi_GRP_12.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Phumla_Kamnandi_GRP_12.Business.Services
{
    public class ReportingService : IReportingService
    {
        private readonly BookingRepositoryInterface _bookingRepository;
        private readonly RoomRepositoryInterface _roomRepository;

        public ReportingService(BookingRepositoryInterface bookingRepo, RoomRepositoryInterface roomRepo)
        {
            _bookingRepository = bookingRepo;
            _roomRepository = roomRepo;
        }

        public OccupancyReport GenerateOccupancyReport(DateTime startDate, DateTime endDate)
        {
            var report = new OccupancyReport
            {
                StartDate = startDate,
                EndDate = endDate,
                DailyOccupancies = new List<DailyOccupancy>()
            };

            int totalRooms = _roomRepository.GetAll().Count;

            for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
            {
                var bookingsForDate = _bookingRepository.GetActiveBookingsForDate(date);
                int occupiedRooms = bookingsForDate.Count;

                var daily = new DailyOccupancy
                {
                    Date = date,
                    TotalRooms = totalRooms,
                    OccupiedRooms = occupiedRooms,
                    AvailableRooms = totalRooms - occupiedRooms,
                    OccupancyPercentage = (decimal)occupiedRooms / totalRooms * 100
                };

                report.DailyOccupancies.Add(daily);
            }

            // Calculate averages
            if (report.DailyOccupancies.Any())
            {
                report.AverageOccupancy = report.DailyOccupancies.Average(d => d.OccupancyPercentage);
                report.TotalRoomNights = report.DailyOccupancies.Sum(d => d.OccupiedRooms);
            }

            return report;
        }

        public RevenueReport GenerateRevenueReport(DateTime startDate, DateTime endDate)
        {
            var bookings = _bookingRepository.GetByDateRange(startDate, endDate);

            var report = new RevenueReport
            {
                StartDate = startDate,
                EndDate = endDate,
                TotalBookings = bookings.Count,
                TotalRevenue = bookings.Sum(b => b.TotalAmount),
                TotalDepositsReceived = bookings.Sum(b => b.DepositPaid),
                AverageBookingValue = bookings.Any() ? bookings.Average(b => b.TotalAmount) : 0
            };

            return report;
        }
    }

    public interface IReportingService
    {
        OccupancyReport GenerateOccupancyReport(DateTime startDate, DateTime endDate);
        RevenueReport GenerateRevenueReport(DateTime startDate, DateTime endDate);
    }
}