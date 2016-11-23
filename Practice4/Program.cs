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
            Lion lion1 = new Lion("1234", "Leo", "moving and roaring");
            //Animal animal1 = new Animal("5678", "Polly", "talking and pooping");

            //Animal a;
            //a = lion1;

            Console.WriteLine(lion1.Moving());
            //Console.WriteLine(animal1.Moving());

            Console.ReadLine();
        }
    }
}
