using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Grades.Test.Types
{
    [TestClass]
    public class TypeTests
    {
        [TestMethod]
        public void ValueTestPassByValue()
        {
            int x = 46;
            int y = x;
            Assert.AreEqual(46, y);
            IncrementNumber(ref x);
            
            Assert.AreEqual(47, x);
        }

        private int IncrementNumber(ref int number) => number += 1;

        [TestMethod]
        public void ReferenceTypePassByValue()
        {
            GradeBook book1 = new GradeBook();
            GradeBook book2 = book1;
         
            GiveBookAName(ref book2);
           
            Assert.AreEqual("A Gradebook", book2.Name);

        }

        private void GiveBookAName(ref GradeBook book)
        {
            book = new GradeBook();// Create new allocate
            book.Name = "A Gradebook";
        }


            
        [TestMethod]
        public void StringComparisions()
        {
            string name1 = "Harirak";
            string name2 = "harirak";
            
            bool result = string.Equals(name1, name2,StringComparison.InvariantCultureIgnoreCase);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void IntegerVariableHoldValue()
        {
            int x1 = 100;
            int x2 = x1;

            //x1 = 4;
            Assert.AreEqual(x1, x2);
        }
        
        [TestMethod]
        public void RefVariableHoldReference()
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;

            g1.Name = "Harirak";

            Assert.AreEqual(g1.Name, g2.Name);
            //Assert.AreNotEqual(g1.Name, g2.Name);

        }

       
    }

    
}
