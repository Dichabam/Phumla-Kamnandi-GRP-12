using Phumla_Kamnandi_GRP_12.Business;
using Phumla_Kamnandi_GRP_12.Business.Interfaces;
using Phumla_Kamnandi_GRP_12.Business.Services;

namespace Phumla_Kamnandi_GRP_12
{

    /// Singleton class to manage all business services and repositories
    /// This acts as our dependency injection container
   
    public class ServiceLocator
    {
        private static ServiceLocator _instance;
        private static readonly object _lock = new object();

     
        public BookingRepositoryInterface BookingRepository { get; private set; }
        public GuestRepositoryInterface GuestRepository { get; private set; }
        public RoomRepositoryInterface RoomRepository { get; private set; }

    
        public BookingServiceInterface BookingService { get; private set; }
        public GuestServiceInterface GuestService { get; private set; }
        public PricingServiceInterface PricingService { get; private set; }
        public ReportingServiceInterface ReportingService { get; private set; }

        // Current logged in user
        public string CurrentUserEmail { get; set; }
        public string CurrentUserName { get; set; }
        public string CurrentGuestId { get; set; }

        private ServiceLocator()
        {
            InitializeServices();
        }

        public static ServiceLocator Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new ServiceLocator();
                        }
                    }
                }
                return _instance;
            }
        }

        private void InitializeServices()
        {
            // Initialize repositories (using mock implementations)
            BookingRepository = new MockBookingRepository();
            GuestRepository = new MockGuestRepository();
            RoomRepository = new MockRoomRepository();

            // Initialize services with dependencies
            PricingService = new PricingService();
            GuestService = new GuestService(GuestRepository, BookingRepository);
            BookingService = new BookingService(BookingRepository, GuestRepository, RoomRepository, PricingService);
            ReportingService = new ReportingService(BookingRepository, RoomRepository);

            // Add some initial test data for employees/admin
            InitializeTestData();
        }

        private void InitializeTestData()
        {
            // Add admin/employee accounts for testing
            // These would normally come from a database
            var adminGuest = GuestRepository.GetByEmail("admin@phumlakamnandi.co.za");
            if (adminGuest == null)
            {
                GuestService.RegisterNewGuest("Admin", "User", "admin@phumlakamnandi.co.za",
                    "0211234567", "Hotel Management Office");
            }

            // Employee account
            var employeeGuest = GuestRepository.GetByEmail("employee@phumlakamnandi.co.za");
            if (employeeGuest == null)
            {
                GuestService.RegisterNewGuest("Employee", "One", "employee@phumlakamnandi.co.za",
                    "0211234568", "Hotel Reception");
            }
        }

        public void ClearSession()
        {
            CurrentUserEmail = null;
            CurrentUserName = null;
            CurrentGuestId = null;
        }
    }
}