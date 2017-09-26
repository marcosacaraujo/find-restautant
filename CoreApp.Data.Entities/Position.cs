using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreApp.Data.Entities
{
    public class Position
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public double Lat { get; set; }
        public double Lon { get; set; }
        
        public virtual Restaurant Restaurant { get; set; }
    }
}