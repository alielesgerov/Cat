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
            Cat cat1 = new Cat("Cat1", 2, 50,350,10,"Male");
            Cat cat2= new Cat("Cat2", 3, 60, 400, 10, "Female");
            Cat cat3 = new Cat("Cat3", 4, 70, 450, 10, "Male");
            Cat cat4 = new Cat("Cat4", 5, 80, 500, 10, "Female");
            Cat[] cats = new Cat[4] { cat1, cat2, cat3, cat4 };
            //for (int i = 0; i < 4; i++)
            //{
            //    cats[i].ShowCatInfo();
            //}
            Cat cat5 = new Cat("Cat5", 6, 90, 550, 10, "Male");
            CatHouse cat_house = new CatHouse(cats);
            cat_house.AddCat(cat5);
            cat_house.RemoveByNickanme("Cat2");
            cat_house.ShowCatHousInfo();


        } 
    }
}
