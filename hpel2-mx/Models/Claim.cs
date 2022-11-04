using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace hpel2_mx.Models
{
    public class Claim
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public DateTime Date { get; set; }

        public int VehicleID { get; set; }
        public Vehicle Vehicle { get; set; }
    }
}
