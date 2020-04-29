using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_3__4_i_5
{
    class RentingConsolePrinter
    {
        public void PrintTotalPrice(List<IRentable> items)
        {
            Console.WriteLine(items.Sum(r => r.CalculatePrice()));
        }

        public void DisplayItems(List<IRentable> items)
        {
            items.ForEach(r => Console.WriteLine(("Price: " + r.CalculatePrice() + "\t\t" + r.Description)));
        }

    }
}
