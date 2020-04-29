using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_3__4_i_5
{
    class Video : IRentable
    {
        private readonly double BaseVideoPrice = 9.99;
        public string Name { get; private set; }

        public Video(string name)
        {
            this.Name = name;
        }
        
        public string Description { get { return this.Name; } }

        public double CalculatePrice()
        {
            return BaseVideoPrice;
        }
    }
}
