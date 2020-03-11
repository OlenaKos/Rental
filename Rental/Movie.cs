using System;

namespace Rental
{
    /// <summary>
    /// Класс, который предоставляет данные о фильме.
    /// </summary>
    class Movie
    {
        // Поля
        
        public const int REGULAR = 0;
        public const int NEW_RELEASE = 1;
        public const int CHILDRENS = 2;


        Price price = null;
        private string title = null;
        private int priceCode = 0;

        // Методы

        public Movie(string title, int priceCode)
        {
            this.title = title;
            PriceCode = priceCode;
        }

        // Свойства

        public int PriceCode
        {
            get { return this.price.GetPriceCode(); }
            set
            {
                switch (value)
                {
                    case REGULAR:
                        {
                            price = new RegularPrice();
                            break;
                        }
                    case CHILDRENS:
                        {
                            price = new ChildrensPrice();
                            break;
                        }
                    case NEW_RELEASE:
                        {
                            price = new NewReleasePrice();
                            break;
                        }
                    default:
                        throw new ArgumentException();
                }
            }
        }

        public string Title
        {
            get { return this.title; }
        }

        public double GetCharge(int daysRented)
        {
            return price.GetCharge(daysRented);
        }

        public int getFrequentRenterPoints(int daysRented)
        {
            return price.getFrequentRenterPoints(daysRented);
        }
    }
}
