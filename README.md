# theSite Project README

## Description

theSite is a web application project built using ASP.NET Core. It involves database operations and potentially utilizes OpenAI services. The project includes various dependencies, libraries, and key terms relevant to its implementation.

## Project Structure

- **Connected Services:** This section may include references to databases and possible integrations with OpenAI services.

- **Dependencies:** Lists the main ASP.NET libraries used in the project.

- **Properties:** Mentioned a JSON file related to project properties.

- **wwwroot:** Contains static files like CSS and JavaScript.

- **program.cs:** Explanation of the main application entry point, WebApplicationBuilder, and how the application handles HTTP requests.

## Key Terms

- **Query:** A request for specific information from a database.

- **Enum:** A value type that allows you to define a set of named constants.

## Shortcuts

- **Property Shortcut:** `prop`

- **Constructor Shortcut:** `ctor`

## Models

- **Student Model:**
  - Properties: "pic name" and "grade".
  - Attributes: `[Key]`, `[Required]`, `[StringLength]`, `[Range]`, `[RegularExpression]`, `[EmailAddress]`, `[Compare]`, `[ForeignKey]`.

## AppDbContext File

- The AppDbContext class is defined and inherits from DbContext.
- The class constructor accepts an instance of DbContextOptions<AppDbContext> to configure the database connection.
- The `OnModelCreating` method is overridden to provide custom model configurations if needed.
- `DbSet` properties are defined for each entity class (Actor, Movie, Cinema, Producer, and Actor_Movie).

## SQL Database Configuration

1. Start of configuring SQL Server.
2. Created MS SQL Server DB on the local machine.
3. Connected Db to the Project through Visual Studio.
4. Configured the connection string to the `appsettings.json` file.
5. Configured the AppDbContext in the program (startup) file.
6. Downloaded the `Microsoft.EntityFrameworkCore.SqlServer` NuGet package.
7. End of SQL Server configuration.

## AppSettings.json File

- The `appsettings.json` file stores configuration settings for the application.
- It includes connection strings, logging configuration, application settings, third-party service settings, and environment-specific settings.

## Order of Project Steps

1. [List of ordered project steps]

## Features to Consider for the Future

1. Access to the database outside of the local machine, e.g., hosting the database on a server or cloud-based service like Microsoft Azure SQL Database.
2. Learning about security configurations for protecting the database from potential risks.

## Important Notes

- It's essential to ensure proper security measures when enabling external access to databases. Considerations should be made regarding data privacy, authentication, and authorization to prevent unauthorized access and potential security risks.













<!--- # theSite

Connected Services
  database stuff + openai?

dependencies
  libraries used: mainly asp.net libraries

properties
  json file

wwwroot
  static file with stuff: CSS, js, ect

program.cs
  WebApplication.CreateBuilder(args) method is responsible for creating an instance of the WebApplicationBuilder class, which provides a fluent API for configuring and building the web application.
The WebApplicationBuilder instance allows you to configure various aspects of the application, such as adding services, configuring middleware, setting up routing, and more.
The entry point and execution of the application are handled implicitly by calling the Run method on the built WebApplication instance (app). This starts the application and listens for incoming HTTP requests.
Although the Main method is not explicitly defined in your code, the entry point and execution flow of the application are still handled internally by the ASP.NET Core framework based on the fluent API and the app.Run() method call in your code
  
keyterms
  ----
  query = is a request for specific information from a database.
  enum = value type that allows you to define a set of named constants

shortcuts
-----
property shortcut = prop
constructor = ctor
  
