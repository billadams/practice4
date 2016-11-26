using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice4
{
    public class Bird : Animal
    {
        public Bird()
        {

        }

        public Bird(string id, string name, string state) : base(id, name, state)
        {

        }

        public override string Communicate()
        {
            return Name + " ID: " + ID + " is " + State + ".";
        }

        public override string Moving()
        {
            return Name + " ID: " + ID + " is " + State + ".";

            //return base.Moving();
        }
    }
}
