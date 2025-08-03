using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00135Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00135();
        Assert.That(sut.Candy([1, 0, 2]), Is.EqualTo(5));
    }

    [Test]
    public void T2()
    {
        var sut = new S00135();
        Assert.That(sut.Candy([1, 2, 2]), Is.EqualTo(4));
    }
}