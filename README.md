# Super Shop Management & POS System (C# / WinForms / MS SQL Server)

A complete desktop Point of Sale (POS) and retail management solution built using **C# (.NET Framework 4.7.2)**, **Windows Forms**, and **Microsoft SQL Server**. Developed as an academic course project for **CSC2210: Object Oriented Programming 2** at **American International University–Bangladesh (AIUB)**.

---

## 🌟 Architecture & Features

The system supports role-based authentication and navigation tailored to three distinct user tiers:

### 1. 🛒 Salesman POS Module *(Core Focus)*
- **Point of Sale Billing**: Interactive product search, active cart calculation, tax, discount handling, and transaction checkout.
- **Invoice Generation**: PDF invoice receipt generation using `iTextSharp` / `BouncyCastle` libraries.
- **Customer Registration**: Quick registration of new customers linked to sale transactions.
- **Salesman Profile**: Profile management and sales performance tracking.

### 2. 📦 Manager Module
- **Inventory Control**: Add, update, and manage product inventory items across categories.
- **Restock Requests**: Process product requests submitted by owners/admins and update stock quantities.
- **Category Management**: Organize products under structured categories.

### 3. 📊 Admin Dashboard Module
- **Financial Analytics**: High-level sales monitoring, profit margins, monthly/yearly revenue, and cost reports.
- **Employee Management**: Create, update, assign roles (Admin, Manager, Salesman), set initial passwords, and maintain employee records.
- **Performance Reports**: Track "Seller of the Month" and manage store operations.

---

## 🛠️ Technology Stack

- **Language**: C# (.NET Framework 4.7.2)
- **GUI Framework**: Windows Forms (WinForms), MetroModernUI (`MetroFramework`)
- **Database**: Microsoft SQL Server (T-SQL scripts included)
- **Libraries**: `iTextSharp` (v5.5.13.3), `BouncyCastle` (v1.8.9)
- **IDE**: Microsoft Visual Studio 2019 / 2022

---

## 📂 Repository Structure

```
SuperShopManagementSystem/
├── database/
│   └── setup_database.sql          # SQL Server DDL Schema & initial seed login script
├── src/                            # Visual Studio Solution & Source Code
│   ├── SuperShopManagementSystem.sln
│   └── SuperShopManagement/
│       ├── Program.cs              # Application entry point
│       ├── DataAccess.cs           # SQL Server ADO.NET connection & query helper
│       ├── Form1.cs                # Login & role authentication portal
│       ├── Admin.cs                # Admin dashboard form
│       ├── AddEmployee.cs          # Employee management form
│       ├── ManagerNewProduct.cs    # Product & inventory management form
│       ├── Inventory.cs            # Inventory grid form
│       ├── Category.cs             # Category management form
│       ├── Transaction.cs          # POS transaction history form
│       ├── MonthlySale.cs          # Sales analytics forms
│       ├── YearlySale.cs
│       ├── MonthlyCost.cs
│       └── YearlyCost.cs
├── .gitignore                      # Visual Studio build artifacts ignore file
└── README.md                       # Project documentation
```

---

## 🚀 How to Run on Windows

### Step 1: Set Up the Database
1. Open **SQL Server Management Studio (SSMS)**.
2. Connect to your SQL Server instance (e.g., `.\SQLEXPRESS` or `localhost`).
3. Open `database/setup_database.sql` in SSMS and click **Execute** (or press **F5**).
4. The database `Csharp` will be created automatically along with all required tables and sample seed data.

### Step 2: Default Login Credentials

After running `setup_database.sql`, use any of the pre-configured accounts:

| Role | Username | Password |
| :--- | :--- | :--- |
| **Admin** | `admin` | `123` |
| **Manager** | `manager` | `123` |
| **Salesman** | `salesman` | `123` |

### Step 3: Open & Run in Visual Studio
1. Double-click `src/SuperShopManagementSystem.sln` to open the solution in Visual Studio 2019 or 2022.
2. Ensure `DataAccess.cs` connection string matches your local SQL Server instance:
   ```csharp
   string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Csharp;Integrated Security=True;";
   ```
3. Press **F5** or click **Start** to run the application.

---

## 📄 CV / Resume Bullet Points

If you are adding this project to your CV or Resume, here is a recruiter-ready summary:

**Super Shop Management & POS System** | *C#, WinForms, MS SQL Server, iTextSharp*
- Developed a desktop Point of Sale (POS) and store management application featuring role-based authentication (Admin, Manager, Salesman) and SQL Server database integration.
- Engineered the Salesman POS billing module, incorporating real-time cart calculations, discount/tax handling, customer registration, and PDF invoice printing with `iTextSharp`.
- Designed relational SQL database schemas (`TransactionTbl`, `customerInfoTbl`, `InventoryTbl`) to manage transactions, inventory stock, and employee records.
