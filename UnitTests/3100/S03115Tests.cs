using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03115Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03115();
        Assert.That(sut.MaximumPrimeDifference([4, 2, 9, 5, 3]), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S03115();
        Assert.That(sut.MaximumPrimeDifference([4, 8, 2, 8]), Is.EqualTo(0));
    }
}