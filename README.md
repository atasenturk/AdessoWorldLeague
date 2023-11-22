# AdessoWorldLeague
Adesso Turkey code challenge

API created for Adesso branches located in different countries to draw lots and place them in groups of 8 or 4

Migrations are ready in project files. The project runs on local database and requires mssql. Using Migration, the database is created with "update-database" and then the API starts working with this data.

List of groups formed after the draw:

![image](https://github.com/atasenturk/AdessoWorldLeague/assets/99036126/6f34c09a-5078-4a8b-987f-7e15caa8570c)

This is how the database is displayed as a result of placement with one branch from each country. Each branch and which group it is in can be seen in this way.

Also an Endpoint was written that returns the placements as a result of the draw (TeamDraw/draw)
As a result, the response returned is in the following format.

![image](https://github.com/atasenturk/AdessoWorldLeague/assets/99036126/24bb5542-eae3-4341-8ef5-baf594da0180)



When the draw is completed, the data is also written to a .txt file:
![image](https://github.com/atasenturk/AdessoWorldLeague/assets/99036126/8030f949-c6c5-4ab9-987f-e9bf60afa0f2)

All endpoints and what they do:

GET:/api/countries : Returns all the countries

GET:/api/draws : Returns last draw information

GET:/api/groups : Returns all the groups

POST:/api/teamdraw/draw : Draws the lottery, processes the information in the database and writes the groups to a text file

GET:/api/teams : Returns all the teams



