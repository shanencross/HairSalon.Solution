# Hair Salon

#### Learning project for Epicodus course for database practice with one-to-many relationships

#### By Shanen Cross

## Technologies Used

* C#
* .NET 5 SDK
* ASP.NET Core MVC
* Entity Framework Core
* MySQL

## Description

A Learning projecting for Epicodus class. Purpose is to practice using databases with ASP.NET Core MVC and Entity Framework Core. Uses a one-to-many database relationship.

MVC web application for a salon which has stylists and clients. Every stylist has many clients, but every client only sees one stylist.

The website has the following featurse:
* Display list of a stylists
* View the details of a particular stylist
* Add a new stylist
* Add a client to a specific stylist (only if there are any stylists)

## Setup/Installation Requirements

### Installing Prerequisites
* Install git
* Install the [.NET 5 SDK](https://dotnet.microsoft.com/download/dotnet/5.0)
* Install [MySQL](https://dev.mysql.com/downloads/mysql/) and create a database with a name and password of your choosing

### Creating Database
* Enter the following in the terminal, replacing \[PASSWORD\] with the password you selected during your MySQL setup: ```mysql -uroot -p[PASSWORD]```
* Enter the following command for MySQL into the terminal:
```CREATE DATABASE `bestaurants`;
USE bestaurants;
CREATE TABLE `stylists` (
    `StylistId` int(11) NOT NULL AUTO_INCREMENT,
    `Name` varchar(255) DEFAULT NULL,
    `Specialty` varchar(255) DEFAULT NULL,
    PRIMARY KEY (`StylistId`)
);
CREATE TABLE `clients` (
    `ClientId` int(11) NOT NULL AUTO_INCREMENT,
    `Name` varchar(255) DEFAULT NULL,
    `HairColor` varchar(255) DEFAULT NULL,
    `StylistId` int(11) NOT NULL DEFAULT '0',
    PRIMARY KEY (`ClienttId`)
);```

### Installing Application
* Use _git clone_ to download this repository to a local directory
* Navigate to this local directory in your terminal
* Navigate to the _/HairSalon_ folder in your terminal
* Enter _dotnet restore_ to install packages
* Enter _touch appsettings.json_ to create an appsettings file.
* Open appsettings.json with a text editor, enter the following, replacing \[DATABASE_NAME\] and \[PASSWORD\] with the:
```
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=[DATABASE_NAME];uid=root;pwd=[PASSWORD];"
  }
}
```
* Enter _dotnet run_ to build and run the application; or alternatively, use _dotnet watch run_ to make the server refresh whenever a file is saved
* The terminal will output that it is "Now listening on" a certain URL. For me this is _http://localhost:5000_, but it could be different.
* Navigate in your web browser to whatever URL is displayed. This will show the home page.

## Known Bugs

None.

## License

[MIT](LICENSE)

Copyright (c) 2021 Shanen Cross
