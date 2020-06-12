using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritancePrac
{
    class cat:animal
    {
        public int Age{get;set;}
    public cat()
    {
        this.Age = 0;
    }
   
    public void Meou()
    {
        Console.WriteLine("미야오");
    }
}
}
