using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson14
{
    class Dog : Animal
    {
        string name;
        public override string Name
        {
            get => name;
            set => name = value;
        }
        public Dog(string name) : base(name) { }
        public override string Say()
        {
            return "Гав";
        }
    }
}
