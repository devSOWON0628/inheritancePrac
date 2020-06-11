using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritancePrac
{
    class dog
    {
        public int Age { get; set; }
        public string Color { get; set; }
        public dog()
        {
            this.Age = 0;
            this.Color = "갈색";
        }
        public void Eat()
        {
            Console.WriteLine("냠냠");
        }

        public void Sleep()
        {
            Console.WriteLine("드르렁");

        }
        public void Bark()
        {
            Console.WriteLine("멍멍");

        }
    }
}
