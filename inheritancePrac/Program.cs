using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritancePrac
{
    class Program
    {
        static void Main(string[] args)
        {
            List<dog> dogs = new List<dog>()
           {
                new dog(),
                new dog(),
                new dog()
            };

            List<cat> cats = new List<cat>()
            {
                new cat(),
                new cat(),
                new cat()
            };

            foreach(var item in dogs)
            {
                item.Eat();
                item.Sleep();
                item.Bark();
            }


            foreach (var item in cats)
            {
                item.Eat();
                item.Sleep();
                item.Meou();
            }


        }
    }
}
