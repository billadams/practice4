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

        public Animal()
        {

        }

        public Animal(string id, string name)
        {
            this.id = id;
            this.name = name;
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

        public abstract string Communicate();
        //{
        //    return name;
        //}

        public abstract string Moving();
        //{
        //    return "I am a zoo animal that moves and stuff";
        //}

        public virtual string GetAnimalStatus()
        {
            return name + " ID: " + ID;
        }
    }
}
