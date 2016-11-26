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
            throw new NotImplementedException();
        }

        public override string Moving()
        {
            throw new NotImplementedException();
        }
    }
}
