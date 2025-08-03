using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00456Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00456();
        Assert.That(sut.Find132pattern([1, 2, 3, 4]), Is.False);
    }

    [Test]
    public void T2()
    {
        var sut = new S00456();
        Assert.That(sut.Find132pattern([3, 1, 4, 2]), Is.True);
    }

    [Test]
    public void T3()
    {
        var sut = new S00456();
        Assert.That(sut.Find132pattern([-1, 3, 2, 0]), Is.True);
    }
}
