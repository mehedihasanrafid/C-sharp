# How to Run the Super Shop Management System on Windows

This guide provides step-by-step instructions to set up the database, open the solution, and run the **Super Shop Management System** on a Windows computer.

---

## 🛠️ Prerequisites Checklist

Before running the project on Windows, ensure you have the following installed:

1. **Microsoft Visual Studio 2019 or 2022** (Community, Professional, or Enterprise)
   - Workload required during installation: **.NET desktop development**
   - Targeting pack required: **.NET Framework 4.7.2**
2. **Microsoft SQL Server** (SQL Server Express or Developer Edition)
3. **SQL Server Management Studio (SSMS)** (To manage the database)

---

## 📥 Step 1: Database Setup (Import Schema & Seed Data)

1. Launch **SQL Server Management Studio (SSMS)** on Windows.
2. In the Connect to Server dialog:
   - **Server type**: Database Engine
   - **Server name**: `.\SQLEXPRESS` (or `localhost` depending on your installation)
   - **Authentication**: Windows Authentication (or SQL Server Authentication)
   - Click **Connect**.
3. In SSMS, click **File -> Open -> File...** and select:
   ```
   database\setup_database.sql
   ```
4. Click **Execute** (or press **F5**).
5. Verify in the Object Explorer that the **`Csharp`** database appears under **Databases**.

---

## 🔐 Default Login Credentials

The `setup_database.sql` script populates initial accounts so you can test all user roles immediately:

| Role | Username | Password | Features Available |
| :--- | :--- | :--- | :--- |
| **Admin** | `admin` | `123` | Employee management, financial analytics, total sales, costs |
| **Manager** | `manager` | `123` | Product restock, inventory control, product category management |
| **Salesman** | `salesman` | `123` | Point of Sale (POS) billing, PDF invoice printing, customer registration |

---

## 💻 Step 2: Open & Configure in Visual Studio

1. Navigate to the project folder on Windows:
   ```
   SuperShopManagementSystem\src\
   ```
2. Double-click **`SuperShopManagementSystem.sln`** to open the project in Visual Studio.
3. Open `DataAccess.cs` in the Solution Explorer (under `SuperShopManagement`).
4. Verify line 38 matches your local SQL Server instance name:
   ```csharp
   // Standard Windows Authentication connection string
   string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Csharp;Integrated Security=True;";
   ```
   *(Note: If your SQL Server instance name is different, update `.\SQLEXPRESS` to your server name, e.g. `localhost` or `(localdb)\MSSQLLocalDB`)*

---

## ▶️ Step 3: Run the Application

1. In Visual Studio, click **Build -> Build Solution** (or press `Ctrl + Shift + B`).
2. Click **Start** (or press **F5**) to run the application.
3. The Login window will appear.
4. Enter any of the pre-seeded credentials (e.g., Username: `admin`, Password: `123`) and click **Login**.

---

## ❓ Troubleshooting Common Errors

### 1. `SqlException`: Connection refused or server not found
- **Cause**: SQL Server service is not running or server name in `DataAccess.cs` is incorrect.
- **Fix**: Open Windows Services (`services.msc`), ensure **SQL Server (SQLEXPRESS)** is Running, and verify the server name in `DataAccess.cs`.

### 2. `SqlException`: Cannot open database "Csharp"
- **Cause**: The database script was not executed yet.
- **Fix**: Re-open `database\setup_database.sql` in SSMS and press **F5**.

### 3. Missing `iTextSharp.dll` or build errors
- **Fix**: In Visual Studio, right-click the project in Solution Explorer -> select **Restore NuGet Packages**.
