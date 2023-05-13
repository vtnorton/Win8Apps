using SunCore.Methods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Começou");
            Create newEmployee = new Create();
            for (int i = 0; i < 1001; i++)
            {
                Random x = new Random();
                string y = x.Next(0, 90).ToString();
                newEmployee.NewEmployee(1, y, y, y, y, y, y, y, y, y, y, y, y, y, y, y, y, y, y, y, y, y, y, y, y, y, y, y, y, y, y, y, x.Next(0, 2));

                Console.WriteLine("Adicionado funcionário de número: " + i + ", adicionado: " + y);
                Thread.Sleep(3000);
            }
            Console.ReadLine();
        }
    }
}
