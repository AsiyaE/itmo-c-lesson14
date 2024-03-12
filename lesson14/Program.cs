using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson14
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat1 = new Cat("Китти");
            Console.WriteLine(cat1.Say());
            Console.WriteLine(cat1.ShowInfo());

            Dog dog1 = new Dog("Шарик");
            Console.WriteLine(dog1.Say());
            Console.WriteLine(dog1.ShowInfo());
            Console.ReadKey();
        }
    }
}
