using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Entites
{
    public class Maintenance
    {
        [Key]
        public int Maintenance_Id { get; set; }
        public DateTime Maintenance_Date { get; set; }
        public string TiresSeanson { get; set; }
        public string ChangeParts { get; set; }

    }
}
