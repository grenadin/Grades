using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Grades;



namespace Grades.Test
{
    [TestClass]
    public class GradeBookTests
    {
        [TestMethod]
        public void UsingArray()
        {
            float[] grades;
            grades = new float[3];

            AddGrade(grades);
            Assert.AreEqual(89.5f, grades[1]);

        }

        private void AddGrade(float[] grades)
        {
            grades[1] = 89.5f;
        }

        [TestMethod]
        public void ComputesHighestGrade()
        {
            
            GradeBook book = new GradeBook();
            book.AddGrade(10);
            book.AddGrade(90);

            GradeStatistics result = book.ComputeStatistics();
            
            Assert.AreEqual(90, result.HighestGrade);
        }

        [TestMethod]
        public void ComputesLowestGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(10);
            book.AddGrade(90);

            GradeStatistics result = book.ComputeStatistics();

            Assert.AreEqual(10, result.LowestGrade);
        }

        [TestMethod]
        public void ComputesAverageGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);
         

            GradeStatistics result = book.ComputeStatistics();

            Assert.AreEqual(85.16666412353516, result.AverageGrade,0.001);
        }
    }
}
