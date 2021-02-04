using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAT
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Some cat nickname", 2, 50,350,10,"Male");
            cat.ShowCatInfo();
        } 
    }
}
