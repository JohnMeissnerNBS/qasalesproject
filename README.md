# qasalesproject


- PROJECT OVERVIEW -

Project overview
You are tasked with creating a sales report console application which an end user can interact with via C sharp. A relational database (MySQL) should be used to store and persist the sales data.

Database Requirements

Your MySQL database requires a single Sales table containing the following fields:
SaleID (INT) – Primary Key
Product Name (VARCHAR)
Quantity (INT)
Price (FLOAT/DECIMAL)
SaleDate (DATE) – Should automatically default to the days date

Ensure the database and its table are created with the appropriate names, data types and constraints.

Project Requirements

The following requirements are must haves:
Upon starting the application, the user must be presented with the following two options at a minimum:
Data Entry
Reports

If the user selects Data Entry, they must be able to add a new sales record to the sales table in the database.

If the user selects Reports, they must be presented with the following four options at a minimum:
Sales by Year (e.g. List of all sales in the year 2020 printed to the console)
Sales by Month and Year (e.g. List of all sales in January of 2020 printed to the console)
Total Sales by Year (e.g. The total amount of sales for 2021, i.e. the sum of all the sales)
Total Sales by Year and Month (e.g. The total amount of sales for January of 2021)

MySQL queries are required for each of the Reports options, your program will run these against the database and retrieve the data to build the relevant report for the end user.

IMPORTANT: 	Some reports would be filtered by the year the user enters, other reports require user to enter a month AND year to filter the reports.
The project must be completed using only C# and MySQL, you must frequently commit your work to GitHub to record your progress.
Extra Requirements

The following requirements are should haves, these are not required by the client but would be nice to have available in the application:
Extra reports:
All sales between two specified years (inclusive)
All sales between two specified years and months (inclusive)
The average sales for a given month over a specified amount of years (Example output: July over the past 3 years has averaged £4500 in sales)
The average sales per month for a specified year (Example output: In 2021, the average amount of sales per month is £4000)
The month of a specified year that made the most sales (Example output: In 2018, the highest sales were made in February at £7500)
The month of a specified year that made the least sales


- WHY ARE WE DOING THIS PROJECT -

This project is being done to test how well I've taken in the knowledge which I've been taught which for this project will be GIT Hub, Jira and agile working and also C# programming language.

- HOW DID I EXPECT THE CHALLENGE TO GO -

I found it difficult to keep up with the C# lectures as the learning style was too fast for me. Due to this I felt concerned that I would struggle to complete the project.

- WHAT WENT WELL -

I managed to create a menu and sub menu and link up the MenuController and RecordService classes. I also partially completed a repository, CreateReadRepository and a Utils class but these were incomplete.

It was generally good to actually have an extended period of practical practice on C sharp so that I could figure out for myself why certain things werent working which helped improve my overall understanding of the language.

- WHAT DID NOT GO SO WELL -

As I thought I did find the project very difficult overall as I felt undermined by the fact that I was unable to fully understand all of the material taught. This meant that I had gaps where my understanding was limited and hence this affected my ability to complete the project.

- POSSIBLE IMPROVEMENTS FOR THE FUTURE -

I think I just need to keep exposing myself to C sharp as a programming language and read up on it more. I also think it would be good to find challenges online and try and complete them to gain experience and further knowledge. 

- NOTABLE MENTIONS -

Morgan Walsh, QA trainer - A lot of the code will look very similar to that of Morgan's as I watched back a lot of his tutorials to help me try and complete the project correctly.

User: bluebeel (Stackoverflow.com) - I also used some of the code from this users menu/submenu to help me create my menu class in the project.
