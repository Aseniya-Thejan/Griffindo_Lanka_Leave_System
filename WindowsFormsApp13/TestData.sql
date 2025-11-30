-- =============================================
-- Leave Management System - Test Data Script
-- Griffindo Lanka Toys (Pvt) Ltd
-- =============================================
-- NOTE: This script is for reference/testing only
-- The CREATE TABLE statements are commented out as per requirements
-- Only use INSERT statements to populate test data
-- =============================================

USE LeaveDB;
GO

-- =============================================
-- INSERT SAMPLE LEAVE TYPES
-- =============================================

-- Clear existing data (optional - for fresh testing)
-- DELETE FROM AppliedLeaves;
-- DELETE FROM Login;
-- DELETE FROM Employee;
-- DELETE FROM Admin;
-- DELETE FROM LeaveTypes;

-- Insert Leave Types
INSERT INTO LeaveTypes (LeaveName, MaxDaysPerYear, IsPaid) VALUES
('Annual Leave', 21, 1),
('Sick Leave', 14, 1),
('Casual Leave', 7, 1),
('Maternity Leave', 84, 1),
('No Pay Leave', 30, 0);

-- =============================================
-- INSERT SAMPLE EMPLOYEES
-- =============================================

INSERT INTO Employee (FullName, Email, Department, Designation, DateOfJoin, EmploymentStatus) VALUES
('John Silva', 'john.silva@griffindo.com', 'Manufacturing', 'Production Manager', '2020-01-15', 'Active'),
('Sarah Fernando', 'sarah.fernando@griffindo.com', 'HR', 'HR Manager', '2019-03-20', 'Active'),
('David Perera', 'david.perera@griffindo.com', 'IT', 'Software Engineer', '2021-06-10', 'Active'),
('Maria Dias', 'maria.dias@griffindo.com', 'Sales', 'Sales Executive', '2020-11-05', 'Active'),
('Raj Kumar', 'raj.kumar@griffindo.com', 'Finance', 'Accountant', '2018-07-01', 'Active');

-- =============================================
-- INSERT SAMPLE ADMINS
-- =============================================

INSERT INTO Admin (FullName, Email, Role, Department, IsActive) VALUES
('Admin Super', 'admin@griffindo.com', 'System Administrator', 'IT', 1),
('Nimal Gunawardena', 'nimal.g@griffindo.com', 'HR Manager', 'HR', 1),
('Priya Jayasinghe', 'priya.j@griffindo.com', 'Department Head', 'Operations', 1);

-- =============================================
-- INSERT LOGIN CREDENTIALS
-- =============================================
-- NOTE: In production, passwords should be hashed
-- For this academic project, plain text is used for testing

-- Employee Logins
INSERT INTO Login (Username, PasswordHash, UserRole, LinkedEmployeeID, LinkedAdminID, IsLocked) VALUES
('john.silva', 'Employee123', 'Employee', 1, NULL, 0),
('sarah.fernando', 'Employee123', 'Employee', 2, NULL, 0),
('david.perera', 'Employee123', 'Employee', 3, NULL, 0),
('maria.dias', 'Employee123', 'Employee', 4, NULL, 0),
('raj.kumar', 'Employee123', 'Employee', 5, NULL, 0);

-- Admin Logins
INSERT INTO Login (Username, PasswordHash, UserRole, LinkedEmployeeID, LinkedAdminID, IsLocked) VALUES
('admin', 'Admin123', 'Admin', NULL, 1, 0),
('nimal.g', 'Admin123', 'Admin', NULL, 2, 0),
('priya.j', 'Admin123', 'Admin', NULL, 3, 0);

-- =============================================
-- INSERT SAMPLE LEAVE APPLICATIONS
-- =============================================

-- Pending Leaves
INSERT INTO AppliedLeaves (EmployeeID, LeaveTypeID, AdminID, StartDate, EndDate, NumberOfDays, Status, Reason, RequestedOn, DecisionDate) VALUES
(1, 1, NULL, '2024-02-15', '2024-02-17', 3, 'Pending', 'Family vacation', GETDATE(), NULL),
(3, 2, NULL, '2024-02-10', '2024-02-11', 2, 'Pending', 'Medical appointment', GETDATE(), NULL),
(4, 3, NULL, '2024-02-20', '2024-02-20', 1, 'Pending', 'Personal work', GETDATE(), NULL);

-- Approved Leaves
INSERT INTO AppliedLeaves (EmployeeID, LeaveTypeID, AdminID, StartDate, EndDate, NumberOfDays, Status, Reason, RequestedOn, DecisionDate) VALUES
(1, 1, 1, '2024-01-10', '2024-01-15', 6, 'Approved', 'Annual vacation', '2024-01-01', '2024-01-02'),
(2, 2, 1, '2024-01-20', '2024-01-22', 3, 'Approved', 'Flu', '2024-01-18', '2024-01-19'),
(3, 1, 2, '2024-01-25', '2024-01-26', 2, 'Approved', 'Personal', '2024-01-20', '2024-01-21'),
(5, 3, 1, '2024-01-15', '2024-01-15', 1, 'Approved', 'Bank work', '2024-01-10', '2024-01-11');

