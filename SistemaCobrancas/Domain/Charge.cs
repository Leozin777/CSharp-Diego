using System;

namespace SistemaCobrancas.Domain
{
    public class Charge
    {
        public Charge(int id, DateTime dueDate, double amountCharge, Customer customer)
        {
            this.Id = id;
            this.IssuanceDate = DateTime.Now;
            this.DueDate = dueDate;
            this.AmountCharge = amountCharge;
            this.PaymentDate = null;
            this.Status = false;
            this.Customer = customer;
        }

        public int Id { get; set; }
        public DateTime IssuanceDate { get; set; }
        public DateTime DueDate { get; set; }
        public double AmountCharge { get; set; }
        public DateTime? PaymentDate { get; set; }
        public bool Status { get; set; }
        public Customer Customer { get; private set; }
    }
}