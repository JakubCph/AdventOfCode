﻿using NUnit.Framework;
using ChronalCalibration;

namespace ChronalCalibration.Tests
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void ReadFile()
        {
            var reader = new FileReader();
            var sum = reader.SumNumbersFromFile(@"Input.txt");
            Assert.AreEqual(518,sum);
        }

        [Test]
        public void CalculateFirstRepeatedFrequencyTest()
        {
            var reader = new FileReader();
            var repeatedFreq = reader.CalculateFirstRepeatedFrequency(@"Input.txt");
            Assert.AreEqual(72889L, repeatedFreq);
        }

       
    }
}
