using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoekmonV1
{
    interface IPony
    {
        string PName { get; set; }
        string PTipo { get; set; }

        public int pLife { get; set; }
        public int pAtk { get; set; }
        public int pDef { get; set; }

        void Attack();
        void Heal();
        void Defend();
        void run();
    }
}
