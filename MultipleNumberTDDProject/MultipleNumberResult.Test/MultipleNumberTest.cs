using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MultipleNumber.Library;
namespace MultipleNumberResult.Test
{
    [TestClass]
    public class MultipleNumberTest
    {
        MultipleResult obj_result = new MultipleResult();
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange 
            int number = 1;

            //Act
            string actualresult = obj_result.GetValue_OfMultipleNumber(number);

            //Assert
            Assert.AreEqual(number.ToString(), actualresult);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //Arrange 
            int number = 3;

            //Act
            string actualresult = obj_result.GetValue_OfMultipleNumber(number);

            //Assert
            Assert.AreEqual("Fizz", actualresult);
        }

        [TestMethod]
        public void TestMethod3()
        {
            //Arrange 
            int number = 6;

            //Act
            string actualresult = obj_result.GetValue_OfMultipleNumber(number);

            //Assert
            Assert.AreEqual("Fizz", actualresult);
        }
        [TestMethod]
        public void TestMethod4()
        {
            //Arrange 
            int number = 5;

            //Act
            string actualresult = obj_result.GetValue_OfMultipleNumber(number);

            //Assert
            Assert.AreEqual("Buzz", actualresult);
        }
        [TestMethod]
        public void TestMethod5()
        {
            //Arrange 
            int number = 10;

            //Act
            string actualresult = obj_result.GetValue_OfMultipleNumber(number);

            //Assert
            Assert.AreEqual("Buzz", actualresult);
        }
        [TestMethod]
        public void TestMethod6()
        {
            //Arrange 
            int number = 15;

            //Act
            string actualresult = obj_result.GetValue_OfMultipleNumber(number);

            //Assert
            Assert.AreEqual("FizzBuzz", actualresult);
        }
    }
}
