using System.Collections.Generic;

namespace SistemaCobrancas.Domain
{
    public class Customer
    {
        public Customer(int id, string name, string phoneNumber)
        {
            this.Id = id;
            this.Name = name;
            this.PhoneNumber = phoneNumber;
            this.Charges = new List<Charge>();
        }
        public int Id { get; set; } 
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public List<Charge> Charges { get; set; }
    }
}