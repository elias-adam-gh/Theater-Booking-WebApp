using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using theSite.Data.Enums;
using System.Collections.Generic;

namespace theSite.Models
{
    public class Movie
    {
        [Key] public int Id { get; set; }
        
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageURL { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MovieCategory Title { get; set; }

        //Relationships
        public List<Actor_Movie> Actors_Movies { get; set;} //navigation property
        public Producer Producer { get; set; }
        public int ProducerId { get; set; }
        public Cinema Cinema { get; set; }
        public int CinemaId { get; set; }
    }
}