using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using theSite.Data.Enums;

namespace theSite.Models
{
    public class Producer
    {
        [Key] public int Id { get; set; }

        public string ProfilePictureURL { get; set; }
        [StringLength(50, MinimumLength = 2)] public string FullName { get; set; }
        [StringLength(100, MinimumLength = 0)] public string Bio { get; set; }

        //Relationships
        public List<Movie> Movies { get; set; } //navigation property
    }
}
