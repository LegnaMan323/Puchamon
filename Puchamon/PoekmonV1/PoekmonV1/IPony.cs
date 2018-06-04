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

        int PLife { get; set; }
        int PAtk { get; set; }
        int PDef { get; set; }

    }
}
