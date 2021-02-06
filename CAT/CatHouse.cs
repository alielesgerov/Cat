using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAT
{
    class CatHouse
    {   
        string CatHouse_name { get; set; }
        public Cat[] Cats { get; set; }
        public int CatCount { get; set; }

        public CatHouse(in string catHouse_name ,in Cat[]cats)
        {
            CatHouse_name = catHouse_name;
            Cats = cats;
            CatCount = cats.Length;
        }

        public void AddCat(in Cat cat)
        {   
            Cat[] temp = new Cat[++CatCount];
            if (Cats != null)
                Cats.CopyTo(temp, 0);
            temp[CatCount - 1] = cat;
            Cats = temp;
        }

        public void RemoveByNickanme(in string nickname)
        {
            for(int i = 0; i < Cats.Length; i++)
            {
                if (Cats[i].Nickname == nickname)
                {
                    Cat[] temp = new Cat[--CatCount];

                    if (i > 0)
                        Array.Copy(Cats, 0, temp, 0, i);

                    if (i < Cats.Length - 1)
                        Array.Copy(Cats, i + 1, temp, i, Cats.Length - i - 1);
                    Cats = temp;
                    return;
                }
            }
            Console.WriteLine("A cat with such Nickname couldn't find!");
        }

        public void ShowCatHousInfo()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("=================================================================================");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(CatHouse_name);

            for (int i = 0; i < CatCount; i++)
            {
                Cats[i].ShowCatInfo();
            }
        }

        public double GetAllCatsPrice()
        {
            double price=0;
            for (int i = 0; i < CatCount; i++)
            {
                price+=Cats[i].Price;
            }
            return price;
        }
    }
}
