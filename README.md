<<<<<<< HEAD
# Employee Management System

Group project for **COSC 31112 / BECS 31242 – Visual Programming**.
Built with C# WinForms (.NET) and SQL Server.

## Tech Stack
- C# / .NET (Windows Forms)
- Microsoft SQL Server (via Microsoft.Data.SqlClient)
- Visual Studio 2022+

## Project Structure

```
EmployeeManagementSystem/
├── Employee_Managment.slnx          # Solution file - open this in Visual Studio
├── database/                        # Exported .sql file for final submission
├── docs/                            # Screenshots + diagrams for documentation
└── Employee_Managment/              # Main project folder
    ├── Program.cs                   # App entry point
    ├── Models/                      # Shared data classes (Employee, Department, etc.)
    ├── DataAccess/                  # Shared DB connection logic
    └── Forms/
        ├── Login/
        ├── Dashboard/
        ├── Employee/
        ├── Department/
        ├── Attendance/
        ├── Leave/
        ├── Payroll/
        └── Reports/
```

## Team Members & Modules

| Module | Member Name | Status |
|---|---|---|
| Login | | |
| Dashboard | | |
| Employee Management | Dilshani | ✅ In progress |
| Department Management | | |
| Attendance Management | | |
| Leave Management | | |
| Payroll Management | | |
| Reports | | |

## Getting Started (for all team members)

1. Clone the repo:
   ```
   git clone <repo-url>
   ```
2. Open `Employee_Managment.slnx` in Visual Studio.
3. Do **not** create a new project or solution — everyone shares this one project.
4. Add your form files inside your assigned folder under `Employee_Managment/Forms/`.
5. You do **not** need to edit the `.csproj` file — any `.cs` file added inside the
   project folder is picked up automatically when building.

## Branching Workflow

1. Create a branch for your module before starting work:
   ```
   git checkout -b feature/your-module-name
   ```
2. Commit and push your branch:
   ```
   git add .
   git commit -m "Add Login form"
   git push origin feature/your-module-name
   ```
3. Open a Pull Request into `main` when your form is ready.
4. Do not push directly to `main`.

## Shared Resources

- **Models** (`Employee`, `Department`, `Designation`, `User`) live in `Employee_Managment/Models/`.
  If your form needs employee/department data, reference these classes instead of
  creating your own duplicate versions.
- **Database connection** logic will live in `Employee_Managment/DataAccess/DBConnection.cs`
  once the team agrees on a shared connection string / database name.

## Important Notes

- Never commit `bin/` or `obj/` folders (already handled by `.gitignore`).
- Never commit `.csproj.user` files (personal IDE settings).
- Formal attire + 10 min early arrival for the viva. All members must attend.
- Final submission deadline: **21/06/2026, 11:59 PM**.
=======
# Employee-Management-System
>>>>>>> 4b4719b08ac10fd30a4b1407cb415c3c8d3857a1
