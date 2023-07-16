# theSite

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










Order of project steps
1.
2.
3.
4.
5.
6.
7.
8.
9.
10.




https://www.youtube.com/watch?v=L7p5Mi4DBMk&list=PL2Q8rFbm-4ruTcZY39MNOsEu4p76HQ5VX&index=23
