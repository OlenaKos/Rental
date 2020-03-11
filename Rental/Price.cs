using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rental
{
    abstract class Price
    {
        public abstract int GetPriceCode();

        public abstract double GetCharge(int daysRented);

        public virtual int getFrequentRenterPoints(int daysRented)
        {

           return 1;
        }

    }
}
