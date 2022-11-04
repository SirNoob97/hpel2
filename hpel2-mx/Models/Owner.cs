using System.ComponentModel.DataAnnotations;

namespace hpel2_mx.Models
{
    public class Owner
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DriverLicense { get; set; }
    }
}
