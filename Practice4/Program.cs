using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice4
{
    class Program
    {
        private List<Animal> animals = new List<Animal>();

        static void Main(string[] args)
        {
            Lion lion1 = new Lion("1234", "Leo", "moving and roaring");
            Console.WriteLine(lion1.Moving());

            Console.ReadLine();
        }
    }
}
