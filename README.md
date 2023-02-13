# PropfactMap

How to test the project:
1. Prepare the database propfact in MSSQL.
  You can run initial migration from the project and point the connectionstrings in appSettings.json to your database.
  After the table dbo.AddressPoints has been created, you can seed the data by using bulk insert from the Address_Points.csv file.
  Please see attached "SS1 - Bulk Insert.png" for the SQL query. Please modify the file path based on yours.
  If the query has been run, you can check to confirm the data has been there.
2. Run the .net 6 PropfactMap project.
  You will see a swagger page. The URLs are http://localhost:5192 (non SSL) and https://localhost:7192 (SSL)
3. Run the map.html on your browser.
  Try to zoom out/zoom in and drag to find the Cook County, Illnois area.
  The URL is already set to point to http://localhost:5192
