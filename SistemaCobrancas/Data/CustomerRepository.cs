using System.Collections.Generic;
using SistemaCobrancas.Domain;

namespace SistemaCobrancas.Data
{
    public class CustomerRepository
    {
        private List<Customer> customerList = new List<Customer>();

        public void Save(Customer customer)
        {
            customerList.Add(customer);
        }

        public Customer GetById(int customerid)
        {
            return customerList.Find(x => x.Id == customerid);
        }

        public bool Update(Customer customer)
        {
            var editCustomer = customerList.Find(x => x.Id == customer.Id);

            if(editCustomer == null)
                return false;
            else
            {
                editCustomer.Name = customer.Name;
                editCustomer.PhoneNumber = customer.PhoneNumber;
                return true;
            }
        }

        public bool Delete(int customerId)
        {
            var customer = customerList.Find(x => x.Id == customerId);

            if(customer == null)
                return false;
            else
            {
                customerList.Remove(customer);
                return true;
            }    
        }

        public List<Customer> GetAll()
        {
            return customerList;
        }

        public int ListSize()
        {
            return customerList.Count;
        }
    }
}