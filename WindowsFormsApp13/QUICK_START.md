# QUICK START GUIDE
## Leave Management System - Griffindo Lanka Toys

---

## SETUP (One-time)

### 1. Database Setup
Run the following in SQL Server Management Studio:

```sql
-- Create database (if not exists)
CREATE DATABASE LeaveDB;
GO

USE LeaveDB;
GO

-- Create all tables (run the CREATE TABLE scripts provided in requirements)
-- Then run TestData.sql to populate sample data
```

### 2. Verify Connection String
Open `DbHelper.cs` and verify the connection string matches your SQL Server instance:
```csharp
Data Source=LAPTOP-F9EU6O5J\SQLEXPRESS;Initial Catalog=LeaveDB;Integrated Security=True;
```

---

## RUNNING THE APPLICATION

1. **Build** the solution (F6 or Build > Build Solution)
2. **Run** the application (F5 or Debug > Start Debugging)
3. The **Startup Screen** will appear

---

## TESTING EMPLOYEE FEATURES

### Login
1. Click **"Employee Login"** on startup screen
2. Enter credentials:
   - Username: `john.silva`
   - Password: `Employee123`
3. Click **Login**

### Test Each Feature
? **Apply Leave**
   - Select leave type: Annual Leave
   - Start Date: Tomorrow
   - End Date: Day after tomorrow
   - Reason: "Testing leave application"
   - Click Submit

? **Leave History**
   - View all your leave requests
   - Check different statuses (Pending, Approved, Rejected)

? **Delete Leave**
   - See only pending requests
   - Select one and delete it
   - Confirm it's removed

? **Remaining Leaves**
   - View your leave balances
   - Check remaining days for each leave type

? **Logout**
   - Returns to startup screen

---

## TESTING ADMIN FEATURES

### Login
1. Click **"Admin Login"** on startup screen
2. Enter credentials:
   - Username: `admin`
   - Password: `Admin123`
3. Click **Login**

### Test Each Feature
? **Register Employee**
   - Full Name: Test Employee
   - Email: test.employee@griffindo.com
   - Department: IT
   - Designation: Tester
   - Date Of Join: Today
   - Click Save
   - Note the generated credentials

? **Manage Leave Types**
   - Edit MaxDaysPerYear for any leave type
   - Toggle IsPaid checkbox
   - Click Save Changes

? **Approve/Reject Leaves**
   - View pending leave requests
   - Select one request
   - Click Approve (or Reject)
   - Confirm action

? **Generate Reports**
   - Click "By Employee" - see per-employee statistics
   - Click "By Leave Type" - see per-type statistics
   - Click "By Status" - see status distribution

? **Logout**
   - Returns to startup screen

---

## TEST CREDENTIALS

### Employees
| Username | Password | Name |
|----------|----------|------|
| john.silva | Employee123 | John Silva |
| sarah.fernando | Employee123 | Sarah Fernando |
| david.perera | Employee123 | David Perera |
| maria.dias | Employee123 | Maria Dias |
| raj.kumar | Employee123 | Raj Kumar |

### Admins
| Username | Password | Name |
|----------|----------|------|
| admin | Admin123 | Admin Super |
| nimal.g | Admin123 | Nimal Gunawardena |
| priya.j | Admin123 | Priya Jayasinghe |

---

## COMMON TEST SCENARIOS

### Scenario 1: Complete Leave Request Workflow
1. **Employee**: Login as `john.silva`
2. **Employee**: Apply for Annual Leave (3 days)
3. **Employee**: View in Leave History (Status: Pending)
4. **Employee**: Logout
5. **Admin**: Login as `admin`
6. **Admin**: Go to Approve/Reject Leaves
7. **Admin**: Find John's request and Approve it
8. **Admin**: Logout
9. **Employee**: Login as `john.silva` again
10. **Employee**: View Leave History (Status: Approved)
11. **Employee**: Check Remaining Leaves (reduced by 3 days)

