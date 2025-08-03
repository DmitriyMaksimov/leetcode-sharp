using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00162Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00162();
        Assert.That(sut.FindPeakElement([1, 2, 3, 1]), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S00162();
        Assert.That(sut.FindPeakElement([1, 2, 1, 3, 5, 6, 4]), Is.AnyOf(1, 5));
    }
}
