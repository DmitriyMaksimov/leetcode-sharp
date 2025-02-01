using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00576Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00576();
        Assert.That(sut.FindPaths(2, 2, 2, 0, 0), Is.EqualTo(6));
    }

    [Test]
    public void T2()
    {
        var sut = new S00576();
        Assert.That(sut.FindPaths(1, 3, 3, 0, 1), Is.EqualTo(12));
    }
}