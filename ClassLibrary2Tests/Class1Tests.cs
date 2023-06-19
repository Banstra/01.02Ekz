using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary2;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary2.Tests
{
    [TestClass()]
    public class Class1Tests
    {
        [TestMethod()]
        public void MinAVGTest()
        {
            string[] marks = { "4", "5", "3", "2", "4" };
            double expected = 3.0;
            
            Class1 calculator = new Class1();
            double result = calculator.MinAVG(marks);
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void MinAVGTest1()
        {
            string[] marks = { };
            double expected = 3.0;

            Class1 calculator = new Class1();
            double result = calculator.MinAVG(marks);
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void MinAVGTest2()
        {
            string[] marks = { "5", "4", "3", "2", "4" };
            double expected = 3.0;

            Class1 calculator = new Class1();
            double result = calculator.MinAVG(marks);
            Assert.AreEqual(expected, result);
        }
    }
 


}