using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice4
{
    public class Bird : Animal
    {
        public string State { get; set; }

        public Bird()
        {

        }

        public Bird(string id, string name, string state) : base(id, name)
        {
            this.State = state;
        }

        public override string Communicate()
        {
            if (isAwake())
            {
                return "tweeting";
            }
            else
            {
                return "";
            }
            //return Name + " ID: " + ID + " is " + this.State + ".";
        }

        public override string Moving()
        {
            if (isAwake())
            {
                return "moving";
            }
            else
            {
                return "";
            }
            //return Name + " ID: " + ID + " is " + this.State + ".";
        }

        public bool isAwake()
        {
            if (this.State != "sleeping" || this.State != "eating")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string GetAnimalStatus()
        {
            return base.GetAnimalStatus() + " is flying and tweeting.";
        }
    }
}
