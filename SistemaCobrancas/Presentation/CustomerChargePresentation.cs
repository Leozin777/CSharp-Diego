using System;
using SistemaCobrancas.Services;

namespace SistemaCobrancas.Presentation
{
    public class CustomerChargePresentation
    {
        CustomerService customerService = new CustomerService();
        ChargeService chargeService = new ChargeService();

        public void Menu()
        {
            string op = String.Empty;

            while(op != "0")
            {
                Console.WriteLine("DIGITE 1 PARA ADICIONAR UM NOVO CLIENTE");        
                Console.WriteLine("DIGITE 2 PARA LISTAR TODOS OS CLIENTES");
                Console.WriteLine("DIGITE 0 PARA SAIR DA APLICAÇÃO");

                op = Console.ReadLine();

                switch (op)
                {
                    case "0":
                        Environment.Exit(0);
                    break;

                    case "1":
                        Console.WriteLine("DIGITE O NOME DO CLIENTE:");
                        string name = Console.ReadLine();
                        Console.WriteLine("DIGITE O NÚMERO DE TELEFONE DO CLIENTE");
                        string phoneNumber = Console.ReadLine();

                        var response = customerService.addCustomer(name, phoneNumber);
                        Console.WriteLine(response);
                    break;

                    case "2":
                        Console.WriteLine("LISTA DE CLIENTES");
                        string listCustomer = customerService.ShowCustomers();

                        Console.WriteLine(listCustomer);
                    break;
                    
                    default:

                    break;
                }
            }
        }
    }
}