using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_3__4_i_5
{
    class Book : IRentable
    {
        private string Title { get; set; }
        private readonly double BaseBookPrice = 3.99;

        public Book(string title)
        {
            this.Title = title;
        }
        
        public string Description { get { return this.Title; } }

        public double CalculatePrice()
        {
            return BaseBookPrice;
        }
    }
}
