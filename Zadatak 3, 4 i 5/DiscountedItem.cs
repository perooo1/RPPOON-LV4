using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_3__4_i_5
{
    class DiscountedItem: RentableDecorator
    {
        private readonly double itemDiscountPercent;

        public DiscountedItem(IRentable rentable, double discount) : base(rentable)
        {
            this.itemDiscountPercent = discount;
        }

        public override double CalculatePrice()
        {
            return base.CalculatePrice() - ((this.itemDiscountPercent/100)*base.CalculatePrice());
        }

        public override string Description
        {
            get
            {
                return "Now at "+itemDiscountPercent.ToString()+"% off! " + base.Description;
            }
        }
    }
}
