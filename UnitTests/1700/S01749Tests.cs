using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01749Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01749();
        Assert.That(sut.MaxAbsoluteSum([1, -3, 2, 3, -4]), Is.EqualTo(5));
    }

    [Test]
    public void T2()
    {
        var sut = new S01749();
        Assert.That(sut.MaxAbsoluteSum([2, -5, 1, -4, 3, -2]), Is.EqualTo(8));
    }
}
