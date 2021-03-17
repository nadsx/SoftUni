namespace ParkingSystem.Tests
{
    using System;
    using NUnit.Framework;

    public class SoftParkTest
    {
        private SoftPark softPark;
        private Car car;

        [SetUp]
        public void Setup()
        {
            this.softPark = new SoftPark();
            this.car = new Car("Toyota", "1234");
        }

        [Test]
        public void TestCarConstructor()
        {
            Assert.AreEqual("Toyota", this.car.Make);
            Assert.AreEqual("1234", this.car.RegistrationNumber);
        }

        [Test]
        public void TestSoftParkConstructor()
        {
            int count = this.softPark.Parking.Count;
            Assert.AreEqual(12, count);
        }

        [Test]
        public void TestParkCar()
        {
            string actual = this.softPark.ParkCar("B1", this.car);

            string expected = $"Car:1234 parked successfully!";

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestMissingParkingSpot()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                this.softPark.ParkCar("B8", this.car);
            });
        }

        [Test]
        public void TestParkingSpotTaken()
        {
            this.softPark.ParkCar("B1", this.car);

            Assert.Throws<ArgumentException>(() =>
            {
                this.softPark.ParkCar("B1", this.car);
            });
        }

        [Test]
        public void TestCarAlreadyParked()
        {
            this.softPark.ParkCar("B1", this.car);

            Assert.Throws<InvalidOperationException>(() =>
            {
                this.softPark.ParkCar("B2", this.car);
            });
        }

        [Test]
        public void TestRemoveCar()
        {
            this.softPark.ParkCar("B1", this.car);

            string actual = this.softPark.RemoveCar("B1", this.car);

            string expected = "Remove car:1234 successfully!";

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestRemoveCarFromInvalidSpot()
        {
            this.softPark.ParkCar("B1", this.car);

            Assert.Throws<ArgumentException>(() =>
            {
                this.softPark.RemoveCar("B8", this.car);
            });
        }

        [Test]
        public void TestRemoveInvalidCar()
        {
            Car newCar = new Car("BMW", "4321");

            Assert.Throws<ArgumentException>(() =>
            {
                this.softPark.RemoveCar("A1", newCar);
            });
        }
    }
}