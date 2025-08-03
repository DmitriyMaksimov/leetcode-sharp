using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01732Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01732();
        Assert.That(sut.LargestAltitude([-5, 1, 5, 0, -7]), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S01732();
        Assert.That(sut.LargestAltitude([-4, -3, -2, -1, 4, 3, 2]), Is.EqualTo(0));
    }
}