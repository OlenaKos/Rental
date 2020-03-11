using System;

namespace Rental
{
    /// <summary>
    /// Класс, представляющий данные о прокате фильма.
    /// </summary>
    class Rental
    {
        // Поля

        private Movie movie = null;
        private int daysRented = 0;

        // Методы

        public Rental(Movie movie, int daysRented)
        {
            this.movie = movie;
            this.daysRented = daysRented;
        }

        // Свойства

        public Movie Movie
        {
            get { return this.movie; }
        }

        public int DaysRented
        {
            get { return this.daysRented; }
        }
    }
}
