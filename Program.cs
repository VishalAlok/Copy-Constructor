
using System;
namespace copyConstructorExample
{
    class Geeks
    {
        private string month;
        private int year;
        // declaring Copy constructor
        public Geeks(Geeks s)
        {
            month = s.month;
            year = s.year;
        }
        // Instance constructor
        public Geeks(string month, int year)
        {
            this.month = month;
            this.year = year;
        }
        public static void Main()
        {
            Geeks g1 = new Geeks("June", 2018);
            Geeks g2 = new Geeks(g1);
        }
    }
}