using DesignParkingSystem;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignParkingSystemUnitTestProject
{
    [TestClass]
    public class PositiveParkingSpacesTest
    {
        [TestMethod]
        public void SmallPositiveParkingSpace()
        {
            int smallParkingSpace = 5;
            int mediumParkingSpace = 8;
            int bigParkingSpace = 2;

            var parkingSystem = new ParkingSystem(bigParkingSpace, mediumParkingSpace, smallParkingSpace);

            bool expectedSmallParkingSpaceResult = true;
            bool actualSmallParkingSpaceResult = parkingSystem.AddCar(3);

            Assert.AreEqual(expectedSmallParkingSpaceResult, actualSmallParkingSpaceResult);
        }

        [TestMethod]
        public void MediumPositiveParkingSpace()
        {
            int smallParkingSpace = 1;
            int mediumParkingSpace = 3;
            int bigParkingSpace = 6;

            var parkingSystem = new ParkingSystem(bigParkingSpace, mediumParkingSpace, smallParkingSpace);

            bool expectedMediumParkingSpaceResult = true;
            bool actualMediumParkingSpaceResult = parkingSystem.AddCar(2);

            Assert.AreEqual(expectedMediumParkingSpaceResult, actualMediumParkingSpaceResult);
        }

        [TestMethod]
        public void BigPositiveParkingSpace()
        {
            int smallParkingSpace = 10;
            int mediumParkingSpace = 5;
            int bigParkingSpace = 6;

            var parkingSystem = new ParkingSystem(bigParkingSpace, mediumParkingSpace, smallParkingSpace);

            bool expectedBigParkingSpaceResult = true;
            bool actualBigParkingSpaceResult = parkingSystem.AddCar(1);

            Assert.AreEqual(expectedBigParkingSpaceResult, actualBigParkingSpaceResult);
        }
    }

    [TestClass]
    public class NegativeParkingSpacesTest
    {
        [TestMethod]
        public void SmallNegativeParkingSpaceOutOfSpots()
        {
            int smallParkingSpace = -5;
            int mediumParkingSpace = 5;
            int bigParkingSpace = 2;

            var parkingSystem = new ParkingSystem(bigParkingSpace, mediumParkingSpace, smallParkingSpace);

            bool expectedSmallParkingSpaceResult = false;
            bool actualSmallParkingSpaceResult = parkingSystem.AddCar(3);

            Assert.AreEqual(expectedSmallParkingSpaceResult, actualSmallParkingSpaceResult);
        }

        [TestMethod]
        public void MediumNegativeParkingSpaceOutOfSpots()
        {
            int smallParkingSpace = 3;
            int mediumParkingSpace = -12;
            int bigParkingSpace = 6;

            var parkingSystem = new ParkingSystem(bigParkingSpace, mediumParkingSpace, smallParkingSpace);

            bool expectedMediumParkingSpaceResult = false;
            bool actualMediumParkingSpaceResult = parkingSystem.AddCar(2);

            Assert.AreEqual(expectedMediumParkingSpaceResult, actualMediumParkingSpaceResult);
        }

        [TestMethod]
        public void BigNegativeParkingSpaceOutOfSpots()
        {
            int smallParkingSpace = 7;
            int mediumParkingSpace = 5;
            int bigParkingSpace = -3;

            var parkingSystem = new ParkingSystem(bigParkingSpace, mediumParkingSpace, smallParkingSpace);

            bool expectedBigParkingSpaceResult = false;
            bool actualBigParkingSpaceResult = parkingSystem.AddCar(1);

            Assert.AreEqual(expectedBigParkingSpaceResult, actualBigParkingSpaceResult);
        }
    }

    [TestClass]
    public class InvalidInputsTest
    {
        [TestMethod]
        public void SmallParkingSpaceInvalidValue()
        {
            int smallParkingSpace = 8;
            int mediumParkingSpace = 6;
            int bigParkingSpace = 7;

            var parkingSystem = new ParkingSystem(bigParkingSpace, mediumParkingSpace, smallParkingSpace);

            bool expectedSmallParkingSpaceResult = parkingSystem.AddCar(3);
            string invalidBooleanResult = expectedSmallParkingSpaceResult.ToString();

            Assert.AreNotEqual(expectedSmallParkingSpaceResult, invalidBooleanResult);
        }

        [TestMethod]
        public void MediumParkingSpaceInvalidValue()
        {
            int smallParkingSpace = 7;
            int mediumParkingSpace = -12;
            int bigParkingSpace = 3;

            var parkingSystem = new ParkingSystem(bigParkingSpace, mediumParkingSpace, smallParkingSpace);

            bool expectedMediumParkingSpaceResult = parkingSystem.AddCar(2);
            string invalidBooleanResult = expectedMediumParkingSpaceResult.ToString();

            Assert.AreNotEqual(expectedMediumParkingSpaceResult, invalidBooleanResult);
        }

        [TestMethod]
        public void BigParkingSpaceInvalidValue()
        {
            int smallParkingSpace = 2;
            int mediumParkingSpace = 4;
            int bigParkingSpace = 8;

            var parkingSystem = new ParkingSystem(bigParkingSpace, mediumParkingSpace, smallParkingSpace);

            bool expectedMediumParkingSpaceResult = parkingSystem.AddCar(1);
            string invalidBooleanResult = expectedMediumParkingSpaceResult.ToString();

            Assert.AreNotEqual(expectedMediumParkingSpaceResult, invalidBooleanResult);
        }

        [TestMethod]
        public void SmallCarTypeInvalidValue()
        {
            int smallParkingSpace = 3;
            int mediumParkingSpace = 4;
            int bigParkingSpace = 5;

            var parkingSystem = new ParkingSystem(bigParkingSpace, mediumParkingSpace, smallParkingSpace);

            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => parkingSystem.AddCar(-1));
        }

        [TestMethod]
        public void BigCarTypeInvalidValue()
        {
            int smallParkingSpace = 9;
            int mediumParkingSpace = 4;
            int bigParkingSpace = 10;

            var parkingSystem = new ParkingSystem(bigParkingSpace, mediumParkingSpace, smallParkingSpace);

            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => parkingSystem.AddCar(4));
        }
    }
}
