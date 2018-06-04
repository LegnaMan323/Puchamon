using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoekmonV1
{
    class Pelea_Ponys : Puchamon
    {
        Puchamon pony1;
        Puchamon pony2;

        public void Ponys_define()
        {
            pony1.PAtk = 15;
            pony2.PAtk = 15;

            pony1.PDef = 5;
            pony2.PDef = 5;

            pony2.PLife = 100;
            pony1.PLife = 100;
        }

        public void attack()
        {
            int dañoTotal = pony1.PAtk - pony2.PDef;
            pony2.PLife = dañoTotal;
        }

        public void attack_Enemigo()
        {
            int dañoTotal = pony2.PAtk - pony1.PDef;
            pony1.PLife = dañoTotal;
        }

        public void defenderse()
        {
            pony1.PDef += 5;
        }

        public void defenderse_Enemigo()
        {
            pony2.PDef += 5;
        }

        public void curarse()
        {
            pony1.PLife += 10;
        }

        public void curarse_Enemigo()
        {
            pony2.PLife += 10;
        }
    }
}
