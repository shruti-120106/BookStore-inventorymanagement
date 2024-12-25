Inventory Management System
This project is an Inventory Management System created using C# Windows Forms and SQL Server. It allows for managing products, stock, and orders efficiently.

Features
User Authentication
Product Management
Order Management
Stock Tracking
Database Integration
Database
The database is created using SQL Server. The database script is available in the script.sql file.

Database Creation: The script.sql contains the necessary SQL commands to create the required tables and relationships for the project. One can get an idea of database from that file.

Connection String: The connection string for the database is provided as an example in the code. You can customize the connection string to point to your local or remote SQL Server instance.

Database Setup:

If the script.sql includes a CREATE DATABASE command, you can run it directly in SQL Server Management Studio (SSMS) to create the database and tables.
If the script doesn’t include a CREATE DATABASE command, you will need to manually create the database in SQL Server first and then run the script to create the necessary tables and relationships.

add or replace the connection string where ever it mentioned
Example Connection String:
csharp
Copy code
Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;
You will need to replace myServerAddress, myDataBase, myUsername, and myPassword with your actual SQL Server details.
