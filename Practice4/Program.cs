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

            //Lion lion1 = new Lion("1234", "Nala", "moving an roaring");
            //Lion lion2 = new Lion("5678", "Simba", "sleeping");
            //Lion lion3 = new Lion("7654", "Mufasa", "eating");

            Bird bird1 = new Bird("3333", "Big", "awake");
            Bird bird2 = new Bird("8888", "Woodstock", "sleeping");

            //animals.Add(lion1);
            //animals.Add(lion2);
            //animals.Add(lion3);
            animals.Add(bird1);
            animals.Add(bird2);

            foreach (Animal a in animals)
            {
                Console.WriteLine(a.Communicate());
                Console.WriteLine(a.Moving());
                Console.WriteLine(a.GetAnimalStatus());
            }

            //Animal animal1 = new Animal("5678", "Polly", "talking and pooping");

            //Animal a;
            //a = lion1;

            //Console.WriteLine(lion1.Moving());
            //Console.WriteLine(animal1.Moving());

            Console.ReadLine();
        }
    }
}
