using Phumla_Kamnandi_GRP_12.Business;
using Phumla_Kamnandi_GRP_12.Business.Entities;
using Phumla_Kamnandi_GRP_12.Business.Interfaces;
using Phumla_Kamnandi_GRP_12.Business.Services;

namespace Phumla_Kamnandi_GRP_12
{
    /// <summary>
    /// Singleton class to manage all business services and repositories
    /// This acts as our dependency injection container
    /// </summary>
    public class ServiceLocator
    {
        private static ServiceLocator _instance;
        private static readonly object _lock = new object();

        // Repositories
        public BookingRepositoryInterface BookingRepository { get; private set; }
        public GuestRepositoryInterface GuestRepository { get; private set; }
        public RoomRepositoryInterface RoomRepository { get; private set; }
        public EmployeeRepositoryInterface EmployeeRepository { get; private set; }

        // Services
        public BookingServiceInterface BookingService { get; private set; }
        public GuestServiceInterface GuestService { get; private set; }
        public PricingServiceInterface PricingService { get; private set; }
        public ReportingServiceInterface ReportingService { get; private set; }
        public EmployeeServiceInterface EmployeeService { get; private set; }

        // Session management - stores currently logged in user
        private string _currentUserEmail;
        private string _currentUserName;
        private string _currentUserId;
        private bool _isEmployee;
        private Employee _currentEmployee;

        public string CurrentUserEmail
        {
            get => _currentUserEmail;
            set => _currentUserEmail = value;
        }

        public string CurrentUserName
        {
            get => _currentUserName;
            set => _currentUserName = value;
        }

        public string CurrentUserId
        {
            get => _currentUserId;
            set => _currentUserId = value;
        }

        public bool IsEmployee
        {
            get => _isEmployee;
            set => _isEmployee = value;
        }

        public bool IsAdmin
        {
            get => _currentEmployee != null && _currentEmployee.IsAdmin();
        }

        public Employee CurrentEmployee
        {
            get => _currentEmployee;
            set => _currentEmployee = value;
        }

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
            BookingRepository = new BookingRepositoryInterface();
            GuestRepository = new GuestRepositoryInterface();
            RoomRepository = new RoomRepositoryInterface();
            EmployeeRepository = new EmployeeRepositoryInterface();

            // Initialize services with dependencies
            PricingService = new PricingService();
            GuestService = new GuestService(GuestRepository, BookingRepository);
            BookingService = new BookingService(BookingRepository, GuestRepository, RoomRepository, PricingService);
            ReportingService = new ReportingService(BookingRepository, RoomRepository);
            EmployeeService = new EmployeeService(EmployeeRepository);
        }

        public void SetEmployeeSession(Employee employee)
        {
            CurrentEmployee = employee;
            CurrentUserEmail = employee.Email;
            CurrentUserName = employee.FullName;
            CurrentUserId = employee.EmployeeId;
            IsEmployee = true;
            IsAdmin = employee.IsAdmin();
        }

        public void ClearSession()
        {
            CurrentUserEmail = null;
            CurrentUserName = null;
            CurrentUserId = null;
            IsEmployee = false;
            IsAdmin = false;
            CurrentEmployee = null;
        }
    }
}