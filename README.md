# Example .NET Web Application
## Uses the [ASP.NET Core MVC Pattern](https://docs.microsoft.com/en-us/aspnet/core/mvc/overview?view=aspnetcore-2.2) and [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/).

This open source project ([see license](LICENSE.txt "The GNU Affero General Public License; a free, copyleft license.")) is based on the [MVC tutorial written by Microsoft](https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/?view=aspnetcore-2.2), which walks developers through making a web app with the ASP.NET Core MVC design pattern.  The tutorial shows you how to connect to a Microsoft SQL Server ([Express](https://www.microsoft.com/en-us/sql-server/sql-server-editions-express)), however I made some changes so that it connects to a MySQL Server ([Community](https://dev.mysql.com/downloads/mysql/)).  The Microsoft solution works great, but it can [only handle databases up to 10 GB in size](https://docs.microsoft.com/en-us/sql/sql-server/editions-and-components-of-sql-server-2017?view=sql-server-2017#Cross-BoxScaleLimits "After opening link, scroll to bottom of table.").  As for the MySQL solution, the maximum database/table file size is only restricted by the OS, and [a single table can be as large as 256 TB](https://dev.mysql.com/doc/refman/8.0/en/table-size-limit.html) with default settings (max is 65,536 TB).

## Opening this project on your computer:
1. First, you may want to [fork](https://help.github.com/en/articles/fork-a-repo) (make a copy) this project to your GitHub profile. 
2. Next, make sure that you have [.NET Core SDK 2.2](https://dotnet.microsoft.com/download) installed.
3. I haven't tested this project with Visual Studio (VS) 2017, so you may want to install [VS 2019](https://visualstudio.microsoft.com/vs/) before cloning the project to your computer (Community version is free).
4. Clone the project:
    * __macOS__:
    * __Windows__:
      1. After opening VS, look for the __Get started__ section and click the __Clone or check out code__ button.
      2. In the __Repository location__ field, paste the web URL for [this project](https://github.com/RichardPoulson/mysql_webapp_mvc.git) __or__ your fork of the project.  Change the local path of the clone if you want, and click the __clone__ button to continue.
      3. After VS clones the project, look for a file named "mysql\_webapp\_mvc.sln" in the __Solution Explorer__ view (If the view doesn't open automatically, go to __View__ -> __Solution Explorer__ in the VS menu bar).  Right-click on the file, and select the __Open Folder in File Explorer__ option.  After File Explorer finishes opening, close the current instance of VS.
      4. Inside File Explorer, __double-click mysql\_webapp\_mvc.sln__ to import the solution (the solution file needs to be opened after a clone). After VS finishes importing the solution, click on __File__ -> __Close Solution__ in the VS menu bar.
      5. This will take us back to the VS welcome screen.  In the __Open Recent__ section, you should see __two entries__ for mysql\_webapp\_mvc; one with a folder icon and the other with a VS solution icon.  __Right-click__  on the entry __with the folder icon__ and select __Remove From List__ (we want a link to the solution, not the folder).  Now you can use the remaining link to open your VS solution for the web app.

## Running/debugging the project:
1. __Note__: This web app utilizes HTTPS, so you will need to install/trust a security certificate the first time that you run the web app.

## Helpful websites:
* [Entity Framework Core - creating/configuring a model](https://docs.microsoft.com/en-us/ef/core/modeling/)
* [Polemo Entity Framework Core - install instructions](https://www.nuget.org/packages/Pomelo.EntityFrameworkCore.MySql)
  * __Tools__ -> __NuGet Package Manager__ -> __Package Manager Console__
  * [Pomelo: MySQL services configuration](https://github.com/PomeloFoundation/Pomelo.EntityFrameworkCore.MySql#getting-started)
