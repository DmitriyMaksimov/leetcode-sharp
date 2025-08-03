using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00976Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00976();
        Assert.That(sut.LargestPerimeter([2, 1, 2]), Is.EqualTo(5));
    }

    [Test]
    public void T2()
    {
        var sut = new S00976();
        Assert.That(sut.LargestPerimeter([1, 2, 1, 10]), Is.EqualTo(0));
    }
}