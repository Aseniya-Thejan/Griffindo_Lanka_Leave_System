# Leave Management System - Griffindo Lanka Toys (Pvt) Ltd
## Activity 4: GUI System, Debugging & Coding Standards

---

## PROJECT OVERVIEW

This is a complete Leave Management System built with C# .NET Framework 4.7.2 Windows Forms for Griffindo Lanka Toys (Pvt) Ltd. The system allows employees to apply for leaves and administrators to manage leave types, approve/reject leave requests, and generate reports.

---

## DATABASE CONNECTION

The application connects to SQL Server using the following connection string:

```
Data Source=LAPTOP-F9EU6O5J\SQLEXPRESS;Initial Catalog=LeaveDB;Integrated Security=True;
```

**IMPORTANT:** The database and all tables must already exist. This application does NOT create the database or tables.

---

## DATABASE SCHEMA (For Reference Only)

The following tables must exist in the LeaveDB database:

### 1. Employee
- EmployeeID (INT, Primary Key, Identity)
- FullName (NVARCHAR(100))
- Email (NVARCHAR(100), Unique)
- Department (NVARCHAR(50))
- Designation (NVARCHAR(50))
- DateOfJoin (DATE)
- EmploymentStatus (NVARCHAR(20))

### 2. Admin
- AdminID (INT, Primary Key, Identity)
- FullName (NVARCHAR(100))
- Email (NVARCHAR(100), Unique)
- Role (NVARCHAR(50))
- Department (NVARCHAR(50))
- IsActive (BIT)

### 3. LeaveTypes
- LeaveTypeID (INT, Primary Key, Identity)
- LeaveName (NVARCHAR(50), Unique)
- MaxDaysPerYear (INT)
- IsPaid (BIT)

### 4. AppliedLeaves
- LeaveRequestID (INT, Primary Key, Identity)
- EmployeeID (INT)
- LeaveTypeID (INT)
- AdminID (INT, Nullable)
- StartDate (DATE)
- EndDate (DATE)
- NumberOfDays (INT)
- Status (NVARCHAR(20))
- Reason (NVARCHAR(255))
- RequestedOn (DATETIME)
- DecisionDate (DATETIME, Nullable)

### 5. Login
- LoginID (INT, Primary Key, Identity)
- Username (NVARCHAR(50), Unique)
- PasswordHash (NVARCHAR(255))
- UserRole (NVARCHAR(20)) - 'Employee' or 'Admin'
- LinkedEmployeeID (INT, Nullable)
- LinkedAdminID (INT, Nullable)
- IsLocked (BIT)

---

## APPLICATION STRUCTURE

### Core Components

1. **DbHelper.cs** - Static database helper class with GetConnection() method
2. **FrmStartup** - Main startup form to select Employee or Admin login

### Employee Module

1. **FrmEmployeeLogin** - Employee authentication
2. **FrmEmployeeDashboard** - Main employee dashboard
3. **FrmApplyLeave** - Submit new leave requests
4. **FrmLeaveHistory** - View all leave request history
5. **FrmDeleteLeave** - Delete pending leave requests
6. **FrmRemainingLeaves** - View remaining leave balances

### Admin Module

1. **FrmAdminLogin** - Admin authentication
2. **FrmAdminDashboard** - Main admin dashboard
3. **FrmRegisterEmployee** - Register new employees with auto-generated login credentials
4. **FrmManageLeaveTypes** - Edit leave types (MaxDaysPerYear, IsPaid)
5. **FrmApproveRejectLeaves** - Approve or reject pending leave requests
6. **FrmGenerateReports** - View reports by employee, leave type, or status

---

## HOW TO USE THE APPLICATION

### Starting the Application

1. Run the application
2. The **Startup Form** will appear with two options:
   - Employee Login
   - Admin Login
3. Select the appropriate option

### Employee Module

#### Login
- Enter your username and password
- Username is typically the part before @ in your email
- Default password for new employees: "Employee123"

