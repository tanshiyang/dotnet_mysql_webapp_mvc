# Example .NET MySQL Web Application
## Uses the [ASP.NET Core MVC Pattern](https://docs.microsoft.com/en-us/aspnet/core/mvc/overview?view=aspnetcore-2.2) and [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/).

This open source project ([see license](LICENSE.txt "The GNU Affero General Public License; a free, copyleft license.")) is based on the [MVC tutorial written by Microsoft](https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/?view=aspnetcore-2.2), which walks developers through making a web app with the ASP.NET Core MVC design pattern.  The tutorial shows you how to connect to a Microsoft SQL Server ([Express](https://www.microsoft.com/en-us/sql-server/sql-server-editions-express)), however I made some changes so that it connects to a MySQL Server ([Community](https://dev.mysql.com/downloads/mysql/)).  The Microsoft solution works great, but it can [only handle databases up to 10 GB in size](https://docs.microsoft.com/en-us/sql/sql-server/editions-and-components-of-sql-server-2017?view=sql-server-2017#Cross-BoxScaleLimits "After opening link, scroll to bottom of table.").  As for the MySQL solution, the maximum database/table file size is only restricted by the OS, and [a single table can be as large as 256 TB](https://dev.mysql.com/doc/refman/8.0/en/table-size-limit.html) with default settings (max is 65,536 TB).

## Opening This Project on Your Computer:
1. First, you may want to [fork](https://help.github.com/en/articles/fork-a-repo) (make a copy) this project to your GitHub profile. 
2. Next, make sure that you have [.NET Core SDK 2.2](https://dotnet.microsoft.com/download) installed.
3. I haven't tested this project with Visual Studio (VS) 2017, so you may want to install [VS 2019](https://visualstudio.microsoft.com/vs/) before cloning the project to your computer (Community version is free).
4. Clone the project:
    * __macOS__:
      1. After opening VS, select __Version Control__ -> __Checkout...__ from the VS menu bar.
      2. Make sure that the __Type:__ dropdown box is set to __Git__, and paste the web URL for [this project](https://github.com/RichardPoulson/mysql_webapp_mvc.git) __or__ your fork of the project inside the __URL:__ field.  After filling out the URL field, click the __Checkout__ button.
      3. After the cloning completes, you should see a window pane labeled Solution with mysql\_webapp\_mvc listed under it.  if not, click on __View__ -> __Design__ in the VS menu bar.
    * __Windows__:
      1. After opening VS, look for the __Get started__ section and click the __Clone or check out code__ button.
      2. In the __Repository location__ field, paste the web URL for [this project](https://github.com/RichardPoulson/mysql_webapp_mvc.git) __or__ your fork of the project.  Change the local path of the clone if you want, and click the __clone__ button to continue.
      3. After VS clones the project, look for a file named "mysql\_webapp\_mvc.sln" in the __Solution Explorer__ view (If the view doesn't open automatically, go to __View__ -> __Solution Explorer__ in the VS menu bar).  Right-click on the file, and select the __Open Folder in File Explorer__ option.  After File Explorer finishes opening, close the current instance of VS.
      4. Inside File Explorer, __double-click mysql\_webapp\_mvc.sln__ to import the solution (the solution file needs to be opened after a clone). After VS finishes importing the solution, click on __File__ -> __Close Solution__ in the VS menu bar.
      5. This will take us back to the VS welcome screen.  In the __Open Recent__ section, you should see __two entries__ for mysql\_webapp\_mvc; one with a folder icon and the other with a VS solution icon.  __Right-click__  on the entry __with the folder icon__ and select __Remove From List__ (we want a link to the solution, not the folder).  Now you can use the remaining link to open your VS solution for the web app.
5. This project uses the __Pomelo.EntityFrameworkCore.MySql__ NuGet package, which may not be automatically included when the solution is imported.  To check, expand the __mysql\_webapp\_mvc__ -> __Dependencies__ -> __NuGet__ folders, and look for __Pomelo.EntityFrameworkCore.MySql__.  If it isn't listed, do the following:
    * __macOS__:
      1. Install latest updates for VS by clicking on __Visual Studio Community__ -> __Check for Updates...__  Projects created in VS for Windows and imported into VS for Mac can have problems runnning if you don't have the latest updates installed.
      2. __Right-click__ on the __NuGet__ folder and select __Add Packages...__
      3. Enter __Pomelo.EntityFrameworkCore.MySql__  inside the field with the magnifying glass icon.
      4. Check the box next to Pomelo.EntityFrameworkCore.MySql, and click the __Add Package__ button.
    * __Windows__:
      1. __Right-click mysql\_webapp\_mvc__ and select __Manage NuGet Packages...__
      2. Make sure the __Browse__ tab is selected, and enter __Pomelo.EntityFrameworkCore.MySql__  inside the field with the magnifying glass icon.
      3. Select Pomelo.EntityFrameworkCore.MySql, and click the __Install__ button.

## Running/Debugging the Project:
1. __Note__: This web app utilizes HTTPS, so you will need to install/trust a security certificate the first time that you run the web app.

## Helpful Websites:
* [Entity Framework Core - creating/configuring a model](https://docs.microsoft.com/en-us/ef/core/modeling/)
* [Polemo Entity Framework Core - install instructions](https://www.nuget.org/packages/Pomelo.EntityFrameworkCore.MySql)
  * __Tools__ -> __NuGet Package Manager__ -> __Package Manager Console__
  * [Pomelo: MySQL services configuration](https://github.com/PomeloFoundation/Pomelo.EntityFrameworkCore.MySql#getting-started)
