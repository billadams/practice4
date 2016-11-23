using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice4
{
    public abstract class Animal
    {
        private string id;
        private string name;
        private string state;

        public Animal()
        {

        }

        public Animal(string id, string name, string state)
        {
            this.id = id;
            this.name = name;
            this.state = state;
        }

        public string ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string State
        {
            get
            {
                return state;
            }
            set
            {
                state = value;
            }
        }

        public abstract string Communicate();
        //{
        //    return name;
        //}

        public abstract string Moving();
        //{
        //    return "I am a zoo animal that moves and stuff";
        //}
    }
}
