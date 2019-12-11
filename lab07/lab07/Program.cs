using System;

namespace LAB07
{
    class program
    {

        static void Main(string[] args)
        {
            book book1 = new book("Moby Dick", " Herman Melville", 1956);
            book1.Display();
            
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

        public void Display()
        {
            Console.WriteLine(
                $"Title: {this.title}\n" +
                $"auther: {this.auther}\n" +
                $"year: {this.year}\n");
        }
    }

}
