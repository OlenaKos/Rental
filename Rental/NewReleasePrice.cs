using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rental
{
    class NewReleasePrice : Price
    {
        public override int GetPriceCode()
        {
            return Movie.NEW_RELEASE;
        }

        public override double GetCharge(int daysRented)
        {

            double result = 0;
            result += daysRented * 3;
            return result;
        }

        public override int getFrequentRenterPoints(int daysRented)

        {
            return daysRented > 1 ? 2 : 1;
        }

    }
}
