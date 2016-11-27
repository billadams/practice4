using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice4
{
    public class Lion : Animal
    {
        public string State { get; set; }

        public Lion(string id, string name, string state) : base(id, name)
        {
            this.State = state;
        }

        public override string Communicate()
        {
            return Name + " ID: " + ID + " is " + this.State + "." ;
        }

        public override string Moving()
        {
            return Name + " ID: " + ID + " is " + this.State + ".";

            //return base.Moving();
        }
    }
}
