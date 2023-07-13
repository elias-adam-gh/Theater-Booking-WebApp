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

https://www.youtube.com/watch?v=L7p5Mi4DBMk&list=PL2Q8rFbm-4ruTcZY39MNOsEu4p76HQ5VX&index=23
