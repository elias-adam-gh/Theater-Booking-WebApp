using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace theSite.Models
{
    public class Actor
    {
        [Key] public int Id { get; set; } //ID for DB

        public string ProfilePictureURL { get; set; } //string for URL
        [StringLength(50, MinimumLength = 2)] public string FullName { get; set; } //attribute to require 1<20 for name
        [StringLength(100, MinimumLength = 0)] public string Bio { get; set; } //attribute to limit bio to 0<100
    }
}
