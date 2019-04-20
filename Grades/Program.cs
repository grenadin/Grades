using System;


namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            
            GradeBook book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(35);
            book.AddGrade(41);

            GradeStatistics stats = book.ComputeStatistics();

            Console.WriteLine($"Show Highest Grade {stats.HighestGrade}");
            Console.WriteLine($"Show Lowest Grade {stats.LowestGrade}");
            Console.WriteLine($"Show Average Grade {stats.AverageGrade}");


        }
    }
}
