using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        private List<double> grades;
        public string Name;

        public Book(string name) {
            this.Name = name;
            this.grades = new List<double>();
        }
        public void AddGrade(double grade) {
            if(grade >= 0 && grade <= 100) {
                grades.Add(grade);
            } else {
                Console.WriteLine("Inavlid grade...");
            }
        }

        public List<double> GetGrades() {
            return this.grades;
        }

        public void ShowStatistics() {
            var results = CalcStats();
            Console.WriteLine($"The average grade is {results.average:N1}");
            Console.WriteLine($"The highest grade is {results.high:N1}");
            Console.WriteLine($"The lowest grade is {results.low:N1}");
        }

        public Stats CalcStats() {
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;
            var result = 0.0;
            
            foreach(double number in this.grades) {
                highGrade = Math.Max(number, highGrade);
                lowGrade = Math.Min(number, highGrade);
                result += number;
            }

            var average = result / this.grades.Count;

            return new Stats(average, highGrade, lowGrade);
        }
    }
}