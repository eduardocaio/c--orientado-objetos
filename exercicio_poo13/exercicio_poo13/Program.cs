using exercicio_poo13.Entities;
using exercicio_poo13.Entities.Enums;
using System.Globalization;

namespace exercicio_poo13
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DateTime dateNow = DateTime.Now;

            Console.WriteLine("Enter client data:");

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime dateBirth = DateTime.Parse(Console.ReadLine());

            Client client = new Client(name, email, dateBirth);

            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");

            OrderStatus orderStatus = Enum.Parse<OrderStatus>(Console.ReadLine());

            Order order = new Order(dateNow, orderStatus, client);

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");

                Console.Write("Product name: ");
                string productName = Console.ReadLine();

                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());   

                Product product = new Product(productName, productPrice);

                OrderItem item = new OrderItem(quantity, productPrice, product);

                order.AddItem(item);
            }

            Console.WriteLine();

            Console.WriteLine(order);

        }
    }
}