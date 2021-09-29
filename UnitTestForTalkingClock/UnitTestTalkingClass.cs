using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestForTalkingClock
{

/***************************************************************************************************************************
* Name      : Satya Prasad Vanumu
* Date      : 29/Sep/2021
* ClassName : UnitTestForTalkingClock 
* Desc      : The UnitTestForTalkingClock Class for Automation Unit Testing with TDD approach.
****************************************************************************************************************************/

    [TestClass]
    public class UnitTestTalkingClass
    {
        //Test Method to test the given time displays in words in
        //Human Friendly way for rounded values.
        [TestMethod]
        public void UnitTest_ConvertTimeToWords_RoundValue()
        {
            //Arrange
            //Setting up the object of the class.
            TalkingClock.DigitalTimeToWords objTest = new TalkingClock.DigitalTimeToWords();

            //Act
            //Initialising and Calling the method with values for test.
            int iTestHrs = 3;
            int iTestMins = 0;
            string sCheck = objTest.ConvertTimeToWords(iTestHrs, iTestMins);

            //Assert
            //Checking the Result matches
            Assert.AreEqual("Three O' Clock", sCheck.Trim());
        }


        //Test Method to test the given time displays in words in Human Friendly way
        //for given Hours and Minutes value.
        [TestMethod]
        public void UnitTest_ConvertTimeToWords_HoursAndMinutes()
        {
            //Arrange
            //Setting up the object of the class.
            TalkingClock.DigitalTimeToWords objTest = new TalkingClock.DigitalTimeToWords();

            //Act
            //Initialising and Calling the method with values for test.
            int iTestHrs = 11;
            int iTestMins =45;
            string sCheck = objTest.ConvertTimeToWords(iTestHrs, iTestMins);

            //Assert
            //Checking the Result matches
            Assert.AreEqual("Quarter To Twelve", sCheck.Trim());
        }
    }
}
