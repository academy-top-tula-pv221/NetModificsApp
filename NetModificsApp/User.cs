using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetModificsApp
{
    class User
    {
        string nameFirst;
        string nameLast;

        string address;

        string code;
        public string Address 
        {
            set => address = value;
            get => "Addr: " + address;
        }
        public string Code => code;

        int age;
        public int Age 
        { get => age;
            set
            {
                if (value > 0 && value < 100)
                    age = value;
                else
                    new Exception("Error age");
            }
        }
        public User(string nameFirst, string nameLast)
        {
            this.nameFirst = nameFirst;
            this.nameLast = nameLast;
        }
        public string Name 
        { 
            get { return nameFirst + " " + nameLast; } 
        }
    }

    class Employe
    {
        public Employe(string name)
        {
            Name = name;
        }
        public string Name { get; init; } = "Anonim";
    }
}
