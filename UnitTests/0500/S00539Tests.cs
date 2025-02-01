using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00539Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00539();
        Assert.That(sut.FindMinDifference(["23:59", "00:00"]), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S00539();
        Assert.That(sut.FindMinDifference(["00:00", "23:59", "00:00"]), Is.EqualTo(0));
    }
}
