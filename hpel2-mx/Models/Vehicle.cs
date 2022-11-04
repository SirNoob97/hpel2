using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace hpel2_mx.Models
{
    public class Vehicle
    {
        [Key]
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Vin { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }

        public int OwnerID { get; set; }
        public Owner Owner { get; set; }

    }
}
