using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02996Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02996();
        Assert.That(sut.MissingInteger([1, 2, 3, 2, 5]), Is.EqualTo(6));
    }

    [Test]
    public void T2()
    {
        var sut = new S02996();
        Assert.That(sut.MissingInteger([3, 4, 5, 1, 12, 14, 13]), Is.EqualTo(15));
    }
}