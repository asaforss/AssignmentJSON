using System;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment;
using System.Collections.Generic;


namespace AssignmentTest
{
    [TestClass]
    public class MethodsTest
    {
        Methods methods = new Methods();

        //Begränsningar med mina test av metoden GetThisDayOfWeekAsANumber är att det är bara just dagens veckodag som kan testas. 
        //Borde kunna testa med andra idag också.
        //https://stackoverflow.com/questions/2425721/unit-testing-datetime-now

        [TestMethod]
        public void GetThisDayOfWeekAsANumber_RangeTest()
        {
            int currentDayNumber=methods.GetThisDayOfWeekAsANumber();

            Assert.IsTrue(currentDayNumber < 8);
            Assert.IsTrue(currentDayNumber > 0);
        }
        [TestMethod]
        public void GetThisDayOfWeekAsANumber_TodayNumberTest()
        {
            int currentDayNumber = methods.GetThisDayOfWeekAsANumber();

            //om söndag
            if (currentDayNumber==0)
            {
                Assert.IsTrue(currentDayNumber == 7); 
            }
            else
                Assert.IsTrue(currentDayNumber==(int)DateTime.Now.DayOfWeek);
        }

        [TestMethod]
        public void GetNumberOfUpcomingDaysTest_ProductTypeNormal()
        {
            List<DayOfWeek> days = new List<DayOfWeek>();
            days.Add(DayOfWeek.Monday);
            // days in advance is 3 can be ordered only on mondays
            Productlist product1 = new Productlist("gräsklippare", 3, ProductType.Normal, days);
            int currentTestDay = 2; //tuesday doesn't matter in this test
            int expectedUpcomingdays = 11;

            // 3 days in advance tuesday
            int numberOfUpcomingDays=methods.GetNumberOfAllUpcomingDays(product1,currentTestDay);

            Assert.IsTrue(numberOfUpcomingDays == expectedUpcomingdays,$"Pass, The number of all upcoming days is {numberOfUpcomingDays} as expected" +
                $" {expectedUpcomingdays} ");
        }
        [TestMethod]
        public void GetNumberOfUpcomingDaysTest_ProductTypeExternal()
        {
            List<DayOfWeek> days = new List<DayOfWeek>();
            days.Add(DayOfWeek.Monday);
            // days in advance is 3 can be ordered only on mondays
            Productlist product1 = new Productlist("gräsklippare", 3, ProductType.External, days);
            //All external products need to be ordered 5 days in advance
            int currentTestDay = 2; //tuesday doesn't matter in this test
            int expectedUpcomingdays = 9;

            // 3 days in advance tuesday
            int numberOfUpcomingDays = methods.GetNumberOfAllUpcomingDays(product1, currentTestDay);

            Assert.IsTrue(numberOfUpcomingDays == expectedUpcomingdays, $"Pass, The number of all upcoming days is {numberOfUpcomingDays} as expected" +
                $" {expectedUpcomingdays} ");
        }
        [TestMethod]
        public void GetNumberOfUpcomingDaysTest_ProductTypeTemporary()
        {
            List<DayOfWeek> days = new List<DayOfWeek>();
            days.Add(DayOfWeek.Monday);
            // days in advance is 3 can be ordered only on mondays
            Productlist product1 = new Productlist("gräsklippare", 3, ProductType.Temporary, days);
            //Temporary products can only be ordered witin the current week
            int currentTestDay = 2; //tuesday
            int expectedUpcomingdays = 3; // tuesday + 3 days in advance (gives tuesday wednedsday thursday in advance) friday saturday sunday left in
                                          // the week thats the expected 3 days.                                     

            // 3 days in advance tuesday
            int numberOfUpcomingDays = methods.GetNumberOfAllUpcomingDays(product1, currentTestDay);

            Assert.IsTrue(numberOfUpcomingDays == expectedUpcomingdays, $"Pass, The number of all upcoming days is {numberOfUpcomingDays} as expected" +
                $" {expectedUpcomingdays} ");
        }
        // Depends on the current day of the week.
        [TestMethod]
        public void GetDeliveryDates_Count()
        {
            List<DayOfWeek> days = new List<DayOfWeek>();
            days.Add(DayOfWeek.Monday);
            // days in advance is 3 can be ordered only on mondays
            Productlist product1 = new Productlist("gräsklippare", 3, ProductType.Normal, days);
            int numberOfAllUpcomingDays = 11; // 14-3 normal type
            int expectedNumber;
            if (DateTime.Now.DayOfWeek ==DayOfWeek.Monday|| DateTime.Now.DayOfWeek == DayOfWeek.Saturday||DateTime.Now.DayOfWeek == DayOfWeek.Sunday)

                expectedNumber = 1; // One monday in the period.
            else
                expectedNumber = 2; // Two mondays in the period.
                                             
            List<DeliveryDate> deliveryDates = methods.GetDeliveryDates("13439", product1, numberOfAllUpcomingDays);

            Assert.IsTrue(deliveryDates.Count == expectedNumber, $"Pass, The list of DeliveryDates has {deliveryDates.Count} elements as expected" +
                $" {expectedNumber} ");
        }

        [TestMethod]
        public void ToDeliverDateList_Count()
        {
            List<DayOfWeek> days = new List<DayOfWeek>();
            days.Add(DayOfWeek.Monday);
            // days in advance is 3 can be ordered only on mondays
            Productlist product1 = new Productlist("gräsklippare", 3, ProductType.Normal, days);
            int expectedNumber;
            if (DateTime.Now.DayOfWeek == DayOfWeek.Monday || DateTime.Now.DayOfWeek == DayOfWeek.Saturday || DateTime.Now.DayOfWeek == DayOfWeek.Sunday)

                expectedNumber = 1; // One monday in the period.
            else
                expectedNumber = 2; // Two mondays in the period.

            List<DeliveryDate> deliveryDates = methods.ToDeliveryDateList("13439",product1);

            Assert.IsTrue(deliveryDates.Count == expectedNumber, $"Pass, The list of DeliveryDates has {deliveryDates.Count} elements as expected" +
                $" {expectedNumber}");
        }
    }
}
