using System;
using System.Collections.Generic;


//This Gradebook hold only the member of grade information
namespace Grades
{
    public class GradeBook
    {

         List<float> grades;
        public float Countg;



        public GradeBook()
        {
            name = "Empty";//
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
        public void testFunc()
        {

        }

        public event NameChangedDelegate NameChanged;
        

        private string name;
        public string Name
        {
            get => name;
            set
            {
                if (!String.IsNullOrEmpty(value)) // it mean string have a value inside.
                {
                   
                    if(name != value)
                    {
                        NameChangedEventArgs args = new NameChangedEventArgs();
                        args.ExistingName = name;
                        args.NewName = value;
                        NameChanged(this, args);
                    }
                    name = value;

                }
            }

        }

        private void GradeBook_NameChanged(string existingName, string newName)
        {
            throw new NotImplementedException();
        }
    }
}
