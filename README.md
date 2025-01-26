# HardkorowyKodsu
 
## Server App:
- ASP.NET Core Web API solution  
- Assumes localhost/SQLExpress as the target DBMS with AdventureWorks as the default database  
- Two available controllers - TablesController and ColumnsController with single REST GET methods  
- API Endpoints:  
  - Tables/Views list: https://localhost:7152/api/Tables  
  - Columns list: https://localhost:7152/api/Columns?name={tableName}  
- Swagger for dev purposes: https://localhost:7152/swagger/index.html  

![image](https://github.com/user-attachments/assets/c8545891-5d86-4185-8ef7-884941f77982)  
___

## Client App:  
- Windows Forms solution  
- Uses API/Server data from above  
- Gets Tables/Views list on app initialization  
- Columns are acquired whenever selected table/view is changed  
- In case the target DB schema changes during app runtime a "Refresh Table List" is available  

![image](https://github.com/user-attachments/assets/3f7c074f-52b4-4c24-b717-4d9c4162bac9)
