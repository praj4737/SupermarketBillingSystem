# Retail and Supermarket Billing System

## Table of Contents

- [About the Project](#about-the-project)
- [Features](#features)
- [Technologies Used](#technologies-used)
- [System Requirements](#system-requirements)
- [Installation](#installation)
  - [1. Clone the Repository](#1-clone-the-repository)
  - [2. Set Up the Database](#2-set-up-the-database)
  - [3. Configure the Connection](#3-configure-the-connection)
  - [4. Run the Application](#4-run-the-application)


---

## About the Project

The **Retail and Supermarket Billing System** is a desktop application developed in **VB.NET** that allows retail businesses to manage billing operations efficiently. The system includes features for managing products, customers, billing, and inventory.

## Features

- User authentication and role-based access
- Product management 
- User management
- Billing and invoice generation
- Inventory tracking
- Sales reports

## Technologies Used

- **VB.NET** (Windows Forms Application)
- **MySQL Community Server** (Database)

## System Requirements

- Windows 10/11
- Visual Studio (with .NET Framework support for VB.NET)
- MySQL Community Server
- MySQL Workbench (optional for database management)

## Installation

### 1. Clone the Repository

```sh
git clone https://github.com/your-username/retail-billing-system.git
cd retail-billing-system
```

### 2. Set Up the Database

1. Install MySQL Community Server if not already installed.
2. Open MySQL Workbench (or any MySQL client) and create a new database:
   ```sql
   CREATE DATABASE Abc_Mart;
   ```
3. Import the provided SQL file `Abc_Mart_data.sql`:
   ```sh
   mysql -u root -p Abc_Mart < Abc_Mart_data.sql
   ```

### 3. Configure the Connection

1. Open the project in Visual Studio.
2. Locate the database connection settings in the application (`config.vb` or `app.config`).
3. Update the connection string with your MySQL credentials:
   ```vb
   Dim connectionString As String = "Server=localhost;Database=Abc_Mart;User ID=root;Password=yourpassword;"
   ```

### 4. Run the Application

1. Build the project in Visual Studio (`Ctrl + Shift + B`).
2. Run the application (`F5`).
3. Log in with default credentials (if provided in the database dump) or create a new account.


