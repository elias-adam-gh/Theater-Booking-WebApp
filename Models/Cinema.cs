using System.ComponentModel.DataAnnotations;
using theSite.Data.Enums;

namespace theSite.Models
{
    public class Cinema
    {
        [Key] public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
    }
}