-- Rejected Leaves
INSERT INTO AppliedLeaves (EmployeeID, LeaveTypeID, AdminID, StartDate, EndDate, NumberOfDays, Status, Reason, RequestedOn, DecisionDate) VALUES
(4, 1, 2, '2024-01-05', '2024-01-12', 8, 'Rejected', 'Vacation', '2023-12-28', '2023-12-29'),
(2, 5, 1, '2024-02-01', '2024-02-15', 15, 'Rejected', 'Extended leave', '2024-01-25', '2024-01-26');

-- =============================================
-- VERIFICATION QUERIES
-- =============================================

-- Check all data
SELECT * FROM LeaveTypes;
SELECT * FROM Employee;
SELECT * FROM Admin;
SELECT * FROM Login;
SELECT * FROM AppliedLeaves;

-- Verify employee leave balances
SELECT 
    E.FullName,
    LT.LeaveName,
    LT.MaxDaysPerYear,
    ISNULL(SUM(AL.NumberOfDays), 0) AS TakenDays,
    (LT.MaxDaysPerYear - ISNULL(SUM(AL.NumberOfDays), 0)) AS RemainingDays
FROM LeaveTypes LT
CROSS JOIN Employee E
LEFT JOIN AppliedLeaves AL
    ON LT.LeaveTypeID = AL.LeaveTypeID
    AND AL.EmployeeID = E.EmployeeID
    AND AL.Status = 'Approved'
WHERE E.EmploymentStatus = 'Active'
GROUP BY E.FullName, LT.LeaveName, LT.MaxDaysPerYear
ORDER BY E.FullName, LT.LeaveName;

-- =============================================
-- TEST LOGIN CREDENTIALS
-- =============================================
/*
EMPLOYEE LOGINS (Username / Password):
- john.silva / Employee123
- sarah.fernando / Employee123
- david.perera / Employee123
- maria.dias / Employee123
- raj.kumar / Employee123

ADMIN LOGINS (Username / Password):
- admin / Admin123
- nimal.g / Admin123
- priya.j / Admin123
*/

-- =============================================
-- HELPFUL QUERIES FOR TESTING
-- =============================================

-- View all pending leaves with details
SELECT 
    AL.LeaveRequestID,
    E.FullName AS Employee,
    LT.LeaveName,
    AL.StartDate,
    AL.EndDate,
    AL.NumberOfDays,
    AL.Reason,
    AL.Status
FROM AppliedLeaves AL
INNER JOIN Employee E ON AL.EmployeeID = E.EmployeeID
INNER JOIN LeaveTypes LT ON AL.LeaveTypeID = LT.LeaveTypeID
WHERE AL.Status = 'Pending'
ORDER BY AL.RequestedOn;

-- View approved leaves summary
SELECT 
    E.FullName,
    COUNT(*) AS ApprovedLeaves,
    SUM(AL.NumberOfDays) AS TotalDaysApproved
FROM AppliedLeaves AL
INNER JOIN Employee E ON AL.EmployeeID = E.EmployeeID
WHERE AL.Status = 'Approved'
GROUP BY E.FullName
ORDER BY TotalDaysApproved DESC;

-- View leave statistics by type
SELECT 
    LT.LeaveName,
    COUNT(*) AS TotalRequests,
    SUM(CASE WHEN AL.Status = 'Approved' THEN 1 ELSE 0 END) AS Approved,
    SUM(CASE WHEN AL.Status = 'Rejected' THEN 1 ELSE 0 END) AS Rejected,
    SUM(CASE WHEN AL.Status = 'Pending' THEN 1 ELSE 0 END) AS Pending
FROM LeaveTypes LT
LEFT JOIN AppliedLeaves AL ON LT.LeaveTypeID = AL.LeaveTypeID
GROUP BY LT.LeaveName
ORDER BY TotalRequests DESC;

-- =============================================
-- CLEANUP QUERIES (Use with caution!)
-- =============================================
/*
-- To reset test data:
DELETE FROM AppliedLeaves;
DELETE FROM Login;
DELETE FROM Employee;
DELETE FROM Admin;
DELETE FROM LeaveTypes;

-- Reset identity columns:
DBCC CHECKIDENT ('AppliedLeaves', RESEED, 0);
DBCC CHECKIDENT ('Login', RESEED, 0);
DBCC CHECKIDENT ('Employee', RESEED, 0);
DBCC CHECKIDENT ('Admin', RESEED, 0);
DBCC CHECKIDENT ('LeaveTypes', RESEED, 0);
*/

GO
