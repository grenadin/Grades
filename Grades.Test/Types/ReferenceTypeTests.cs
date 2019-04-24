using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Grades.Test.Types
{
    [TestClass]
    public class ReferenceTypeTests
    {
        [TestMethod]
        public void IntergerVariableHoldValue()
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