### Scenario 2: Delete Pending Leave
1. **Employee**: Login as `maria.dias`
2. **Employee**: Apply for leave
3. **Employee**: Go to Delete Leave
4. **Employee**: Select the just-created request
5. **Employee**: Delete it
6. **Employee**: Verify it's gone from Leave History

### Scenario 3: Register and Test New Employee
1. **Admin**: Login as `admin`
2. **Admin**: Register new employee with email: newuser@griffindo.com
3. **Admin**: Note the generated username (newuser) and password
4. **Admin**: Logout
5. **Employee**: Try logging in with new credentials
6. **Employee**: Apply for leave
7. **Admin**: Login and approve the leave

### Scenario 4: View Reports
1. **Admin**: Login as `admin`
2. **Admin**: Generate Reports
3. **Admin**: Click "By Employee" - verify data shows
4. **Admin**: Click "By Leave Type" - verify statistics
5. **Admin**: Click "By Status" - verify counts match database

---

## VALIDATION TESTING

### Test Input Validation
? Login with empty fields - should show error
? Apply leave with no leave type selected - should show error
? Apply leave with end date before start date - should show error
? Apply leave with empty reason - should show error
? Register employee with duplicate email - should show error
? Register employee with invalid email format - should show error

### Test Business Rules
? Only pending leaves can be deleted by employee
? Only active employees can login
? Only active admins can login
? Leave balance only counts approved leaves
? System auto-calculates number of days
? System records admin who approved/rejected

---

## TROUBLESHOOTING

### "Cannot connect to database"
- Check SQL Server is running
- Verify connection string in DbHelper.cs
- Ensure Windows Authentication is enabled

### "Invalid username or password"
- Check credentials match TestData.sql
- Verify Login table has entries
- Check UserRole is 'Employee' or 'Admin'
- Verify IsLocked = 0 and IsActive/EmploymentStatus = Active

### "Object reference not set to an instance"
- Ensure all foreign key data exists
- Run TestData.sql to populate sample data
- Check LinkedEmployeeID/LinkedAdminID are set correctly

### Form doesn't show
- Check Application.Run() points to FrmStartup
- Verify form Show() or ShowDialog() is called
- Check no exceptions in Load event

---

## SUCCESS CRITERIA

You have successfully tested the application when:

? Employees can login, apply, view, and delete leaves
? Admins can login, register employees, and manage leaves
? Leave balances calculate correctly
? Reports show accurate data
? All validation works correctly
? No crashes or unhandled exceptions
? All buttons and features work as expected

---

## DEMONSTRATION CHECKLIST

For academic presentation:

- [ ] Show startup screen with Employee/Admin options
- [ ] Demonstrate employee login
- [ ] Apply for leave as employee
- [ ] View leave history
- [ ] Show remaining leaves calculation
- [ ] Logout and login as admin
- [ ] Approve the leave request
- [ ] Register a new employee
- [ ] Show auto-generated credentials
- [ ] Edit leave types
- [ ] Generate all three report types
- [ ] Demonstrate validation (try invalid inputs)
- [ ] Show database connection working

---

## ADDITIONAL FEATURES TO HIGHLIGHT

1. **Auto-calculation**: System calculates leave days automatically
2. **Duplicate Prevention**: Email validation prevents duplicate employees
3. **Referential Integrity**: All forms handle missing data gracefully
4. **User Experience**: Clear buttons, confirmations, status messages
5. **Security**: Password masking, role-based access, parameterized queries
6. **Professional UI**: Consistent layout, clear labels, organized forms

---

## SUPPORT

For issues or questions:
1. Check README.md for detailed documentation
2. Review TestData.sql for sample data structure
3. Verify database schema matches requirements
4. Check Output window in Visual Studio for errors
5. Use SQL Server Profiler to debug query issues

---

## READY TO SUBMIT

Your project is complete with:
? 13 functional forms (Employee + Admin modules)
? Database helper class
? Complete CRUD operations
? Input validation
? Error handling
? Reports generation
? Professional UI
? Coding standards followed
? Comprehensive documentation
? Test data and scripts

**Good luck with your demonstration!**
