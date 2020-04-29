using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_3__4_i_5
{
    interface IRentable
    {
        string Description { get;  }
        double CalculatePrice();
    }
}
