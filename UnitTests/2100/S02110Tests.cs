using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02110Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02110();
        Assert.That(sut.GetDescentPeriods([3, 2, 1, 4]), Is.EqualTo(7));
    }

    [Test]
    public void T2()
    {
        var sut = new S02110();
        Assert.That(sut.GetDescentPeriods([8, 6, 7, 7]), Is.EqualTo(4));
    }

    [Test]
    public void T3()
    {
        var sut = new S02110();
        Assert.That(sut.GetDescentPeriods([1]), Is.EqualTo(1));
    }
}
