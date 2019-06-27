# Example C# Web Application
## Developed using the [ASP.NET Core MVC pattern](https://docs.microsoft.com/en-us/aspnet/core/mvc/overview?view=aspnetcore-2.2) and [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/).

This open source project ([see license](LICENSE.txt "The GNU Affero General Public License; a free, copyleft license.")) is based on the [MVC tutorial written by Microsoft](https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/?view=aspnetcore-2.2), which walks developers through making a web app with the ASP.NET Core MVC design pattern.  The tutorial shows you how to connect to a Microsoft SQL Server ([Express](https://www.microsoft.com/en-us/sql-server/sql-server-editions-express)), however I made some changes so that it connects to a MySQL Server ([Community](https://dev.mysql.com/downloads/mysql/)).  The Microsoft solution works great, but it can [only handle databases up to 10 GB in size](https://docs.microsoft.com/en-us/sql/sql-server/editions-and-components-of-sql-server-2017?view=sql-server-2017#Cross-BoxScaleLimits "After opening link, scroll to bottom of table.").  As for the MySQL solution, the maximum database/table file size is only restricted by the OS, and [a single table can be as large as 256 TB](https://dev.mysql.com/doc/refman/8.0/en/table-size-limit.html) with default settings (max is 65,536TB).

## Opening this project on your computer:
1. First, you may want to [fork](https://help.github.com/en/articles/fork-a-repo) (make a copy) this project to your GitHub profile. 
2. Next, make sure that you have [.NET Core SDK 2.2](https://dotnet.microsoft.com/download) installed.
3. I haven't tested this project with Visual Studio (VS) 2017, so you may want to install [VS 2019](https://visualstudio.microsoft.com/vs/) before cloning the project to your computer (Community version is free).
4. Clone the project:
    * __macOS__:
    * __Windows__:
      1. After opening VS, look for the _Get started_ section and click the _Clone or check out code_ button.
      2. In the _Repository location_ field, 
