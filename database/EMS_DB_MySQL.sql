-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 18, 2026 at 08:33 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `ems_db`
--

-- --------------------------------------------------------

--
-- Table structure for table `attendance`
--

CREATE TABLE `attendance` (
  `AttendID` int(11) NOT NULL,
  `EmpNo` varchar(20) NOT NULL,
  `AttendDate` date NOT NULL,
  `InTime` time DEFAULT NULL,
  `OutTime` time DEFAULT NULL,
  `WorkHours` decimal(5,2) DEFAULT 0.00,
  `OTHours` decimal(5,2) DEFAULT 0.00,
  `Status` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `auditlog`
--

CREATE TABLE `auditlog` (
  `LogID` int(11) NOT NULL,
  `UserID` int(11) DEFAULT NULL,
  `Action` varchar(255) DEFAULT NULL,
  `ActionTime` datetime DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `departments`
--

CREATE TABLE `departments` (
  `DeptID` int(11) NOT NULL,
  `DeptName` varchar(100) NOT NULL,
  `Description` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `designations`
--

CREATE TABLE `designations` (
  `DesignationID` int(11) NOT NULL,
  `DeptID` int(11) NOT NULL,
  `Title` varchar(100) NOT NULL,
  `BasicSalary` decimal(10,2) NOT NULL,
  `OTRate` decimal(10,2) DEFAULT 0.00,
  `MaxMonthlyOTHours` decimal(5,2) DEFAULT 40.00
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `employees`
--

CREATE TABLE `employees` (
  `EmpNo` varchar(20) NOT NULL,
  `FullName` varchar(100) NOT NULL,
  `Gender` varchar(10) DEFAULT NULL,
  `DateOfBirth` date DEFAULT NULL,
  `NIC` varchar(20) DEFAULT NULL,
  `ContactNo` varchar(20) DEFAULT NULL,
  `Email` varchar(100) NOT NULL,
  `Address` varchar(255) DEFAULT NULL,
  `DeptID` int(11) DEFAULT NULL,
  `DesignationID` int(11) DEFAULT NULL,
  `JoinedDate` date DEFAULT curdate()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `leaverequests`
--

CREATE TABLE `leaverequests` (
  `LeaveID` int(11) NOT NULL,
  `EmpNo` varchar(20) NOT NULL,
  `LeaveType` varchar(50) DEFAULT NULL,
  `FromDate` date DEFAULT NULL,
  `ToDate` date DEFAULT NULL,
  `TotalDays` int(11) DEFAULT NULL,
  `Reason` varchar(255) DEFAULT NULL,
  `ApprovalStatus` varchar(20) DEFAULT 'Pending',
  `ApprovedBy` int(11) DEFAULT NULL,
  `AppliedDate` datetime DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `passwordresettokens`
--

CREATE TABLE `passwordresettokens` (
  `TokenID` int(11) NOT NULL,
  `UserID` int(11) DEFAULT NULL,
  `ResetToken` varchar(255) DEFAULT NULL,
  `ExpiryTime` datetime DEFAULT NULL,
  `IsUsed` tinyint(1) DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `payroll`
--

CREATE TABLE `payroll` (
  `PayrollID` int(11) NOT NULL,
  `EmpNo` varchar(20) NOT NULL,
  `PayMonth` int(11) DEFAULT NULL,
  `PayYear` int(11) DEFAULT NULL,
  `BasicSalary` decimal(10,2) DEFAULT NULL,
  `TotalOTHours` decimal(5,2) DEFAULT NULL,
  `OTRate` decimal(10,2) DEFAULT NULL,
  `OTPay` decimal(10,2) DEFAULT NULL,
  `Allowances` decimal(10,2) DEFAULT 0.00,
  `Deductions` decimal(10,2) DEFAULT 0.00,
  `NetSalary` decimal(10,2) DEFAULT NULL,
  `GeneratedDate` datetime DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `reports`
--

CREATE TABLE `reports` (
  `ReportID` int(11) NOT NULL,
  `ReportType` varchar(50) DEFAULT NULL,
  `GeneratedBy` int(11) DEFAULT NULL,
  `FromDate` date DEFAULT NULL,
  `ToDate` date DEFAULT NULL,
  `GeneratedDate` datetime DEFAULT current_timestamp(),
  `FilePath` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `UserID` int(11) NOT NULL,
  `Username` varchar(50) NOT NULL,
  `PasswordHash` varchar(255) NOT NULL,
  `Role` varchar(20) NOT NULL,
  `EmployeeID` varchar(20) DEFAULT NULL,
  `IsActive` tinyint(1) DEFAULT 1,
  `CreatedAt` datetime DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `attendance`
--
ALTER TABLE `attendance`
  ADD PRIMARY KEY (`AttendID`),
  ADD KEY `EmpNo` (`EmpNo`);

--
-- Indexes for table `auditlog`
--
ALTER TABLE `auditlog`
  ADD PRIMARY KEY (`LogID`);

--
-- Indexes for table `departments`
--
ALTER TABLE `departments`
  ADD PRIMARY KEY (`DeptID`);

--
-- Indexes for table `designations`
--
ALTER TABLE `designations`
  ADD PRIMARY KEY (`DesignationID`),
  ADD KEY `DeptID` (`DeptID`);

--
-- Indexes for table `employees`
--
ALTER TABLE `employees`
  ADD PRIMARY KEY (`EmpNo`),
  ADD UNIQUE KEY `Email` (`Email`),
  ADD UNIQUE KEY `NIC` (`NIC`),
  ADD KEY `DeptID` (`DeptID`),
  ADD KEY `DesignationID` (`DesignationID`);

--
-- Indexes for table `leaverequests`
--
ALTER TABLE `leaverequests`
  ADD PRIMARY KEY (`LeaveID`),
  ADD KEY `EmpNo` (`EmpNo`),
  ADD KEY `ApprovedBy` (`ApprovedBy`);

--
-- Indexes for table `passwordresettokens`
--
ALTER TABLE `passwordresettokens`
  ADD PRIMARY KEY (`TokenID`),
  ADD KEY `UserID` (`UserID`);

--
-- Indexes for table `payroll`
--
ALTER TABLE `payroll`
  ADD PRIMARY KEY (`PayrollID`),
  ADD KEY `EmpNo` (`EmpNo`);

--
-- Indexes for table `reports`
--
ALTER TABLE `reports`
  ADD PRIMARY KEY (`ReportID`),
  ADD KEY `GeneratedBy` (`GeneratedBy`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`UserID`),
  ADD UNIQUE KEY `Username` (`Username`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `attendance`
--
ALTER TABLE `attendance`
  MODIFY `AttendID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `auditlog`
--
ALTER TABLE `auditlog`
  MODIFY `LogID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `departments`
--
ALTER TABLE `departments`
  MODIFY `DeptID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `designations`
--
ALTER TABLE `designations`
  MODIFY `DesignationID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `leaverequests`
--
ALTER TABLE `leaverequests`
  MODIFY `LeaveID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `passwordresettokens`
--
ALTER TABLE `passwordresettokens`
  MODIFY `TokenID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `payroll`
--
ALTER TABLE `payroll`
  MODIFY `PayrollID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `reports`
--
ALTER TABLE `reports`
  MODIFY `ReportID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `UserID` int(11) NOT NULL AUTO_INCREMENT;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `attendance`
--
ALTER TABLE `attendance`
  ADD CONSTRAINT `attendance_ibfk_1` FOREIGN KEY (`EmpNo`) REFERENCES `employees` (`EmpNo`);

--
-- Constraints for table `designations`
--
ALTER TABLE `designations`
  ADD CONSTRAINT `designations_ibfk_1` FOREIGN KEY (`DeptID`) REFERENCES `departments` (`DeptID`);

--
-- Constraints for table `employees`
--
ALTER TABLE `employees`
  ADD CONSTRAINT `employees_ibfk_1` FOREIGN KEY (`DeptID`) REFERENCES `departments` (`DeptID`),
  ADD CONSTRAINT `employees_ibfk_2` FOREIGN KEY (`DesignationID`) REFERENCES `designations` (`DesignationID`);

--
-- Constraints for table `leaverequests`
--
ALTER TABLE `leaverequests`
  ADD CONSTRAINT `leaverequests_ibfk_1` FOREIGN KEY (`EmpNo`) REFERENCES `employees` (`EmpNo`),
  ADD CONSTRAINT `leaverequests_ibfk_2` FOREIGN KEY (`ApprovedBy`) REFERENCES `users` (`UserID`);

--
-- Constraints for table `passwordresettokens`
--
ALTER TABLE `passwordresettokens`
  ADD CONSTRAINT `passwordresettokens_ibfk_1` FOREIGN KEY (`UserID`) REFERENCES `users` (`UserID`);

--
-- Constraints for table `payroll`
--
ALTER TABLE `payroll`
  ADD CONSTRAINT `payroll_ibfk_1` FOREIGN KEY (`EmpNo`) REFERENCES `employees` (`EmpNo`);

--
-- Constraints for table `reports`
--
ALTER TABLE `reports`
  ADD CONSTRAINT `reports_ibfk_1` FOREIGN KEY (`GeneratedBy`) REFERENCES `users` (`UserID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
