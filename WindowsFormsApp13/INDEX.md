# INDEX - Leave Management System Files
## Griffindo Lanka Toys (Pvt) Ltd

---

## ?? COMPLETE FILE LISTING

### ? CORE APPLICATION FILES (2 files)

1. **Program.cs**
   - Entry point of application
   - Launches FrmStartup
   - Modified to use startup screen

2. **DbHelper.cs**
   - Static database helper class
   - GetConnection() method
   - Connection string: Data Source=LAPTOP-F9EU6O5J\SQLEXPRESS;Initial Catalog=LeaveDB;Integrated Security=True;

---

### ? STARTUP MODULE (2 files)

3. **FrmStartup.cs**
   - Main startup form
   - Employee/Admin login selection
   - Exit option

4. **FrmStartup.Designer.cs**
   - Designer file for FrmStartup
   - UI components initialization

---

### ? EMPLOYEE MODULE (12 files - 6 forms)

#### Employee Login
5. **FrmEmployeeLogin.cs**
   - Employee authentication
   - Username/password validation
   - Opens FrmEmployeeDashboard on success

6. **FrmEmployeeLogin.Designer.cs**
   - Designer file
   - txtUsername, txtPassword, btnLogin, btnClear, lblError, picLogo

#### Employee Dashboard
7. **FrmEmployeeDashboard.cs**
   - Main employee menu
   - Buttons: Apply Leave, Leave History, Delete Leave, Remaining Leaves, Logout
   - Receives employeeId and fullName in constructor

8. **FrmEmployeeDashboard.Designer.cs**
   - Designer file
   - 5 navigation buttons + welcome label

#### Apply Leave
9. **FrmApplyLeave.cs**
   - Submit new leave requests
   - Auto-calculate number of days
   - Validation: leave type, dates, reason
   - INSERT into AppliedLeaves

10. **FrmApplyLeave.Designer.cs**
    - Designer file
    - cmbLeaveType, dtpStartDate, dtpEndDate, txtReason, btnSubmit, btnClear

#### Leave History
11. **FrmLeaveHistory.cs**
    - View all leave requests
    - Shows: LeaveRequestID, LeaveName, Dates, Days, Status, RequestedOn, DecisionDate
    - DataGridView with refresh button

12. **FrmLeaveHistory.Designer.cs**
    - Designer file
    - dgvHistory, btnRefresh

#### Delete Leave
13. **FrmDeleteLeave.cs**
    - Delete pending leave requests only
    - Confirmation dialog before deletion
    - Refreshes grid after delete

14. **FrmDeleteLeave.Designer.cs**
    - Designer file
    - dgvPending, btnDelete, lblStatus

#### Remaining Leaves
15. **FrmRemainingLeaves.cs**
    - View leave balances
    - Shows: LeaveName, MaxDaysPerYear, TakenDays, RemainingDays
    - Only counts APPROVED leaves

16. **FrmRemainingLeaves.Designer.cs**
    - Designer file
    - dgvBalances

---

### ? ADMIN MODULE (12 files - 6 forms)

#### Admin Login
17. **FrmAdminLogin.cs**
    - Admin authentication
    - Separate from employee login
    - Opens FrmAdminDashboard on success

18. **FrmAdminLogin.Designer.cs**
    - Designer file
    - txtUsername, txtPassword, btnLogin, btnClear, lblError

#### Admin Dashboard
19. **FrmAdminDashboard.cs**
    - Main admin menu
    - Buttons: Register Employee, Manage Leave Types, Approve/Reject Leaves, Generate Reports, Logout
    - Receives adminId and fullName in constructor

20. **FrmAdminDashboard.Designer.cs**
    - Designer file
    - 5 navigation buttons + welcome label

#### Register Employee
21. **FrmRegisterEmployee.cs**
    - Add new employees
    - Auto-generates username from email
    - Creates Login entry with default password "Employee123"
    - Uses SCOPE_IDENTITY() to get new EmployeeID
    - Email validation and duplicate checking

22. **FrmRegisterEmployee.Designer.cs**
    - Designer file
    - txtFullName, txtEmail, txtDepartment, txtDesignation, dtpDateOfJoin, btnSave, btnClear

#### Manage Leave Types
23. **FrmManageLeaveTypes.cs**
    - Edit leave type settings
    - Editable: MaxDaysPerYear, IsPaid
    - Read-only: LeaveTypeID, LeaveName
    - DataTable tracks changes

24. **FrmManageLeaveTypes.Designer.cs**
    - Designer file
    - dgvLeaveTypes, btnSaveChanges

#### Approve/Reject Leaves
25. **FrmApproveRejectLeaves.cs**
    - Process pending leave requests
    - Shows: LeaveRequestID, EmployeeName, LeaveType, Dates, Days, Reason
    - Updates Status, AdminID, DecisionDate
    - Confirmation dialogs

