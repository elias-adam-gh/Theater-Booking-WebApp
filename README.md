# theSite

Connected Services
  database stuff + openai?

dependencies
  libraries used: mainly asp.net libraries

properties
  json file

wwwroot
  static file with stuff: CSS, js, ect

models
  properties of object (in this case the pic name and grade for a student)
    ""[Key] 
        public int Id { get; set; } ""
    By applying [Key] to a property, you ensure it is treated as the primary key when creating the database table, generating      queries, and establishing relationships between entities. a query is a request for specific information from a database. 

  [Required] = namespace to mark a property as required.

  [StringLength]: Specifies the maximum and minimum length constraints for a string property.
  [Range]: Specifies the numeric range constraints for a numeric property.
  [RegularExpression]: Validates that a string property matches a specified regular expression pattern.
  [EmailAddress]: Ensures that a string property has a valid email address format.
  [Compare]: Compares the value of a property with another property in the same model.
