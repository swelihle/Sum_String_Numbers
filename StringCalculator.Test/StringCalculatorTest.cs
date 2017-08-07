using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using String_Number_Calculator;

namespace StringCalculator.Test
{
    [TestClass]
    public class StringCalculatorTest
    {
        [TestMethod]
        public void Add_EmptyString_Return_0() { TesAdd("", 0); }

        [TestMethod]
        public void Add_OneNumber_5_ReturnSameNumber_5() { TesAdd("5", 5); }

        [TestMethod]
        public void Add_TwoNumbers_1_AND_2_AllowNewLine_Return_6() { TesAdd("1\n2,3", 6); }

        [TestMethod]
        public void Add_TwoNumbers_1_AND_2_Return_3() { TesAdd("1,2", 3); }

        [TestMethod]
        public void Add_TwoNumbers_1_AND_2_Support_Different_Delimiters_Return_3() { TesAdd("//;\n1;2", 3); }

        private static void TesAdd(string input, int expectedREsult)
        {
            //Arrange
            CalculatorOperation cal = new CalculatorOperation();
            //Act
            var result = cal.Add(input);
            //Assert
            Assert.AreEqual(expectedREsult, result);
        }
    }
}
