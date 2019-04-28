using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Employee employee = new Employee();
            Client client = new Client();
            Product product = new Product();
            Order order = new Order();
            var id = person.GetNum();





            do
            {
                Console.WriteLine("Seçim edin: \nI - işçi yaratmaq \nM - müşteri yaratmaq \nP - mehsul yaratmaq \nO - sifariş yaratmaq");
                char input = Console.ReadKey().KeyChar;
                if ( input != 'I' && input != 'M' && input != 'O' && input != 'P')
                {
                    Console.WriteLine("Zehmet olmasa düzgün herf seçin");
                }
                switch (input)
                {
                    case 'i':
                    case 'I':
                        Console.WriteLine();
                        Console.WriteLine("Please enter your name:");
                        employee.Name = Console.ReadLine();
                        Console.WriteLine("Please enter your surname:");
                        employee.Surname = Console.ReadLine();
                        Console.WriteLine("Please enter your birthday:");
                        employee.Birthday = Console.ReadLine();
                        Console.WriteLine("Please enter your card ID:");
                        employee.Card_ID = Console.ReadLine();
                        Console.WriteLine("Please enter your position:");
                        employee.Position = Console.ReadLine();
                        Console.WriteLine("Please enter your salary:");
                        employee.Salary = Console.ReadLine();
                        Console.WriteLine("Işçi yaradıldı." + id + "-" + employee.Name + " " + employee.Surname + " " + employee.Birthday);
                        break;
                    case 'm':
                    case 'M':
                        Console.WriteLine();
                        Console.WriteLine("Please enter your name:");
                        client.Name = Console.ReadLine();
                        Console.WriteLine("Please enter your surname:");
                        client.Surname = Console.ReadLine();
                        Console.WriteLine("Please enter your birthday:");
                        client.Birthday = Console.ReadLine();
                        Console.WriteLine("Please enter your card ID:");
                        client.Card_ID = Console.ReadLine();
                        Console.WriteLine("Please enter your client ID:");
                        client.Client_ID = Console.ReadLine();
                        Console.WriteLine("Please enter your address:");
                        client.Address = Console.ReadLine();
                        Console.WriteLine("Please enter your phone:");
                        client.Phone = Console.ReadLine();
                        Console.WriteLine("Isci yaradildi." + id + "-" + client.Name + " " + client.Surname);
                        break;
                    case 'p':
                    case 'P':
                        Console.WriteLine();
                        Console.WriteLine("Please enter product name:");
                        product.Name = Console.ReadLine();
                        Console.WriteLine("Please enter product color:");
                        product.Color = Console.ReadLine();
                        Console.WriteLine("Please enter product price:");
                        product.Price = Console.ReadLine();
                        Console.WriteLine("Mehsul yaradıldı." + id + "-" + product.Name + " " + product.Color + " " + product.Price + "AZN");
                        break;
                    case 'o':
                    case 'O':
                        Console.WriteLine();
                        Console.WriteLine("Please enter your count:");
                        order.Count = Console.ReadLine();
                        Console.WriteLine("Sifariş yaradıldı:\r\n" + id + "-" + product.Name + client.Name + "terefinden sifariş olundu.\r\n" + "Sayı:" + order.Count + " " + "Cemi mebleğ:" + Convert.ToInt32(product.Price) * Convert.ToInt32(order.Count) + "AZN" + "\r\nSifarişinizi qebul eden işçi:" + " " + employee.Name + " " + employee.Surname + " " + employee.Position);
                        break;

                }
            } while (true);
        }
    }

}