using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace theSite.Models
{
    public class Course
    {
        [Key] public int Id { get; set; }

        public string profilePictureURL { get; set; }
        [StringLength(50, MinimumLength = 2)] public string name { get; set; }
        [StringLength(100, MinimumLength = 0)] public string description { get; set; }
        public string courseURL { get; set; }
    }
}
