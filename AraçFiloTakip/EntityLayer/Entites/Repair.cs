using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Entites
{
    public class Repair
    {
        [Key]
        public int  Repair_Id { get; set; }
        public DateTime  Repair_Date { get; set; }
        public string  Repair_Reason { get; set; }
        public string  Repaired_Parts { get; set; }
    }
}
