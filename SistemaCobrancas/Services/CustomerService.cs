using System.Text;
using SistemaCobrancas.Data;
using SistemaCobrancas.Domain;

namespace SistemaCobrancas.Services
{
    public class CustomerService
    {
        CustomerRepository customerRepository = new CustomerRepository();

        public string addCustomer(string name, string phoneNumber)
        {
            var customerId = customerRepository.ListSize() + 1;
            customerRepository.Save(new Customer(customerId, name, phoneNumber));
            return "Cliente adicionado com sucesso";
        }

        public string ShowCustomers()
        {
            var builder = new StringBuilder();
            var customerList = customerRepository.GetAll();
            var numberOfCustomers = customerList.Count;

            if(numberOfCustomers == 0)
                builder.Append("Lista vazia!");
            else
            {
                foreach (Customer customer in customerList)
                {
                    builder.AppendLine("Id: " + customer.Id + " Nome: " + customer.Name + " Telefone" + customer.PhoneNumber);
                }
            }   

            return builder.ToString(); 
        }
    }
}