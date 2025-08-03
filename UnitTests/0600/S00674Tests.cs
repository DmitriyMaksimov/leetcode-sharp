using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00674Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00674();
        Assert.That(sut.FindLengthOfLCIS([1, 3, 5, 4, 7]), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S00674();
        Assert.That(sut.FindLengthOfLCIS([2, 2, 2, 2, 2]), Is.EqualTo(1));
    }
}