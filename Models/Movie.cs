using System.ComponentModel.DataAnnotations;

namespace theSite.Models
{
    public class Student
    {
        [Key] public int Id { get; set; }
        
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageURL { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MovieCategory Title { get; set; }
    }
}