#### Dashboard Options
- **Apply Leave**: Submit a new leave request
- **Leave History**: View all your leave requests and their status
- **Delete Leave Request**: Cancel a pending leave request
- **Remaining Leaves**: View your leave balances by leave type
- **Logout**: Return to startup screen

#### Applying for Leave
1. Select leave type from dropdown
2. Choose start date and end date
3. Enter reason for leave
4. Click Submit
5. System automatically calculates number of days

#### Deleting Leave Request
1. Only PENDING requests can be deleted
2. Select a request from the grid
3. Click "Delete Selected"
4. Confirm deletion

### Admin Module

#### Login
- Enter admin username and password
- Admin credentials are created separately in the database

#### Dashboard Options
- **Register Employee**: Add new employees to the system
- **Manage Leave Types**: Edit leave type settings
- **Approve/Reject Leaves**: Process pending leave requests
- **Generate Reports**: View statistical reports
- **Logout**: Return to startup screen

#### Registering New Employees
1. Enter all employee details (Full Name, Email, Department, Designation, Date of Join)
2. Click Save
3. System automatically:
   - Creates employee record
   - Generates username (from email)
   - Creates login with default password "Employee123"
4. Display shows the generated credentials

#### Managing Leave Types
1. Grid displays all leave types
2. Edit MaxDaysPerYear and IsPaid columns directly in the grid
3. Click "Save Changes" to update the database
4. LeaveName and LeaveTypeID cannot be edited

#### Approving/Rejecting Leaves
1. Grid shows all pending leave requests with employee details
2. Select a request
3. Click "Approve" or "Reject"
4. Confirm your decision
5. System updates status, records AdminID, and sets DecisionDate

#### Generating Reports
Three report types available:
- **By Employee**: Shows leave statistics per employee
- **By Leave Type**: Shows usage statistics per leave type
- **By Status**: Shows distribution of leave requests by status (Approved, Rejected, Pending)

---

## CODING STANDARDS FOLLOWED

### Naming Conventions
- **PascalCase**: Methods, properties, classes (e.g., LoadLeaveTypes, EmployeeID)
- **camelCase**: Local variables, parameters (e.g., employeeId, fullName)
- **Control Naming**: Prefixed with type (e.g., txtUsername, btnLogin, dgvHistory)

### Database Access
- All database operations use ADO.NET (SqlConnection, SqlCommand, SqlDataReader, SqlDataAdapter)
- Parameterized queries only (no SQL injection vulnerabilities)
- using blocks for proper resource disposal
- Try-catch blocks for error handling
- User-friendly error messages via MessageBox

### Form Standards
- All forms centered on screen: StartPosition = FormStartPosition.CenterScreen
- Fixed border: FormBorderStyle = FormBorderStyle.FixedSingle
- MaximizeBox = false for consistency
- Constructors receive necessary data (e.g., employeeId, adminId)

### Security Features
- Password fields use UseSystemPasswordChar = true
- Account locking support (IsLocked column)
- Active status checks (EmploymentStatus, IsActive)
- Role-based authentication (Employee vs Admin)

### User Experience
- Clear buttons reset all inputs
- Validation before database operations
- Success/error messages displayed in labels or MessageBox
- Confirmation dialogs for delete/logout operations
- DataGridView columns have readable headers
- Read-only grids where appropriate

---

## TESTING CHECKLIST

### Employee Module
- [ ] Login with valid credentials
- [ ] Login with invalid credentials
- [ ] Apply leave with all fields filled
- [ ] Apply leave with missing fields (validation)
- [ ] View leave history
- [ ] Delete pending leave request
- [ ] Try to delete approved/rejected leave (should not appear)
- [ ] View remaining leaves

### Admin Module
- [ ] Login with valid admin credentials
- [ ] Register new employee with all fields
- [ ] Register employee with duplicate email (should fail gracefully)
- [ ] Edit leave type settings and save
- [ ] Approve pending leave request
- [ ] Reject pending leave request
- [ ] Generate employee report
- [ ] Generate leave type report
- [ ] Generate status report

