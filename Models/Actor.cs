using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace theSite.Models
{
    public class Actor
    {
        [Key] public int Id { get; set; } //ID for DB

        public string ProfilePictureURL { get; set; } //string for URL
        public string FullName { get; set; } //attribute to require 1<20 for name
        public string Bio { get; set; } //attribute to limit bio to 0<100

        //Relationships
        public List<Actor_Movie> Actors_Movies { get; set; } //navigation property
    }
}
