using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01827Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01827();
        Assert.That(sut.MinOperations([1, 1, 1]), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S01827();
        Assert.That(sut.MinOperations([1, 5, 2, 4, 1]), Is.EqualTo(14));
    }

    [Test]
    public void T3()
    {
        var sut = new S01827();
        Assert.That(sut.MinOperations([8]), Is.EqualTo(0));
    }
}