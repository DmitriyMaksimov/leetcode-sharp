using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02455Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02455();
        Assert.That(sut.AverageValue([1, 3, 6, 10, 12, 15]), Is.EqualTo(9));
    }

    [Test]
    public void T2()
    {
        var sut = new S02455();
        Assert.That(sut.AverageValue([1, 2, 4, 7, 10]), Is.EqualTo(0));
    }
}