using System.ComponentModel.DataAnnotations.Schema;

namespace SAE.KPP.DataProvider.Models
{
    public class Payment
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public DateTime CreationTime { get; set; }

        public float Sum { get; set; }
        public TimeSpan Period { get;set; }
    }
    
}
