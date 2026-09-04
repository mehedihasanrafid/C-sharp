-- ============================================================================
-- Super Shop Management System - Database Initialization & Seed Script
-- Target Database: Csharp (Microsoft SQL Server)
-- ============================================================================

IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'Csharp')
BEGIN
    CREATE DATABASE [Csharp];
END
GO

USE [Csharp];
GO

-- 1. Drop existing constraints and tables (if recreating)
IF OBJECT_ID('dbo.TransactionTbl', 'U') IS NOT NULL DROP TABLE dbo.TransactionTbl;
IF OBJECT_ID('dbo.OwnerReqTbl', 'U') IS NOT NULL DROP TABLE dbo.OwnerReqTbl;
IF OBJECT_ID('dbo.InventoryTbl', 'U') IS NOT NULL DROP TABLE dbo.InventoryTbl;
IF OBJECT_ID('dbo.customerInfoTbl', 'U') IS NOT NULL DROP TABLE dbo.customerInfoTbl;
IF OBJECT_ID('dbo.EmployeeTbl', 'U') IS NOT NULL DROP TABLE dbo.EmployeeTbl;
IF OBJECT_ID('dbo.CategoryTbl', 'U') IS NOT NULL DROP TABLE dbo.CategoryTbl;
IF OBJECT_ID('dbo.UserTbl', 'U') IS NOT NULL DROP TABLE dbo.UserTbl;
GO

-- 2. Category Table
CREATE TABLE [dbo].[CategoryTbl](
    [id] [int] IDENTITY(1,1) NOT NULL,
    [name] [varchar](50) NOT NULL,
    CONSTRAINT [PK_CategoryTbl] PRIMARY KEY CLUSTERED ([id] ASC)
);
GO

-- 3. Customer Info Table
CREATE TABLE [dbo].[customerInfoTbl](
    [customerId] [int] IDENTITY(1,1) NOT NULL,
    [customerName] [varchar](50) NULL,
    [customerContactNo] [varchar](50) NULL,
    CONSTRAINT [PK_customerInfoTbl] PRIMARY KEY CLUSTERED ([customerId] ASC)
);
GO

-- 4. Employee Table
CREATE TABLE [dbo].[EmployeeTbl](
    [id] [int] IDENTITY(1,1) NOT NULL,
    [EmpName] [varchar](50) NOT NULL,
    [Contact] [varchar](50) NOT NULL,
    [Dob] [date] NOT NULL,
    [Type] [varchar](50) NOT NULL,
    [Salary] [int] NOT NULL,
    [Gender] [varchar](50) NOT NULL,
    [UserId] [int] NULL,
    [FullName] [varchar](50) NULL,
    [EmpStatus] [varchar](50) NULL,
    CONSTRAINT [PK_EmployeeTbl] PRIMARY KEY CLUSTERED ([id] ASC)
);
GO

-- 5. Inventory Table
CREATE TABLE [dbo].[InventoryTbl](
    [id] [int] IDENTITY(1,1) NOT NULL,
    [ProductName] [varchar](50) NOT NULL,
    [CategoryId] [int] NOT NULL,
    [ProductCompany] [varchar](50) NOT NULL,
    [BuyingPrice] [int] NOT NULL,
    [SellingPrice] [int] NOT NULL,
    [Date] [datetime] NOT NULL,
    [Quantity] [int] NOT NULL,
    CONSTRAINT [PK_InventoryTbl] PRIMARY KEY CLUSTERED ([id] ASC)
);
GO

-- 6. Owner Product Requests Table
CREATE TABLE [dbo].[OwnerReqTbl](
    [id] [int] IDENTITY(1,1) NOT NULL,
    [ProductName] [varchar](50) NOT NULL,
    [CategoryId] [int] NOT NULL,
    [ProductsCompany] [varchar](50) NOT NULL,
    CONSTRAINT [PK_OwnerReqTbl] PRIMARY KEY CLUSTERED ([id] ASC)
);
GO

-- 7. Transaction Table
CREATE TABLE [dbo].[TransactionTbl](
    [id] [int] IDENTITY(1,1) NOT NULL,
    [Pid] [int] NOT NULL,
    [SellQuantity] [int] NOT NULL,
    [SellDate] [datetime] NOT NULL,
    [CustomerId] [int] NOT NULL,
    [SalesmanId] [int] NULL,
    [OrderId] [int] NULL,
    CONSTRAINT [PK_TransactionTbl] PRIMARY KEY CLUSTERED ([id] ASC)
);
GO