models
------------------
  properties of object (in this case the pic name and grade for a student)

  
  
  [Key] By applying to a property, you ensure it is treated as the primary key when creating the database table, generating      queries, and establishing relationships between entities. 
  
   

  [Required] = namespace to mark a property as required.

  [StringLength]: Specifies the maximum and minimum length constraints for a string property.
  
  [Range]: Specifies the numeric range constraints for a numeric property.
  
  [RegularExpression]: Validates that a string property matches a specified regular expression pattern.
  
  [EmailAddress]: Ensures that a string property has a valid email address format.
  
  [Compare]: Compares the value of a property with another property in the same model.


  [ForeignKey("string")]: A foreign key is a relational database concept used to establish a connection between two tables by referencing the primary key of one table as a column in another table

  data config
  -----
  ![Screenshot 2023-07-12 011152](https://github.com/elias-adam-gh/theSite-repo/assets/122506412/6990b6c7-2759-4a94-84bc-272fe9088c8d)

---for this file to be the official translator between C# models and the sql code inherit from the base class db context so db context now let us try to import the namespace but to do so we need to install the microsoft.entity framework core

constructor will take a parameter that is going to be the db context options and then in here we passes a parameter the file name and that is thebfdb context so just pass it in here i'm going to name this parameter options and then just pass the options parameter to the base class by using the base keyword and then options

regarding the program.cs file:---
The WebApplication class combines the responsibilities of both the Program.cs and Startup.cs files into a single file, simplifying the project structure With this new hosting model, the configuration and pipeline setup are usually done within the WebApplication object itself, instead of a separate Startup.cs file. The configuration code you provided in the Program.cs file is setting up middleware, routing, and default controllers. So, in the case of your project, you don't have a separate Startup.cs file, and the configuration is done directly within the Program.cs file using the WebApplication object.

movie.cs fiel explanation
----
public List<Actor_Movie> Actors_Movies { get; set; }: This is a navigation property representing a one-to-many relationship between Movie and Actor_Movie entities. It indicates that a Movie can have multiple associated Actor_Movie records.

public Producer Producer { get; set; } and public int ProducerId { get; set; }: These two properties represent a relationship between Movie and Producer entities. The Producer property is a navigation property indicating that a Movie is associated with a single Producer. The ProducerId property is the foreign key that corresponds to the primary key of the Producer entity.

public Cinema Cinema { get; set; } and public int CinemaId { get; set; }: Similarly, these two properties represent a relationship between Movie and Cinema entities. The Cinema property is a navigation property indicating that a Movie is associated with a single Cinema. The CinemaId property is the foreign key that corresponds to the primary key of the Cinema entity.


-------------

appDbContextfile explanation
------
The AppDbContext class is defined and inherits from DbContext, which is provided by Entity Framework Core.
The class constructor accepts an instance of DbContextOptions<AppDbContext> and passes it to the base class constructor to configure the database connection.
The OnModelCreating method is overridden to provide custom model configurations, if needed. It can be used to define relationships, configure primary keys, etc. The base class implementation of this method is called using base.OnModelCreating(modelBuilder) to ensure the base configurations are applied.
DbSet properties are defined for each entity class (Actor, Movie, Cinema, Producer, and Actor_Movie). These properties represent the corresponding database tables and allow querying and manipulating data using LINQ or Entity Framework methods

sql format: ![image](https://github.com/elias-adam-gh/Coding-Race-repo/assets/122506412/abd2e8a2-b5e1-4f49-9220-e32ada88a3cd)

one to many, but if there is many to many, we make an intermediate, in this case, one to many movie to actor_movies, and one to many actor to actor movie

AppSettings.json file
------
The "appsettings.json" file in an ASP.NET Core project stores configuration settings for the application. It contains key-value pairs representing various settings:

Connection Strings: Store database connection strings to access databases.

Logging Configuration: Specify logging levels and providers.

Application Settings: Store API keys, feature toggles, or custom configuration.

Third-Party Service Settings: Configuration for external services, like email or payment gateways.

Environment-Specific Settings: Have different versions for different environments (e.g., Development, Staging, Production).


DATABASE
-------------------------
don't need SSMS open during the development process. Visual Studio handles the communication with the database for you, and you interact with the database through code using Entity Framework or other data access libraries.

models: define them to represent your data tables

Visual Studio should have generated a connection string for you. This connection string contains the necessary information to connect to your SQL Server instance. You can find the connection string in the "Web.config" or "App.config" file



Database Configuraiton
--------
1. data connections - add new sql db - server name w ms authorization
2. 




Order of project steps
1.
2.
3. Start of configuring sql server
4. Created MS SQL Server DB on local machine
5. Connected Db to Project through Visual studio
6. configured the connection string to the appsetting.json file
7. configure the app db context in the program (startup) file
8. The main purpose of downloading the Microsoft.EntityFrameworkCore.SqlServer NuGet package for your project is to enable Entity Framework Core to work with Microsoft SQL Server databases.
9. end of sql server configuration
10.




features to consider for the future
-----
1. access to database outside of local machine
   ----
   Host the Database on a Server: Instead of using a local database, consider hosting the SQL Server database on a dedicated server or a cloud-based service like Microsoft Azure SQL Database. This way, your friend can access the application, and the database is accessible from anywhere with the appropriate connection settings.
   
2. learning security configurations
   -----
   --->
   Security Concerns: Allowing external access to your local database can be a significant security risk. It exposes your database to potential attacks and unauthorized access from the internet

   
3. implement MS Azure
