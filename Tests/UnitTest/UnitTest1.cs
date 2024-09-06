using FluentAssertions;

namespace UnitTest;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        Assert.Pass();
    }

    [Test]
    public void Test_Fluent()
    {
        var x = 10;

        x.Should().Be(10);
    }

    [TestCase(10)]
    [TestCase(5)]
    [TestCase(2)]
    [TestCase(200)]
    public void Test_Fluent(int x)
    {
        x.Should().BeGreaterThan(0);
    }
}