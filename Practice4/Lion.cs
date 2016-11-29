using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice4
{
    public class Lion : Animal
    {
        public Lion()
        {

        }

        public Lion(string id, string name) : base(id, name)
        {

        }

        public override string Communicate()
        {
            if (IsEatingOrSleeping())
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
            if (IsEatingOrSleeping())
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
