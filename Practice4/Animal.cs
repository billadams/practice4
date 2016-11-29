using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice4
{
    public abstract class Animal
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string State { get; set; }

        public Animal()
        {

        }

        public Animal(string id, string name)
        {
            this.ID = id;
            this.Name = name;
        }

        public void Eat()
        {
            this.State = "eating";
        }

        public void Sleep()
        {
            this.State = "sleeping";
        }

        public abstract string Communicate();

        public abstract string Moving();

        public override string ToString()
        {
            return this.Name + " ID: " + this.ID + " is " + this.State + ".";
        }
    }
}