26. **FrmApproveRejectLeaves.Designer.cs**
    - Designer file
    - dgvPendingLeaves, btnApprove, btnReject, lblStatus

#### Generate Reports
27. **FrmGenerateReports.cs**
    - Three report types:
      1. By Employee - leave statistics per employee
      2. By Leave Type - usage statistics per type
      3. By Status - distribution by status
    - Dynamic grid binding

28. **FrmGenerateReports.Designer.cs**
    - Designer file
    - dgvReports, btnEmployeeReport, btnLeaveTypeReport, btnStatusReport, lblReportTitle

---

### ? DOCUMENTATION FILES (3 files)

29. **README.md** (300+ lines)
    - Complete project documentation
    - Database schema reference
    - Application structure
    - Usage instructions
    - Coding standards
    - Troubleshooting guide
    - Testing checklist

30. **QUICK_START.md** (200+ lines)
    - Quick setup guide
    - Test credentials
    - Test scenarios
    - Validation testing
    - Success criteria
    - Demonstration checklist

31. **PROJECT_SUMMARY.md** (400+ lines)
    - Project overview
    - File structure
    - Technical specifications
    - Features summary
    - Testing coverage
    - Academic requirements

32. **INDEX.md** (This file)
    - Complete file listing
    - File descriptions
    - Quick reference

---

### ? SQL SCRIPT FILES (1 file)

33. **TestData.sql** (200+ lines)
    - Sample data for all tables
    - 5 employees
    - 3 admins
    - 5 leave types
    - Multiple leave applications (pending, approved, rejected)
    - Test credentials
    - Verification queries
    - Helpful testing queries

---

### ?? ORIGINAL FILES (Not Modified)

These files remain from the original project template:

- **Form1.cs** - Original form (not used, replaced by FrmStartup)
- **Form1.Designer.cs** - Original designer file
- **Properties/AssemblyInfo.cs** - Assembly metadata
- **Properties/Resources.Designer.cs** - Resources file
- **Properties/Settings.Designer.cs** - Settings file

---

## ?? FILE STATISTICS

| Category | Count | Description |
|----------|-------|-------------|
| **Core Files** | 2 | Program.cs, DbHelper.cs |
| **Startup Module** | 2 | FrmStartup + Designer |
| **Employee Forms** | 12 | 6 forms × 2 files each |
| **Admin Forms** | 12 | 6 forms × 2 files each |
| **Documentation** | 4 | README, QUICK_START, PROJECT_SUMMARY, INDEX |
| **SQL Scripts** | 1 | TestData.sql |
| **Total New Files** | 33 | All created for this project |

---

## ?? FILE USAGE MAP

### At Application Startup
```
Program.cs ? FrmStartup.cs ? [Employee or Admin selection]
```

### Employee Flow
```
FrmStartup ? FrmEmployeeLogin ? FrmEmployeeDashboard
                                         ?
        ????????????????????????????????????????????????????????????????
        ?                    ?                ?                         ?
FrmApplyLeave    FrmLeaveHistory    FrmDeleteLeave    FrmRemainingLeaves
```

### Admin Flow
```
FrmStartup ? FrmAdminLogin ? FrmAdminDashboard
                                    ?
        ????????????????????????????????????????????????????????????????
        ?                    ?                    ?                     ?
FrmRegisterEmployee  FrmManageLeaveTypes  FrmApproveRejectLeaves  FrmGenerateReports
```

---

## ??? DATABASE ACCESS PATTERN

All forms access database through:
```
DbHelper.GetConnection() ? SqlConnection ? SqlCommand ? Execute
```

Files that access database:
- FrmEmployeeLogin (SELECT Login + Employee)
- FrmEmployeeDashboard (no direct access)
- FrmApplyLeave (SELECT LeaveTypes, INSERT AppliedLeaves)
- FrmLeaveHistory (SELECT AppliedLeaves + LeaveTypes)
- FrmDeleteLeave (SELECT + DELETE AppliedLeaves)
- FrmRemainingLeaves (SELECT with GROUP BY)
- FrmAdminLogin (SELECT Login + Admin)
- FrmAdminDashboard (no direct access)
- FrmRegisterEmployee (INSERT Employee + Login)
- FrmManageLeaveTypes (SELECT + UPDATE LeaveTypes)
- FrmApproveRejectLeaves (SELECT + UPDATE AppliedLeaves)
- FrmGenerateReports (Multiple SELECT queries)

---

## ?? FORMS SUMMARY TABLE

