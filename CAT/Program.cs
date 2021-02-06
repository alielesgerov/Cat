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
            Cat cat1 = new Cat("Cat1", 2, 10,350, 100, "Male");
            Cat cat2= new Cat("Cat2", 3, 60, 400, 200, "Female");
            Cat cat3 = new Cat("Cat3", 4, 70, 450, 300, "Male");
            Cat cat4 = new Cat("Cat4", 5, 80, 500, 400, "Female");
            Cat[] cats = new Cat[4] { cat1, cat2, cat3, cat4 };

            cat1.ShowCatInfo();
            cat1.Play();
            cat1.Play();
            //cat1.ShowCatInfo();
            //cat1.Eat();
            //cat1.ShowCatInfo();
            //cat1.Sleep();
            //cat1.ShowCatInfo();

            //for (int i = 0; i < 4; i++)
            //{
            //    cats[i].ShowCatInfo();
            //}

            Cat cat5 = new Cat("Cat5", 6, 90, 550, 10, "Male");
            CatHouse cat_house = new CatHouse("CatHouse 1",cats);
            CatHouse cat_house1 = new CatHouse("CatHouse 2", cats);
            CatHouse[] cat_houses = new CatHouse[] { cat_house, cat_house1 };
            PetShop pet_shop = new PetShop(cat_houses);
            //pet_shop.ShowPetShopInfo();

            //cat_house.AddCat(cat5);
            //cat_house.RemoveByNickanme("Cat2");
            //cat_house.ShowCatHousInfo();


        } 
    }
}
