# Code First approach

### Install and Import nuget packages

- Microsoft.EntityFrameworkCore.SqlServer
- Microsoft.EntityFrameworkCore.Tools
- Microsoft.EntityFrameworkCore.Design

### Add models
Example: Order, Customer, Product, OrderDetail

### Commands
Package console/Powershell

Add-Migration: It will generate the Migrations classes

If migration classes looks correct then run Update-Database command to update the database with Generated migrations.

- Add-Migration InitialCreate
- Add-Migration CustomerModelUpdate
- Update-Database 

Using dotnet tool

- dotnet tool install -g dotnet-ef
- dotnet ef migrations add InitialCreate
- dotnet ef database update


###

