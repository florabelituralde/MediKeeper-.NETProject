# MEDIKEEPER Full-Stack Technical Assessment: 

[![Build Status](https://dev.azure.com/florabelituralde/Medikeeper%20Project/_apis/build/status/medikeeperproject%20-%20CI?branchName=main)](https://dev.azure.com/florabelituralde/Medikeeper%20Project/_build/latest?definitionId=2&branchName=main)

This project is built with ASP.NET MVC and deployed through Azure.

This is what I have accomplished from the time that the task was given and this demonstrates my current skills in ASP.NET.


## These are the project requirements:

### Task 1: Create a data store (your choice, whatever works) from the data and headers in the attached items.txt file (do not hardcode values in app code)

- For this task I have built a database for the data store that I called Wellness Shop which includes three data: Id, Item Name and Cost.

### Task 2: Create a .NET web service endpoint that returns a list of max prices of items grouped by item name

- I created and Index page to view all the data from the database in which you can see that they've been grouped by item name.

### Task 3: Create a .NET web service endpoint that takes as an input an item name and returns the max price for it

- For this task, I have tried everything that I know to execute it but I couldn't make it happen. However, I know that this is a mix of query syntax and method syntax to execute this LINQ query from the search bar. The way I'm thinking of doing it is to return only the First() or Last() item on the sorted list after the user input the item name.

### Task 4: create a .NET web service endpoint allow the user to create, update, or delete data in the data store

- I have implemented CRUD on the project by scaffolding the Model of the database.

### Task 5: Create and style a modern reactive Javascript-based UI (your choice of Angular, React, or Vue is fine, here) that allows a user to request the data from the web services in Tasks 2-4, and enables the user to allow the user to change data and view the entire data set in the data store via the UI.

- I am an entry-level .NET developer and my Javascript skills are not very good yet to make the whole UI javascript-based. Since the day that the task was given, I have tried to learn jQuery and Ajax to try to incorporate it on my project to create a modal for the DELETE and CREATE actions to implement some Javascript actions. I am very eager to learn and I know that I could make this happen if I'm given more time to learn and accomplish the project.

### Task 6: Deploy the web service to your choice of cloud-based hosting platform (Heroku, Azure, AWS, etc., whatever works for you) and provide MediKeeper (bflowers@medikeeper.com) with the following:

a) URI or webpage we can use to directly test the Task 2-4 endpoints without going through the web app UI

b) URL of the web app consuming the API endpoints

### Task 7: Commit all of your project code to your choice of code repository (Github, Azure Devops, etc., whatever works for you) and provide MediKeeper with access to the code repo. It’s fine to make your repo public, for the sake of convenience.

Pro Tip: if you want your project to really stand out, then taking the time to implement unit-tests (especially front-end) is highly recommended!

- I have implemented unit tests on my project which includes a Data test and Controller test in which you can see here:

![First Test](https://i.ibb.co/q7T2cqz/First-Test1.png)


![Second Test](https://i.ibb.co/zxknYc1/Second-Test1.png)
