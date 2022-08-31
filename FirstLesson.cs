using NUnit.Framework;
using System;
using System.Threading;

namespace ClassWork
{
    internal class Class2
    {
        [Test]
        public static void IsTrue()
        {
            int leftOver = 995 % 3;
            Assert.AreEqual(0, leftOver, "Devide to 3");
        }

        [Test]
        public static void TodayIsFriday()
        {
            DateTime currentTime = DateTime.Now;
            Assert.AreEqual(DayOfWeek.Friday, currentTime.DayOfWeek, "Today is friday");
        }
        [Test]
        public static void Delay()
        {
            Thread.Sleep(2000);
        }

    }
}
