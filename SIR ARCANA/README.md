# Inventory Management System - User Management Module

A comprehensive C# WinForms desktop application for inventory management with user authentication and role-based access control.

## Features

### 🔐 Authentication System
- **Login Form** with logo placeholder and clean UI
- **Password hashing** using BCrypt for security
- **Role-based access** (Admin/Employee)
- **SQLite local database** for offline-first operation

### 👥 User Management (Admin Only)
- **Add new users** with username, password, and role
- **Edit existing users** (including password updates)
- **Delete users** (with protection against self-deletion)
- **View all users** in a data grid with creation and sync timestamps
- **Username uniqueness validation**

### 🎯 Role-Based Dashboards
- **Admin Dashboard**: Full user management interface with sidebar navigation
- **Employee Dashboard**: Clean interface for employee tasks
- **Automatic role-based routing** after Money Manager confirmation

### 💰 Money Manager (Employee Feature)
- **Employee-Only Access**: Opens automatically after successful login for employees only
- **Admin Exemption**: Admins go directly to their dashboard (no Money Manager required)
- **Cash Drawer Tracking**: Input fields for all Philippine peso denominations
- **Supported Denominations**: ₱1,000, ₱500, ₱200, ₱100, ₱50, ₱20, ₱10, ₱5, ₱1
- **Real-time Calculation**: Automatic total calculation as you type
- **Input Validation**: Only accepts numeric input, prevents negative values
- **Workflow Control**: Cancel (return to login) or Proceed (continue to dashboard)
- **Confirmation Dialog**: "Confirm the money?" popup before proceeding
- **Professional UI**: Clean, organized interface with total display

## Project Structure

```
SIR ARCANA/
├── Data/
│   └── DatabaseHelper.cs          # SQLite database operations
├── Forms/
│   ├── LoginForm.cs               # Login interface
│   ├── AdminDashboard.cs          # Admin management interface
│   ├── EmployeeDashboard.cs       # Employee interface
│   ├── UserAddEditForm.cs         # User add/edit modal dialog
│   └── MoneyManager.cs            # Cash drawer tracking
├── Models/
│   └── User.cs                    # User data model
├── Repositories/
│   └── UserRepository.cs          # User CRUD operations
├── Program.cs                     # Application entry point
└── SIR ARCANA.csproj             # Project configuration
```

## Default Credentials

The application comes with pre-configured users:

| Username | Password | Role    |
|----------|----------|---------|
| admin    | admin123 | Admin   |
| employee | emp123   | Employee|
| test     | test     | Employee|

### 🧪 Testing Mode

**Skip Database Option**: Check the "Skip Database (Test)" checkbox on the login form to use mock authentication without requiring database setup.

**Test Credentials** (when Skip Database is checked):
- `admin/admin123` → Admin access
- `employee/emp123` → Employee access  
- `test/test` → Employee access

## Database Schema

### Users Table
- `UserId` (INTEGER, PRIMARY KEY, AUTOINCREMENT)
- `Username` (TEXT, UNIQUE, NOT NULL)
- `PasswordHash` (TEXT, NOT NULL) - BCrypt hashed
- `Role` (TEXT, NOT NULL) - "Admin" or "Employee"
- `LastSynced` (DATETIME, NULLABLE) - For future cloud sync
- `CreatedAt` (DATETIME, DEFAULT CURRENT_TIMESTAMP)

## Dependencies

- **.NET 8.0** - Target framework
- **System.Data.SQLite** - SQLite database provider
- **BCrypt.Net-Next** - Password hashing
- **Windows Forms** - UI framework

## Getting Started

1. **Build the project**:
   ```bash
   dotnet build
   ```

2. **Run the application**:
   ```bash
   dotnet run
   ```

3. **Login** using the default credentials above:
   - **With Database**: Use `admin/admin123` or `employee/emp123`
   - **Skip Database**: Check "Skip Database (Test)" and use any test credentials

4. **Role-Based Flow**:
   - **Admin**: Goes directly to Admin Dashboard (no Money Manager)
   - **Employee**: Money Manager opens automatically:
     - Enter cash drawer amounts for each denomination
     - Watch total calculate in real-time
     - Click **Proceed** to continue to dashboard
     - Click **Cancel** to return to login

5. **Dashboard Access**:
   - **Admin**: Full user management interface
   - **Employee**: Clean dashboard for employee tasks

## Key Features Implementation

### Security
- ✅ **Password Hashing**: BCrypt with salt
- ✅ **Input Validation**: Username/password requirements
- ✅ **SQL Injection Protection**: Parameterized queries
- ✅ **Role-based Access**: Admin vs Employee permissions

### Database
- ✅ **Offline-First**: Local SQLite database
- ✅ **Auto-Initialization**: Creates database and tables on first run
- ✅ **Default Data**: Pre-populated with admin and employee users
- ✅ **Cloud Sync Ready**: LastSynced field for future implementation

### User Experience
- ✅ **Clean UI**: Professional WinForms interface
- ✅ **Error Handling**: User-friendly error messages
- ✅ **Keyboard Navigation**: Enter key support
- ✅ **Confirmation Dialogs**: Delete confirmations
- ✅ **Real-time Updates**: Data grid refreshes after changes

## Future Enhancements

- **Cloud Sync**: API integration for data synchronization
- **Inventory Management**: Product catalog and stock tracking
- **Reporting**: Analytics and reporting features
- **Audit Logging**: Track user actions and changes
- **Advanced Security**: Two-factor authentication, password policies

## Development Notes

- **Modular Architecture**: Clean separation of concerns
- **Repository Pattern**: Data access abstraction
- **Error Handling**: Comprehensive exception management
- **Code Comments**: Well-documented for maintainability
- **Extensible Design**: Ready for additional features

## License

This project is part of the SIR ARCANA Inventory Management System.
