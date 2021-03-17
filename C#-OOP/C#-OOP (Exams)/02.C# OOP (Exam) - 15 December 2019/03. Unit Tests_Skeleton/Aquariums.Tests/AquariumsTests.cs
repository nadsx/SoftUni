namespace Aquariums.Tests
{
    using System;
    using NUnit.Framework;

    public class AquariumsTests
    {
        private Fish fish1;
        private Fish fish2;
        private Fish fish3;
        private Aquarium aquarium1;

        [SetUp]
        public void Setup()
        {
            fish1 = new Fish("Fish1");
            fish2 = new Fish("Fish2");
            fish3 = new Fish("Fish3");

            aquarium1 = new Aquarium("Aquarium1", 2);
        }

        [Test]
        public void TestFishConstructor()
        {
            Assert.AreEqual("Fish1", fish1.Name);
            Assert.AreEqual(true, fish1.Available);
        }

        [Test]
        public void TestAquariumConstructor()
        {
            Assert.AreEqual("Aquarium1", aquarium1.Name);
            Assert.AreEqual(2, aquarium1.Capacity);
            Assert.AreEqual(0, aquarium1.Count);
        }

        [Test]
        public void TestAquariumName()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                new Aquarium(null, 3);
            });
        }

        [Test]
        public void TestAquariumCapacity()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                new Aquarium("Aquarium2", -10);
            });
        }

        [Test]
        public void TestAddException()
        {
            aquarium1.Add(fish1);
            aquarium1.Add(fish2);

            Assert.Throws<InvalidOperationException>(() =>
            {
                aquarium1.Add(fish3);
            });
        }


        [Test]
        public void TestAdd()
        {
            aquarium1.Add(fish1);

            Assert.AreEqual(1, aquarium1.Count);           
        }

        [Test]
        public void TestRemoveException()
        {
            aquarium1.Add(fish1);
            aquarium1.Add(fish2);

            Assert.Throws<InvalidOperationException>(() =>
            {
                aquarium1.RemoveFish("Fish0");
            });
        }

        [Test]
        public void TestRemove()
        {
            aquarium1.Add(fish1);
            aquarium1.Add(fish2);
            aquarium1.RemoveFish(fish2.Name);

            Assert.AreEqual(1, aquarium1.Count);
        }

        [Test]
        public void TestSellFishException()
        {
            aquarium1.Add(fish1);
            aquarium1.Add(fish2);

            Assert.Throws<InvalidOperationException>(() =>
            {
                aquarium1.SellFish("Fish0");
            });
        }

        [Test]
        public void TestSellFish()
        {
            aquarium1.Add(fish1);
            aquarium1.Add(fish2);
            Fish selledFish = aquarium1.SellFish(fish2.Name);

            Assert.AreEqual(false, selledFish.Available);
        }

        [Test]
        public void TestReport()
        {
            aquarium1.Add(fish1);
            aquarium1.Add(fish2);

            string expected = $"Fish available at Aquarium1: Fish1, Fish2";
            string actual = aquarium1.Report();

            Assert.AreEqual(expected, actual);
        }
    }
}