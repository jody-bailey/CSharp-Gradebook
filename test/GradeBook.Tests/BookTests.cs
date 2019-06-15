using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void BookCalculatesStats()
        {
            // arrange
            var book = new Book("");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);

            // act
            var results = book.CalcStats();

            // assert
            Assert.Equal(85.6, results.average, 1);
            Assert.Equal(90.5, results.high, 1);
            Assert.Equal(77.3, results.low, 1);
        }

        [Fact]
        public void GradesAddCorrectly() {
            var grade = 105.3;
            var book = new Book("");
            book.AddGrade(grade);
            
            foreach(double num in book.GetGrades()) {
                Assert.InRange(num, 0, 100);
            }
        }
    }
}
