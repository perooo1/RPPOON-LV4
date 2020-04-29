using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_3__4_i_5
{
    class RentableDecorator : IRentable
    {
        private IRentable rentable;

        public RentableDecorator(IRentable rentable)
        {
            this.rentable = rentable;
        }


        public virtual string Description
        {
            get
            {
                return rentable.Description;
            }
        }

        public virtual double CalculatePrice()
        {
            return rentable.CalculatePrice();
        }
    }
}
