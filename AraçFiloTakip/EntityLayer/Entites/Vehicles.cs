using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLayer.Entites
{
    public class Vehicles
    {
        [Key]
        public int Vehcile_Id { get; set; }
        public string Vehicle_Mark { get; set; }
        public string Vehicle_Model { get; set; }
        public string Vehicle_Age { get; set; }
        public int Vehicle_Miles { get; set; }
        public bool Vehicle_RepairCheck { get; set; }
        public string Vehicle_Drivers { get; set; } 
        public string Vehicle_Licence { get; set; } 
        public string Vehicle_Plate { get; set; } 
        public string Vehicle_Type { get; set; } 
        public string Fuel_Type { get; set; }
        public int Fuel_Consumed { get; set; }

        
    }
}
