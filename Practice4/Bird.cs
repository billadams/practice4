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

        public Bird(string id, string name) : base(id, name)
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
                return this.State = "tweeting";
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
                return this.State += " and flying";
            }
        }


    }
}
