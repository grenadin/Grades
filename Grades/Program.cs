using System;


namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;
            
            g1.Name = "Harirak";
            Console.WriteLine($" g2 = {g2.Name}");
            g2.Name = "toon";
            g1 = new GradeBook();
            Console.WriteLine($" g1 = {g1.Name}");
           
            

            //GradeBook book = new GradeBook();
            //book.AddGrade(91);
            //book.AddGrade(89.5f);
            //book.AddGrade(35);
            //book.AddGrade(41);

            //GradeStatistics stats = book.ComputeStatistics();

            //Console.WriteLine($"Show Highest Grade {stats.HighestGrade}");
            //Console.WriteLine($"Show Lowest Grade {stats.LowestGrade}");
            //Console.WriteLine($"Show Average Grade {stats.AverageGrade}");
            //Console.ReadLine();
            


        }
    }
}
