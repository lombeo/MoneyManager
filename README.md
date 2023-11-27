# MoneyManager

#REQUIREMENT
1. You need .NET Framework 6 or higher
2. You need to install Entity Framework
#RUN
1. You must run the SQL statement in the Table.sql file
2. Change the appsettings.json file with your SQL server
3. Turn on the project cmd and run this with your infomation: dotnet ef dbcontext scaffold "server=(Your SQL server);database=(Database Name);uid=(Your uid);pwd=(Your password); database = (Database Name);uid=(Your uid);pwd=(Your password);" Microsoft.EntityFrameworkCore.SqlServer --output-dir Models -f
