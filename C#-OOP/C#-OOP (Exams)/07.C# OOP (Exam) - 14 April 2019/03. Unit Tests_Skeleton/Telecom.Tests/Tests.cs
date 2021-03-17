namespace Telecom.Tests
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class Tests
    {
        private Phone phone;

        [SetUp]
        public void SetUp()
        {
            this.phone = new Phone("SAMSUNG", "S9");
        }

        [Test]
        public void TestPhoneConstructor()
        {
            Assert.AreEqual("SAMSUNG", this.phone.Make);
            Assert.AreEqual("S9", this.phone.Model);
        }

        [Test]
        public void TestInvalidPhoneMake()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                new Phone(null, "S9");
            });
        }

        [Test]
        public void TestInvalidPhoneModel()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                new Phone("SAMSUNG", null);
            });
        }

        [Test]
        public void TestAddContact()
        {
            this.phone.AddContact("Philip", "12345");

            Assert.AreEqual(1, this.phone.Count);
        }

        [Test]
        public void TestAddExistingContact()
        {
            this.phone.AddContact("Rayan", "4321");

            Assert.Throws<InvalidOperationException>(() =>
            {
                this.phone.AddContact("Rayan", "4321");
            });
        }

        [Test]
        public void TestCall()
        {
            this.phone.AddContact("Marz", "11111");

            string expected = $"Calling Marz - 11111...";
            string actual = this.phone.Call("Marz");

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestCallInvalidContact()
        {
            this.phone.AddContact("Logan", "22222");

            Assert.Throws<InvalidOperationException>(() =>
            {
                this.phone.Call("Jake");
            });
        }
    }
}