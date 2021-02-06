using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAT
{
    class PetShop
    {
        CatHouse[] CatHouses { set; get; }
        int Cathouse_count { set; get; }

        public PetShop(CatHouse[] catHouses)
        {
            CatHouses = catHouses;
            Cathouse_count = catHouses.Length;
        }
        
        public void ShowPetShopInfo()
        {
            for (int i = 0; i < Cathouse_count; i++)
            {
                CatHouses[i].ShowCatHousInfo();
            }
        }
    }
}
