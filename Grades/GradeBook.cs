using System;
using System.Collections.Generic;
using System.Text;


//This Gradebook hold only the member of grade information
namespace Grades
{
    public class GradeBook
    {
        List<float> grades;


        public GradeBook()
        {
            grades = new List<float>();
        }

        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        public GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats = new GradeStatistics(); //This code is for allocate memory but Dependency.
            
          
            float sum = 0;
            foreach (float grade in grades)
            {
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                sum += grade;
            }
            stats.AverageGrade = sum / grades.Count;

            return stats;
        }
    }
}
