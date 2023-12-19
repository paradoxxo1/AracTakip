using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Entites
{
    public class Accident
    {
        [Key]
        public int Acciden_Id { get; set; }
        public DateTime Accident_Date { get; set; }
        public string Accident_Reason { get; set; }
        public string Accident_Insurance { get; set; }
        public int Accident_Cost { get; set; }
    }
}
