using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoekmonV1
{
    class Puchamon : IPony
    {
        public string PName { get; set; }
        public string PTipo { get; set; }

        public int PLife { get; set; }
        public int PAtk { get; set; }
        public int PDef { get; set; }

        public void Attack()
        { }
        public void Heal()
        { }
        public void Defend()
        { }
        public void Run()
        {

        }

      /*  Puchamon Pony1 = new Puchamon();
        public void DefineP1()
        {
            Pony1.PName = "Bombon";
            Pony1.PLife = 30;
            Pony1.PAtk = 15;
            Pony1.PDef = 15;
        }*/
    }

           
}



    

