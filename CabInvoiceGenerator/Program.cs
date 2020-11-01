using System;

namespace CabInvoiceGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Cab Invoice Generator");
            InvoiceGenerator invoice = new InvoiceGenerator();
            Console.WriteLine(invoice.CalculateFare(2.0,5));
        }
    }
}
