using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritancePrac
{
    class dog:animal
    {
        public int Age { get; set; }
        public string Color { get; set; }
        public dog()
        {
            this.Age = 0;
            this.Color = "갈색";
        }
       
        public void Bark()
        {
            Console.WriteLine("멍멍");

        }
    }
}
