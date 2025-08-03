using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02360Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02360();
        Assert.That(sut.LongestCycle([3,3,4,2,3]), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S02360();
        Assert.That(sut.LongestCycle([2,-1,3,1]), Is.EqualTo(-1));
    }
}