---

## DEFAULT CREDENTIALS (For Testing)

You need to manually insert test data into the Login table:

### Sample Employee Login
```sql
INSERT INTO Login (Username, PasswordHash, UserRole, LinkedEmployeeID, LinkedAdminID, IsLocked)
VALUES ('testemployee', 'Employee123', 'Employee', 1, NULL, 0);
```

### Sample Admin Login
```sql
INSERT INTO Login (Username, PasswordHash, UserRole, LinkedEmployeeID, LinkedAdminID, IsLocked)
VALUES ('testadmin', 'Admin123', 'Admin', NULL, 1, 0);
```

**Note**: In production, passwords should be hashed. For this academic project, plain text is used for simplicity.

---

## KNOWN FEATURES

1. **Auto-calculated Leave Days**: System automatically calculates (EndDate - StartDate) + 1
2. **Email Validation**: System validates email format when registering employees
3. **Username Generation**: Automatically extracts username from email (part before @)
4. **Leave Balance Calculation**: Only counts APPROVED leaves against balance
5. **Pending-Only Deletion**: Employees can only delete PENDING requests
6. **Admin Tracking**: System records which admin approved/rejected each request

---

## TROUBLESHOOTING

### "Cannot open database LeaveDB"
- Ensure SQL Server is running
- Verify the database exists
- Check connection string in DbHelper.cs

### "Invalid object name 'TableName'"
- Ensure all tables exist in the database
- Run the CREATE TABLE scripts

### "Login failed for user"
- Check Windows Authentication is enabled
- Verify SQL Server allows Windows Authentication

### Form doesn't appear
- Check that form is set to ShowDialog() or Show()
- Verify form is not hidden behind other windows

---

## ACADEMIC REQUIREMENTS MET

? Windows Forms GUI application  
? .NET Framework 4.7.2  
? SQL Server database integration  
? ADO.NET (no Entity Framework)  
? Parameterized queries  
? C# coding standards  
? Meaningful control names  
? Error handling with try-catch  
? User input validation  
? Professional UI layout  
? Complete CRUD operations  
? Reporting functionality  

---

## PROJECT FILES

### Forms (26 files)
- FrmStartup.cs / .Designer.cs
- FrmEmployeeLogin.cs / .Designer.cs
- FrmEmployeeDashboard.cs / .Designer.cs
- FrmApplyLeave.cs / .Designer.cs
- FrmLeaveHistory.cs / .Designer.cs
- FrmDeleteLeave.cs / .Designer.cs
- FrmRemainingLeaves.cs / .Designer.cs
- FrmAdminLogin.cs / .Designer.cs
- FrmAdminDashboard.cs / .Designer.cs
- FrmRegisterEmployee.cs / .Designer.cs
- FrmManageLeaveTypes.cs / .Designer.cs
- FrmApproveRejectLeaves.cs / .Designer.cs
- FrmGenerateReports.cs / .Designer.cs

### Helpers (1 file)
- DbHelper.cs

### Entry Point (1 file)
- Program.cs (modified)

---

## SUBMISSION NOTES

This project demonstrates:
1. Professional Windows Forms development
2. Proper database connectivity and operations
3. Secure parameterized SQL queries
4. Clean separation of concerns (Employee vs Admin modules)
5. User-friendly interface with validation
6. Comprehensive error handling
7. Following C# coding standards and naming conventions

---

## AUTHOR

**Student Name**: [Your Name]  
**Course**: Activity 4 - GUI System, Debugging & Coding Standards  
**Institution**: [Your Institution]  
**Date**: [Current Date]  
**Framework**: .NET Framework 4.7.2  
**Language**: C#  
**Database**: SQL Server (LeaveDB)

---

## LICENSE

This is an academic project for educational purposes only.
© Griffindo Lanka Toys (Pvt) Ltd - Leave Management System
