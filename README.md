# Ecommerce MVC Core Project

Welcome to the **Ecommerce-MVC_Core_Project** - a fully featured eCommerce application built with ASP.NET Core MVC and Entity Framework Core. This application supports both user and admin functionality, providing an interactive product shopping experience for users and comprehensive product management capabilities for admins.

## Table of Contents
- [Overview](#overview)
- [Features](#features)
- [Architecture](#architecture)
- [Setup & Installation](#setup--installation)
- [Usage](#usage)
- [Contributions](#contributions)

## Overview
This project is an ASP.NET Core MVC eCommerce application with separate functionalities for users and admins. Users can browse products, add items to their cart, and place orders, while admins can manage the product catalog and approve pending orders. Built with Entity Framework Core, this application ensures reliable data management and user-friendly interfaces.

## Features
- **User Login**: Secure login for customers to access product listings and cart functionalities.
- **Admin Login**: Secure login for admins to manage the eCommerce site.
- **User Dashboard**:
  - View product listings.
  - Add products to the cart.
  - Place orders.
- **Admin Dashboard**:
  - Add, edit, and delete products.
  - View and approve pending orders.
- **Database Interaction**: Entity Framework Core handles data management, providing robust CRUD functionality.
- **Model Binding & View Design**: Model binding and custom views for organized display and functionality.
  
## Architecture
The application is structured as follows:
1. **Controllers**:
   - `UserController` - Manages user login, product listing, and cart operations.
   - `AdminController` - Manages admin login, product management, and order approval.
  
2. **Models**:
   - **Product Model** - Represents product details.
   - **Order Model** - Manages order details for users.
   - **Cart Model** - Facilitates cart management for users.

3. **Views**:
   - Contains Views for both User and Admin functionalities to facilitate UI and data binding.

4. **Configuration**:
   - **Database Connection**: Set in `web.config` with `connectionString`.
   - **EF Migrations**: Run `update-database` to initialize and update the database.

## Setup & Installation

### Prerequisites
- **Visual Studio** (with ASP.NET Core and web development workloads)
- **SQL Server** or **LocalDB**

### Steps
1. **Clone the Repository**:
   ```bash
   git clone https://github.com/MonirInCode/Ecommerce-MVC_Core_Project.git

2. **Open in Visual Studio**:

Open the solution in Visual Studio.
3. **Configure Database**:

Ensure your database configuration is correct in web.config.
Navigate to the Package Manager Console and run: **update-database**

4. **Build and Run**:
Run the project to start the Ecommerce-MVC_Core_Project.

## Usage
**Admin Login Details**:-
Email = admin@gmail.com ,
Password = "12345"

**Admin**: Log in to add, edit, and delete products.View and approve pending orders.

-------------------------
**User-1**
Email = "monir@gmail.com",
Password = "123"

--------------
**User-2**
Email = "shefain@gmail.com",
Password = "123"

Log in to view products, add items to the cart, and place orders.

## Screenshots

![P-1](https://github.com/user-attachments/assets/2af81b5d-fe2f-4a9f-8671-272e2f3a4681)

![P-2](https://github.com/user-attachments/assets/0f09aaf9-1a60-4565-b080-dc12501e64f0)

![P-3](https://github.com/user-attachments/assets/5ec35a07-66df-4274-b8fc-5f115c42429e)

![P-4](https://github.com/user-attachments/assets/0ca42cf1-89d4-4d13-9546-e2c9905a0de5)

![P-5](https://github.com/user-attachments/assets/e1e0dff5-94f7-4c2a-97f8-1aef97aa71a4)

![P-6](https://github.com/user-attachments/assets/3d1652e4-e612-4571-86dc-0545a28522bc)

![P-7](https://github.com/user-attachments/assets/81da9884-5df4-4556-9fdc-3e384a3c0f8f)

![P-8](https://github.com/user-attachments/assets/95fa3cc6-9164-429b-acf4-8097353cb72d)

![P-9](https://github.com/user-attachments/assets/8a3f1d49-e0ae-4ebb-b962-0fcb93fe773b)

![P-10](https://github.com/user-attachments/assets/ee4c5088-9ff8-4a61-8207-b454666e9fb6)

![P-11](https://github.com/user-attachments/assets/6c1613ba-f23e-432a-9e99-00980d8de9e5)

![P-12](https://github.com/user-attachments/assets/b2a0fbdb-0a23-45e3-804d-eb307d50fe62)

![P-13](https://github.com/user-attachments/assets/a020d6cd-a329-4620-bff5-db249d95daf5)

![P-14](https://github.com/user-attachments/assets/94d4c6a8-f8bc-4af0-a2de-f4c049b71bdd)

![P-15](https://github.com/user-attachments/assets/9332cf96-05fe-40f6-a222-631978d55546)

## Contributions
Contributions are welcome! To contribute:

Fork this repository.
Create a new branch (feature/my-feature).
Commit your changes.
Push to your branch and submit a Pull Request.

## Contact
For questions or feedback, reach out at monirgsc@gmail.com
