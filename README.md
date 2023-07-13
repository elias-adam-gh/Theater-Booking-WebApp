# theSite

Connected Services
  database stuff + openai?

dependencies
  libraries used: mainly asp.net libraries

properties
  json file

wwwroot
  static file with stuff: CSS, js, ect
  
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


  data config
  -----
  ![Screenshot 2023-07-12 011152](https://github.com/elias-adam-gh/theSite-repo/assets/122506412/6990b6c7-2759-4a94-84bc-272fe9088c8d)

---for this file to be the official translator between C# models and the sql code inherit from the base class db context so db context now let us try to import the namespace but to do so we need to install the microsoft.entity framework core

constructor will take a parameter that is going to be the db context options and then in here we passes a parameter the file name and that is thebfdb context so just pass it in here i'm going to name this parameter options and then just pass the options parameter to the base class by using the base keyword and then options

regarding the program.cs file:---
The WebApplication class combines the responsibilities of both the Program.cs and Startup.cs files into a single file, simplifying the project structure With this new hosting model, the configuration and pipeline setup are usually done within the WebApplication object itself, instead of a separate Startup.cs file. The configuration code you provided in the Program.cs file is setting up middleware, routing, and default controllers. So, in the case of your project, you don't have a separate Startup.cs file, and the configuration is done directly within the Program.cs file using the WebApplication object.

sql format: ![image](https://github.com/elias-adam-gh/Coding-Race-repo/assets/122506412/abd2e8a2-b5e1-4f49-9220-e32ada88a3cd)

one to many, but if there is many to many, we make an intermediate, in this case, one to many movie to actor_movies, and one to many actor to actor movie

https://www.youtube.com/watch?v=L7p5Mi4DBMk&list=PL2Q8rFbm-4ruTcZY39MNOsEu4p76HQ5VX&index=23
