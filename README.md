# PropfactMap

How to test the project:
1. Prepare the database propfact in MSSQL
  You can run initial migration from the project and point the connectionstrings in appSettings.json to your database.
  After the dbo.AddressPoints has been created, you can seed the data by using bulk insert from a csv file
2. Run the .net 6 PropfactMap project
  You will see a swagger page. The URLs are http://localhost:5192 (non SSL) and https://localhost:7192 (SSL)
3. Run the map.html on your browser
  The URL is already set to point to http://localhost:5192
