using System.ComponentModel.DataAnnotations;

namespace theSite.Models
{
    public class Student
    {
        [Key] public int Id { get; set; } //ID for DB
        
        public string profilePictureURL { get; set; } //string for URL
        [StringLength(20, MinimumLength = 1)] public string fullName { get; set; } //attribute to require 1<20 for name
        [StringLength(100, MinimumLength = 0)] public string bio { get; set; } //attribute to limit bio to 0<100
        [EmailAddress] public string email { get; set; } //attribute type email for DB
    }
}