using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02511Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02511();
        Assert.That(sut.CaptureForts([1, 0, 0, -1, 0, 0, 0, 0, 1]), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S02511();
        Assert.That(sut.CaptureForts([0, 0, 1, -1]), Is.EqualTo(0));
    }
}