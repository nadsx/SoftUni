using System;
using NUnit.Framework;

public class HeroRepositoryTests
{
    private Hero hero1;
    private Hero hero2;
    private Hero hero3;
    private HeroRepository repository;

    [SetUp]
    public void Setup()
    {
        this.hero1 = new Hero("Name1", 1);
        this.hero2 = new Hero("Name2", 2);
        this.hero3 = new Hero("Name3", 3);
        this.repository = new HeroRepository();
    }

    [Test]
    public void TestHeroConstructor()
    {
        Assert.AreEqual("Name1", this.hero1.Name);
        Assert.AreEqual(1, this.hero1.Level);
    }

    [Test]
    public void TestHeroRepConstructor()
    {
        Assert.AreEqual(0, this.repository.Heroes.Count);
    }

    [Test]
    public void TestCreateNullHero()
    {
        Assert.Throws<ArgumentNullException>(() =>
        {
            this.repository.Create(null);
        });
    }

    [Test]
    public void TestCreateExistingHero()
    {
        this.repository.Create(this.hero1);

        Assert.Throws<InvalidOperationException>(() =>
        {
            this.repository.Create(this.hero1);
        });
    }

    [Test]
    public void TestCreate()
    {
        string expected = $"Successfully added hero Name1 with level 1";

        Assert.AreEqual(expected, this.repository.Create(this.hero1));
    }

    [Test]
    public void TestCreateCount()
    {
        this.repository.Create(this.hero1);

        Assert.AreEqual(1, this.repository.Heroes.Count);
    }

    [Test]
    public void TestRemoveNullName()
    {
        this.repository.Create(this.hero1);

        Assert.Throws<ArgumentNullException>(() =>
        {
            this.repository.Remove("");
        });
    }

    [Test]
    public void TestRemove()
    {
        this.repository.Create(this.hero1);

        Assert.AreEqual(true, this.repository.Remove(this.hero1.Name));
    }

    [Test]
    public void TestGetHeroWithHighestLevel()
    {
        this.repository.Create(this.hero1);
        this.repository.Create(this.hero2);
        this.repository.Create(this.hero3);

        Assert.AreEqual(this.hero3, this.repository.GetHeroWithHighestLevel());
    }

    [Test]
    public void TestGetHero()
    {
        this.repository.Create(this.hero1);
        this.repository.Create(this.hero2);
        this.repository.Create(this.hero3);

        Assert.AreEqual(this.hero1, this.repository.GetHero(this.hero1.Name));
    }
}