#*** Installation ***
### Step 1 : Create Database
### Step 2 : Create ASP.NET Core Web API
### Step 3 : Build Layer
### Step 4 : Connect to Database
#** Notes **
## Edit Connection String and paste it at appsetting.json:
"ConnectionStrings": {
    "DefaultConnection": " ___USING-YOUR-CONNECTION-STRING_____"
}
## Add Nugets:
### Mở Package Manager Console và chạy lệnh:
Install-Package Microsoft.EntityFrameworkCore
Install-Package Microsoft.EntityFrameworkCore.SqlServer
Install-Package Microsoft.EntityFrameworkCore.Tools
