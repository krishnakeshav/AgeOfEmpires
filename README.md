# AgeOfEmpires
#Solution to the problem related to age of empires using .Net core

Problem statement


Age of empires II is a classic real time strategy game with various units like  
Archer, ID = 1 
Crossbowman, ID = 2 
Spearman, ID = 12 
The game has 100 different units 
Each unit has attack and hitpoints attributes and they together determine the overall superiority of the unit in a battle.  
Example  
Archer: attack =  4, hitPoints = 40 
Crossbowman: attack = 5, hitpoints = 20  
So in a one on one battle between Archer and Crossbowman. Crossbowman will die first. 
Archer only needs 5 hits (20/4) to kill a Crossbowman, whereas Crossbowman needs 8 (40/5) hits to kill an Archer.  
 
Write WebAPI Method/MVC Action  that chooses 2 units randomly (i.e. choose 2 random integers between 1 and 100) and determine which unit is superior in a battle.  
 
You have to use the following public api with no authentication 
GET https://age-of-empires-2-api.herokuapp.com/api/v1/unit/{ID} 
 
API Docs : Age of Empires II API (age-of-empires-2-api.herokuapp.com)
 
Example Request:  
GET "https://age-of-empires-2-api.herokuapp.com/api/v1/unit/7" 
Example Response: 
Status Code 200:  
{ 
  "id": 7, 
  "name": "Skirmisher", 
  "hit_points": 30, 
  "attack": 2, 
} 
 
Status Code 404: 
{ 
  "message": "Unit not found" 
} 
 
500: Internal Server Error 
 
We evaluate your response based on  
Accuracy and Efficiency 
Your code should scalable 
Error handling (optional)
How you break down the problem and make use of OOP.  
Code readability. (variable names, indentation, white space etc) 
Design patterns if needed.  
Do you KISS (Keep it simple and stupid) 


Development Specs -
C#
ASP.Net Core v3.1
Api - http://localhost:5000/ageofempires
