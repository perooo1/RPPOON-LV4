using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_3__4_i_5
{
    class Program
    {
        static void Main(string[] args)
        {

            ////////////////////////////// Zadatak 3
            /*
            List<IRentable> rentables = new List<IRentable>();
            rentables.Add(new Book("A Song if Ice and Fire"));
            rentables.Add(new Video("Pulp fiction"));

            RentingConsolePrinter printer = new RentingConsolePrinter();
            printer.DisplayItems(rentables);
            Console.WriteLine("\nTotal price:");
            printer.PrintTotalPrice(rentables);
            */

            ////////////////////////////// Zadatak 4
            /*
            List<IRentable> rentables = new List<IRentable>();
            rentables.Add(new Book("A Song if Ice and Fire by G.R.R. Martin"));
            rentables.Add(new Video("Pulp fiction"));
            rentables.Add(new HotItem(new Book("Lord of the rings: Fellowship of the Ring by J.R.R Tolkien")));
            rentables.Add(new HotItem(new Video("Harry Potter and Order of Phoenix")));

            RentingConsolePrinter printer = new RentingConsolePrinter();
            printer.DisplayItems(rentables);
            Console.WriteLine("\nTotal price:");
            printer.PrintTotalPrice(rentables);
            */

            ////////////////////////////// Zadatak 5
            
            List<IRentable> flashSale = new List<IRentable>();
            flashSale.Add(new DiscountedItem(new Book("A Song if Ice and Fire by G.R.R. Martin"),25));
            flashSale.Add(new DiscountedItem(new Video("Pulp Fiction"),30));
            flashSale.Add(new DiscountedItem(new Book("Lord of the Rings: Fellowship of the Ring by J.R.R Tolkien"),30));
            flashSale.Add(new DiscountedItem(new Video("Harry Potter and Order of Phoenix"),35));

            RentingConsolePrinter printer = new RentingConsolePrinter();
            printer.DisplayItems(flashSale);
            Console.WriteLine("\nTotal price:");
            printer.PrintTotalPrice(flashSale);
            
        }
    }
}
