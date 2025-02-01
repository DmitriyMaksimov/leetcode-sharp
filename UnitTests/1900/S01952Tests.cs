using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01952Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01952();
        Assert.That(sut.IsThree(2), Is.False);
    }

    [Test]
    public void T2()
    {
        var sut = new S01952();
        Assert.That(sut.IsThree(4), Is.True);
    }
}
