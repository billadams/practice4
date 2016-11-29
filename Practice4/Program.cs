using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();

            Animal lion1 = new Lion("1234", "Nala");
            Animal lion2 = new Lion("5678", "Simba");
            Animal lion3 = new Lion("7654", "Mufasa");

            Animal bird1 = new Bird("3333", "Big Bird");
            Animal bird2 = new Bird("8888", "Woodstock");

            lion1.Eat();
            lion2.Sleep();

            bird2.Eat();

            animals.Add(lion1);
            animals.Add(lion2);
            animals.Add(lion3);
            animals.Add(bird1);
            animals.Add(bird2);

            foreach (Animal a in animals)
            {
                a.Communicate();
                a.Moving();
                Console.WriteLine(a.ToString());
            }

            Console.ReadLine();
        }
    }
}
