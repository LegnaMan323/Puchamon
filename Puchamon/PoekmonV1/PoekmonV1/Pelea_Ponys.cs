using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoekmonV1
{
    class Pelea_Ponys : Puchamon
    {
        Puchamon pony1 = new Puchamon();
        Puchamon pony2 = new Puchamon();

        public void Pony2()
        {
            pony2.PAtk = 15;
            pony2.PName = "Burbuja";
            pony2.PDef = 5;
            pony2.PLife = 100;
            pony2.PTipo = "pegaso";

        }
        public void Pony1()
        {
            pony1.PAtk = 15;
            pony1.PName = "Vellito";
            pony1.PDef = 5;
            pony1.PLife = 100;
            pony1.PTipo = "unicornio";
        }

        public string P1name()
        {
            return pony1.PName;  
        }
        public string P2name()
        {
            return pony2.PName;
        }

        public void attack()
        {
            int dañoTotal = pony1.PAtk - pony2.PDef;
            pony2.PLife -= dañoTotal;
          
            if (pony1.PTipo == "unicornio")
            {
                dañoTotal = dañoTotal + 5;
                pony2.PLife -= dañoTotal;
            }
            
        }

        public void attack_Enemigo()
        {
            int dañoTotal = pony2.PAtk  - pony1.PDef;
            pony1.PLife -= dañoTotal;
            
        }

        public void defenderse()
        {
            pony1.PDef += 5;
        }

        public void defenderse_Enemigo()
        {
            pony2.PDef += 5;
        }

        public int vidaPony()
        {
            if (pony1.PLife < 0)
            {
                pony1.PLife = 0;
            }
            return pony1.PLife;
        }
        public int vidaPony_Enemigo()
        {
            if (pony2.PLife < 0)
            {
                pony2.PLife = 0;
            }
            return pony2.PLife;
        }
        public void curarse()
        {
           
            pony1.PLife += 10;

        }

        public void curarse_Enemigo()
        {
            if (pony2.PTipo == "pegaso")
            {
                pony2.PLife += 25;
            }
            pony2.PLife += 10;
        }
    }
}
