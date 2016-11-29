using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice4
{
    public class Lion : Animal
    {
        public Lion(string id, string name) : base(id, name)
        {

        }

        public override string Communicate()
        {
            if (this.State == "sleeping" || this.State == "eating")
            {
                return "";
            }
            else
            {
                return this.State = "roaring";
            }
        }

        public override string Moving()
        {
            if (this.State == "sleeping" || this.State == "eating")
            {
                return "";
            }
            else
            {
                return this.State += " and moving";
            }
        }
    }
}
