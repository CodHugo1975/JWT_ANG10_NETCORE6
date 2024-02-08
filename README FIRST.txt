Previous requirements:

DEFAULT BROWSER, GOOGLE CHROME.
Visual Studio 2022
Visual Studio Code
SQL Server 2019 or higher.
SQL Management Studio v17.8.1

IMPORTANT!!
* NodeJS 16.20.2 for windows 10
* Angular 10 CLI

 (OPTIONAL) POSTMAN for Windows 10

(RECOMMENDED OPTION) NVM: NODE VERSION MANAGER.
https://realworlddev.hashnode.dev/installing-nvm-on-windows-11

* NVM ALLOWS YOU TO INSTALL AND USE MULTIPLE VERSIONS OF NODE JS. THIS IS BECAUSE THE NEW
VERSIONS OF NODE JS MAY NOT FULLY SUPPORT OLD VERSIONS OF ANGULAR.

--------------------------------------------------

WHAT'S THIS APPLICATION ABOUT?

Description:

THIS A CLASSIC INTRANET COMPANY  APPLICATION WHICH IMPLEMENTS A LOGIN PAGE INTENDED FOR 
REGISTERED USERS OF THE COMPANY.
AFTER A SUCCESSFUL AUTHENTICATION THIS APPLICATION CREATES A JWT TOKEN WHICH WILL ALLOW THE USER TO HAVE ACCESS TO THE FULL LIST OF USERS OF THIS APPLICATION.

--------------------------------------------------

HOW TO RUN IT LOCALLY?

Database:

1- Open SQL Management Studio.

2- Create a Database CompanyLoginDB.

3- Restore backup from the file login.bak in the folder \\JWT_ANG10_NETCORE6\DB

---------------------

WEB API:

1- Open the solution located in the folder \\JWT_ANG10_NETCORE6\code\WEBAPI6\LabAPI.sln

2- Right click on the solution name in the Solution Explorer --> select Clean option.

3- Right click on the solution name in the Solution Explorer --> select Build option.

4- BEFORE DOING ANYTHING, BACKUP THE CODE.

In case of errors related to the database, change the servername/database, with the name of your local database server
   in the command indicated below:

	   Scaffold-DbContext "Server=YourDBServerName\SQLEXPRESS; DataBase=GasStationDB;Integrated Security=true" Microsoft.EntityFrameworkCore.SqlServer -OutPutDir Models 

	Then proceed to copy the command indicated above.

5- Go to WebAPI project. 
6- In the Program.cs file, comment the lines 
	- using Models
	
	- builder.Services.AddDbContext<CompanyLoginDBContext>();

7- Delete all the files in the Models folder.

8- Proceed to go the Menu, select Tools, select Nuget Package Manager, select Package Manager Console.

9- In the console, paste the command copied on the step 4.

10- Hit enter

11- Rebuild the WebAPI project.

12- Rebuild the whole solution.

13- On the solution name, right click, then select Properties.

15- Run the solution.

--------------------------

Angular:

1- Open a new Windows explorer window on the path :

    \\JWT_ANG10_NETCORE6\code\ANGULARJWT

2-  In the address bar of the opened window type in "CMD", then hit ENTER.

3- In the new command line window type in "code ." then hit ENTER.

4- A new instance of Visual Studio Code will display the code of Angular 10.

5. In the new command line window type in "npm start" then hit ENTER.

6- Wait until the new Google Chrome browser opens up a new Internet window.

7- You should now see a Login page.

8- Enter User2 as user and 1234 as password then hit ENTER.

--------------------------------------------------
