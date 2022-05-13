using System;
using SistemaCobrancas.Presentation;

namespace SistemaCobrancas
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerChargePresentation presentation = new CustomerChargePresentation();

            presentation.Menu();
        }
    }
}
