using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAT
{
    class CatHouse
    {
        public Cat[] Cats { get; set; }
        public int CatCount { get; set; }

        public CatHouse(in Cat[]cats)
        {
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
                if(Cats[i].Nickname==nickname)
                {
                    Cat[] temp = new Cat[--CatCount];

                    if (i > 0)
                        Array.Copy(Cats, 0, temp, 0, i);

                    if (i < Cats.Length - 1)
                        Array.Copy(Cats, i + 1, temp, i, Cats.Length - i - 1);
                    Cats = temp;
                }
            }
        }

        public void ShowCatHousInfo()
        {
            for (int i = 0; i < CatCount; i++)
            {
                Cats[i].ShowCatInfo();
            }
        }
    }
}
