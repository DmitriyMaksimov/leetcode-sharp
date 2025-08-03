using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00673Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00673();
        Assert.That(sut.FindNumberOfLIS([1, 3, 5, 4, 7]), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S00673();
        Assert.That(sut.FindNumberOfLIS([2, 2, 2, 2, 2]), Is.EqualTo(5));
    }
}