using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson14
{
    class Cat : Animal
    {
        string name;
        public override string Name
        {
            get => name;
            set => name = value;
        }

        public Cat (string name):base(name){}
        public override string Say()
        {
            return "Мяу";
        }
    }
}
