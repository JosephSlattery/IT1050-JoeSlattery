using System;

namespace LAB07
{
    class program
    {

        static void Main(string[] args)
        {
            book book1 = new book("Moby Dick", " Herman Melville", 1956);


        }
    }
    class book
    {
        public string title;
        public string auther;
        public int year;

        public book(string title, string auther, int year)
        {
            this.title = title;
            this.auther = auther;
            this.year = year;
        }

        void display()
        {
            Console.WriteLine(
                $"Title: {this.title}\n" +
                $"auther: {this.auther}\n" +
                $"year: {this.year}\n:");
        }
    }

}