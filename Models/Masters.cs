using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using theSite.Data;

namespace theSite.Models
{
    public class Masters
    {
        [Key] public int Id { get; set; }

        public string logo { get; set; }
        [StringLength(20, MinimumLength = 1)] public string name { get; set; }
        [StringLength(100, MinimumLength = 0)] public string bio { get; set; }
        public CreatorPlatform platform { get; set; } //used enum (static list) file from 'Data' folder
    }
}
