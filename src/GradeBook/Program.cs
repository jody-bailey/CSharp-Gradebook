using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Jody's Grade Book");
            book.AddGrade(92.8);
            book.AddGrade(88.2);
            book.AddGrade(99.6);
            book.AddGrade(76.5);

            book.ShowStatistics();
        }
    }

}
