# Phumla Kamnandi Hotel Management System (Group 12)

A comprehensive Windows Forms application designed to manage hotel operations for **Phumla Kamnandi Hotels**. This system streamlines the booking process, guest management, and reporting for hotel staff and administrators.

##  Table of Contents
- [About the Project](#about-the-project)
- [Features](#features)
- [Technologies Used](#technologies-used)
- [Getting Started](#getting-started)
- [Team Members](#team-members)

##  About the Project
The **Phumla Kamnandi Hotel Management System** allows hotel staff to efficiently manage room reservations and guest details. It prevents booking conflicts, calculates costs automatically (including seasonal rates), and generates essential business reports. The application features a role-based login system, separating standard employee functions from administrative tasks.

##  Features

### Booking Management
* **Create Bookings**: Check room availability in real-time and create new reservations.
* **Modify/Cancel**: Change dates or cancel existing bookings with automatic penalty calculations.
* **Validation**: Prevents double-booking and validates check-in/check-out dates.
* **Confirmation**: Generates booking confirmation letters automatically.

###  Guest Services
* **Guest Profiles**: Create and maintain guest records with contact details.
* **History**: View booking history for returning guests.
* **Credit Card Verification**: Securely capture payment details for deposits.

###  Room Operations
* **Availability Checker**: Visual dashboard to see occupied and available rooms.
* **Room Types**: Support for various room configurations and occupancy limits.

###  Reports & Analytics
* **Occupancy Report**: View daily occupancy rates to track hotel performance.
* **Revenue Report**: Generate financial reports to monitor income.

###  Security & Admin
* **Authentication**: Secure login screen for employees.
* **Role-Based Access**: 
    * *Employees*: Manage bookings and guests.
    * *Admins*: Access to sensitive reports and employee management.

##  Technologies Used
* **Language**: C#
* **Framework**: .NET Framework (Windows Forms)
* **Database**: Microsoft SQL Server (LocalDB/MDF)
* **IDE**: Visual Studio
* **Architecture**: Layered Architecture (Presentation, Business, Database/Data Layers)

##  Getting Started

### Prerequisites
* Visual Studio 2019 or later.
* .NET Framework installed.
* SQL Server (or LocalDB included with VS).

### Installation
1.  **Clone the repository** (or extract the zip file).
2.  **Open the Solution**:
    * Navigate to the folder and double-click `Phumla Kamnandi GRP-12.sln` to open in Visual Studio.
3.  **Restore Packages**:
    * Right-click the solution in Solution Explorer and select "Restore NuGet Packages".
4.  **Database Setup**:
    * Ensure the `PhumlaKamnandiDB.mdf` file is in the correct directory.
    * If necessary, update the connection string in `App.config` to point to your local instance.
5.  **Run the Application**:
    * Press `F5` or click **Start**.
6.  **Note**:
    * the mdf file does not work well with git so therefore try to make sure it is there but do not be shocked if initially it is not there.


##  Team Members (Group 12)

* **Dichaba Mofokeng** (MFKDIC001)
* **Khumiso Motata** (MTTKAG001)
* **Simon Baraka** (LMDSIM001)
* **Rearabilwe Kgokong** (KGKREA001)

---
*Semester Project - Information Systems*
*.Received 82% for the project*






---
*Note the project contains some error dues to rushed implementation*
