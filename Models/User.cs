

namespace SAE.KPP.DataProvider.Models
{
    public class User
    {
        public int Id { get; set; }

        public string AccountNumber { get; set; }
        public string Name { get; set; }

        public ICollection<Payment> Payments{ get; set; }
      
    }
    
}