| # | Form Name | Lines | Purpose | Key Controls |
|---|-----------|-------|---------|-------------|
| 1 | FrmStartup | ~50 | Select login type | btnEmployeeLogin, btnAdminLogin |
| 2 | FrmEmployeeLogin | ~100 | Employee auth | txtUsername, txtPassword |
| 3 | FrmEmployeeDashboard | ~80 | Employee menu | 5 navigation buttons |
| 4 | FrmApplyLeave | ~180 | Submit leaves | cmbLeaveType, dtpDates, txtReason |
| 5 | FrmLeaveHistory | ~100 | View history | dgvHistory |
| 6 | FrmDeleteLeave | ~150 | Delete pending | dgvPending, btnDelete |
| 7 | FrmRemainingLeaves | ~90 | View balance | dgvBalances |
| 8 | FrmAdminLogin | ~100 | Admin auth | txtUsername, txtPassword |
| 9 | FrmAdminDashboard | ~80 | Admin menu | 5 navigation buttons |
| 10 | FrmRegisterEmployee | ~180 | Add employees | txtFullName, txtEmail, etc. |
| 11 | FrmManageLeaveTypes | ~120 | Edit types | dgvLeaveTypes |
| 12 | FrmApproveRejectLeaves | ~180 | Process leaves | dgvPendingLeaves, btnApprove |
| 13 | FrmGenerateReports | ~200 | View reports | dgvReports, 3 report buttons |

**Total Code**: ~1,600+ lines (excluding designer files)

---

## ?? QUICK FILE FINDER

Need to modify something? Use this guide:

### Connection String
? **DbHelper.cs** (line 9)

### Startup Form
? **Program.cs** (line 17)

### Employee Login Logic
? **FrmEmployeeLogin.cs** (btnLogin_Click method)

### Admin Login Logic
? **FrmAdminLogin.cs** (btnLogin_Click method)

### Leave Application Logic
? **FrmApplyLeave.cs** (btnSubmit_Click method)

### Approve/Reject Logic
? **FrmApproveRejectLeaves.cs** (ProcessLeaveRequest method)

### Report Queries
? **FrmGenerateReports.cs** (LoadEmployeeReport, LoadLeaveTypeReport, LoadStatusReport)

### Test Credentials
? **TestData.sql** (bottom section)

### Setup Instructions
? **QUICK_START.md**

### Complete Documentation
? **README.md**

---

## ? VERIFICATION CHECKLIST

Use this to verify all files are present:

### Core (2)
- [ ] Program.cs
- [ ] DbHelper.cs

### Startup (2)
- [ ] FrmStartup.cs
- [ ] FrmStartup.Designer.cs

### Employee Module (12)
- [ ] FrmEmployeeLogin.cs + .Designer.cs
- [ ] FrmEmployeeDashboard.cs + .Designer.cs
- [ ] FrmApplyLeave.cs + .Designer.cs
- [ ] FrmLeaveHistory.cs + .Designer.cs
- [ ] FrmDeleteLeave.cs + .Designer.cs
- [ ] FrmRemainingLeaves.cs + .Designer.cs

### Admin Module (12)
- [ ] FrmAdminLogin.cs + .Designer.cs
- [ ] FrmAdminDashboard.cs + .Designer.cs
- [ ] FrmRegisterEmployee.cs + .Designer.cs
- [ ] FrmManageLeaveTypes.cs + .Designer.cs
- [ ] FrmApproveRejectLeaves.cs + .Designer.cs
- [ ] FrmGenerateReports.cs + .Designer.cs

### Documentation (4)
- [ ] README.md
- [ ] QUICK_START.md
- [ ] PROJECT_SUMMARY.md
- [ ] INDEX.md

### Scripts (1)
- [ ] TestData.sql

**Total: 33 files**

---

## ?? FOR INSTRUCTOR REVIEW

Key files to review for grading:

1. **DbHelper.cs** - Database connectivity implementation
2. **FrmApplyLeave.cs** - CRUD operations, validation
3. **FrmApproveRejectLeaves.cs** - Business logic, parameterized queries
4. **FrmGenerateReports.cs** - Complex SQL queries, data binding
5. **FrmRegisterEmployee.cs** - Transaction handling, error management
6. **README.md** - Documentation quality
7. **TestData.sql** - Database understanding

---

## ?? FILE CONTACT INFORMATION

Each form file contains:
- **Namespace**: WindowsFormsApp13
- **Framework**: .NET Framework 4.7.2
- **Database**: LeaveDB on LAPTOP-F9EU6O5J\SQLEXPRESS
- **Author**: [Student Name]
- **Purpose**: Academic Activity 4

---

## ?? PROJECT COMPLETION STATUS

? All 13 forms implemented  
? All 29 code files created  
? All 4 documentation files written  
? SQL test data script provided  
? Build successful (0 errors)  
? Ready for submission  

---

*This index file provides a complete reference to all files in the Leave Management System project.*
*Last updated: [Current Date]*
