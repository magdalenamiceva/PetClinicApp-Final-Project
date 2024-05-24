This is the final project from the Full Stack .Net Academy. We builded a .NET MVC Web Application for a Veterinary Client which were allowed for the tracking of Pets and Owners and Vaccines. 

We can split this project in a few parts:
- Creating Authorization and Authentication with individual accounts and roles.
- Database Diagram creation, model creation and Creating the DB with Entity Framework Core
- Scaffolding the Views for the Models
- Creating a Test project and writing Unit tests
- Implementing caching mechanisms on the index endpoints for the entities with absolute and sliding expiration, also cache key removal when updating entities.

Owner model contain GetFullName() function which will return name + surname to be used in the Pet index, Details and Delete View.

The application helps to track which pet belongs to which owner and what vaccines the pet has taken. 
For Each Owner we have the following data: Name, Surname, Age and for each Pet we have Name and Age and Vaccine Names he had taken.
For Each Vaccine we only have the name. 
The owner age limit is above 18 - 100 years as well. 
The pet age is from 0 to 50 years. 
Additionally, We linked the Owners and Pets, one owner is able to have more Pets, and one Pet have one Owner. 
Also we linked the Pets and Vaccines in a way that one Pet can have multiple Vaccines and one vaccine can have multiple Pets.