-- 8. User Table (Authentication)
CREATE TABLE [dbo].[UserTbl](
    [id] [int] IDENTITY(1,1) NOT NULL,
    [Uname] [varchar](50) NOT NULL,
    [pass] [varchar](50) NOT NULL,
    [Type] [varchar](50) NOT NULL,
    CONSTRAINT [PK_UserTbl] PRIMARY KEY CLUSTERED ([id] ASC)
);
GO

-- Add Foreign Keys
ALTER TABLE [dbo].[InventoryTbl] WITH CHECK ADD CONSTRAINT [FK_InventoryTbl_CategoryTbl] FOREIGN KEY([CategoryId]) REFERENCES [dbo].[CategoryTbl] ([id]);
ALTER TABLE [dbo].[OwnerReqTbl] WITH CHECK ADD CONSTRAINT [FK_OwnerReqTbl_CategoryTbl] FOREIGN KEY([CategoryId]) REFERENCES [dbo].[CategoryTbl] ([id]);
ALTER TABLE [dbo].[TransactionTbl] WITH CHECK ADD CONSTRAINT [FK_TransactionTbl_InventoryTbl] FOREIGN KEY([SalesmanId]) REFERENCES [dbo].[EmployeeTbl] ([id]);
GO

-- ============================================================================
-- INITIAL SEED DATA (Default Logins & Test Data)
-- ============================================================================

-- Insert Default System Users for Authentication
INSERT INTO [dbo].[UserTbl] ([Uname], [pass], [Type]) VALUES
('admin', '123', 'Admin'),
('manager', '123', 'Manager'),
('salesman', '123', 'Salesman'),
('rafid', '123', 'Admin');

-- Insert Initial Employees
INSERT INTO [dbo].[EmployeeTbl] ([EmpName], [Contact], [Dob], [Type], [Salary], [Gender], [UserId], [FullName], [EmpStatus]) VALUES
('System Admin', '01711000000', '1995-01-01', 'Admin', 80000, 'Male', 1, 'System Administrator', 'Active'),
('Store Manager', '01811000000', '1998-05-15', 'Manager', 50000, 'Female', 2, 'Senior Manager', 'Active'),
('Mehedi Hasan', '01911000000', '2001-08-20', 'Salesman', 30000, 'Male', 3, 'Mehedi Hasan Rafid', 'Active');

-- Insert Product Categories
INSERT INTO [dbo].[CategoryTbl] ([name]) VALUES
('Groceries'),
('Beverages'),
('Bakery'),
('Dairy'),
('Personal Care');

-- Insert Initial Inventory Items
INSERT INTO [dbo].[InventoryTbl] ([ProductName], [CategoryId], [ProductCompany], [BuyingPrice], [SellingPrice], [Date], [Quantity]) VALUES
('Premium Miniket Rice 5kg', 1, 'AACI Foods', 320, 380, GETDATE(), 50),
('Soyabean Oil 1L', 1, 'Rupchanda', 160, 185, GETDATE(), 100),
('Fresh Milk 1L', 4, 'Aarong Dairy', 70, 85, GETDATE(), 30),
('White Sandwich Bread', 3, 'Wonder Bread', 45, 55, GETDATE(), 40),
('Farm Eggs 12pk', 4, 'Kazi Farms', 110, 130, GETDATE(), 60),
('Orange Juice 1L', 2, 'Pran', 120, 150, GETDATE(), 25);

-- Insert Sample Customers
INSERT INTO [dbo].[customerInfoTbl] ([customerName], [customerContactNo]) VALUES
('Sarah Khan', '01712345678'),
('Tanvir Ahmed', '01812345678'),
('Default Walk-in Customer', '00000000000');

PRINT '=======================================================';
PRINT '  Csharp Database created and seeded successfully!';
PRINT '  Default Logins:';
PRINT '  - Admin:    Username = admin    Password = 123';
PRINT '  - Manager:  Username = manager  Password = 123';
PRINT '  - Salesman: Username = salesman Password = 123';
PRINT '=======================================================';
GO
