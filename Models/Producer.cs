using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using theSite.Data.Enums;

namespace theSite.Models
{
    public class Producer
    {
        [Key] public int Id { get; set; }

        public string ProfilePictureURL { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }

        //Relationships
        public List<Movie> Movies { get; set; } //navigation property
    }
}
