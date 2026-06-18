# Employee Management System

Group project for **COSC 31112 / BECS 31242 – Visual Programming**.

Built with **C# WinForms (.NET)** and **MySQL (phpMyAdmin)**.

## Tech Stack

* C# / .NET (Windows Forms)
* MySQL
* phpMyAdmin
* Visual Studio 2022+

## Project Structure

```text
Employee_Management_System/
├── Employee_Managment.slnx          # Solution file
├── database/
│   └── EMS_DB_MySQL.sql             # MySQL database script
├── docs/
│   └── screenshots/
├── Employee_Managment_System/
│   ├── Program.cs
│   ├── Models/
│   ├── DataAccess/
│   └── Forms/
│       ├── Login/
│       ├── Dashboard/
│       ├── Employee/
│       ├── Department/
│       ├── Attendance/
│       ├── Leave/
│       ├── Payroll/
│       └── Reports/
└── README.md
```

## Team Members & Modules

| Module                | Member Name | Status        |
| --------------------- | ----------- | ------------- |
| Login                 |             |               |
| Dashboard             |             |               |
| Employee Management   | Dilshani    | ✅ In Progress |
| Department Management |             |               |
| Attendance Management |             |               |
| Leave Management      |             |               |
| Payroll Management    |             |               |
| Reports               |             |               |

## Database Setup

1. Start Apache and MySQL in XAMPP.
2. Open phpMyAdmin.
3. Create a database named `EMS_DB`.
4. Import the file:

```text
database/EMS_DB_MySQL.sql
```

5. Execute the script to create all tables.

## Getting Started

1. Clone the repository:

```bash
git clone <repository-url>
```

2. Open `Employee_Managment.slnx` in Visual Studio.

3. Restore NuGet packages if prompted.

4. Configure the MySQL connection string.

5. Run the project.

## Branching Workflow

Create a branch before starting development:

```bash
git checkout -b feature/module-name
```

Commit changes:

```bash
git add .
git commit -m "Add module"
git push origin feature/module-name
```

Create a Pull Request to merge into `main`.

## Important Notes

* Do not commit `bin/` or `obj/` folders.
* Do not commit `.csproj.user` files.
* Keep database changes updated in `EMS_DB_MySQL.sql`.
* All team members should work in separate branches and submit Pull Requests.
