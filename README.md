# Pierre's Sweet and Savory Treats

#### Website that markets treats - learning project for Epicodus course for practice with authentication, many-to-many relationships, and databases

#### By Shanen Cross

## Technologies Used

* C#
* .NET 5 SDK
* ASP.NET Core MVC
* Entity Framework Core
* ASP.NET Core Identity
* MySQL
* HTML
* CSS
* Bootstrap

## Description

A Learning projecting for the Epicodus class. This project is for practicing authentication via ASP.NET Core Identity, along with many-to-many relationships between database tables.

This application will market treats. Treats and flavors are stored in database tables with a many-to-many relationship. Users who are logged in can create, update, and delete treats and flavors.

Features:
* The application has user authentication. Users can register an account, and log in/out.
* Only logged in users have create, update and delete functionality. All users should be able to have read functionality.
* There is a many-to-many relatinship between flavors and treats
* A splash page lists all treats and flavors. 
* Users can click on an individual treat or flavor to see all the treats/flavors that belong to it.

## Setup/Installation Requirements

### Installing Prerequisites
* Install git
* Install the [.NET 5 SDK](https://dotnet.microsoft.com/download/dotnet/5.0)
* Install [MySQL](https://dev.mysql.com/downloads/mysql/) and create a server with a password of your choosing

### Installing Application
* Use ```git clone``` to download this repository to a local directory
* Navigate to this local directory in your terminal
* Navigate to the ```/Library``` folder in your terminal
* Enter ```dotnet restore``` to install packages
* Enter ```touch appsettings.json``` to create an appsettings file.
* Open appsettings.json with a text editor and enter the following, replacing \[PASSWORD\] with your chosen server password:
```
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=shanen_cross;uid=root;pwd=[PASSWORD];"
  }
}
```

### Generating Database
* If you aren't there already, navigate to the ```/Library``` subfolder in your terminal
* Enter the following to generate the database using the migration:
```
dotnet ef database update
```

### Running Application
* Enter ```dotnet run``` to build and run the application; or alternatively, use ```dotnet watch run``` to make the server refresh whenever a file is saved
* The terminal will output that it is "Now listening on" a certain URL. For me this is ```http://localhost:5000```, but it could be different.
* Navigate in your web browser to whatever URL is displayed. This will show the home page.

### Instructions

* Anyone can view the treats and flavors! But for more functionality, you'll need to register an account. 
* Click the "Register or Login" button, then click on "Register".
* Enter your email and desired password and submit the form.
* Now navigate to the "Log In" and enter the same email and password.
* Now return to the home page. There will be new links available that allow you to add and modify flavors and treats. Enjoy!
* You can also log out anytime with the "Log Out" option on the home page.
* If you do, you'll need to sign in again with the same email/password to continue using the additional functionality!

## Known Bugs

None.

## License

[MIT](LICENSE)

Copyright (c) 2021 Shanen Cross
