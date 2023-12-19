using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLayer.Entites
{
    public class Drivers
    {
        [Key]
        public int Drivers_Id { get; set; }
        public string Drivers_Name { get; set; }
        public string Drivers_Surname { get; set; }
        public int Drivers_Age { get; set; }
        public string Driver_sex { get; set; }
        public string Drivers_LicenceType { get; set; }
        public DateTime BeginningTime { get; set; }


        [ForeignKey("Vehicles")]
        public virtual List<Vehicle_Licence>? Vehicle_Licences { get; set; }
    }
}
