using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CircusTrain;
using System.Collections.Generic;
using System.Diagnostics;

namespace CircusTrainUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        readonly Train train = new Train();
        readonly Case testCase = new Case();

        [TestMethod]
        public void TestCase1()
        {
            List<Animal> animals = testCase.Scenario(1, 0, 0, 0, 3, 2);
            train.AddWagons(animals);

            Assert.AreEqual(2, train.Wagons.Count);
        }

        [TestMethod]
        public void TestCase2()
        {
            List<Animal> animals = testCase.Scenario(1, 0, 0, 5, 2, 1);
            train.AddWagons(animals);

            Assert.AreEqual(2, train.Wagons.Count);
        }

        [TestMethod]
        public void TestCase3()
        {
            List<Animal> animals = testCase.Scenario(1, 1, 1, 1, 1, 1);
            train.AddWagons(animals);

            Assert.AreEqual(4, train.Wagons.Count);
        }

        [TestMethod]
        public void TestCase4()
        {
            List<Animal> animals = testCase.Scenario(2, 1, 1, 1, 5, 1);
            train.AddWagons(animals);

            Assert.AreEqual(5, train.Wagons.Count);
        }

        [TestMethod]
        public void TestCase5()
        {
            List<Animal> animals = testCase.Scenario(1, 0, 0, 1, 1, 2);
            train.AddWagons(animals);

            Assert.AreEqual(2, train.Wagons.Count);
        }

        [TestMethod]
        public void TestCase6()
        {
            List<Animal> animals = testCase.Scenario(3, 0, 0, 0, 2, 3);
            train.AddWagons(animals);

            Assert.AreEqual(3, train.Wagons.Count);
        }

        [TestMethod]
        public void TestCase7()
        {
            List<Animal> animals = testCase.Scenario(7, 3, 3, 0, 5, 6);
            train.AddWagons(animals);

            Assert.AreEqual(13, train.Wagons.Count);
        }

        [TestMethod]
        public void TestCase8()
        {
            List<Animal> animals = testCase.Scenario(0, 0, 0, 0, 0, 0);
            train.AddWagons(animals);

            Assert.AreEqual(0, train.Wagons.Count);
        }
    }
}
