using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S01594))]
public class S01594Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01594();
        Assert.That(sut.MaxProductPath([[-1, -2, -3], [-2, -3, -3], [-3, -3, -2]]), Is.EqualTo(-1));
    }

    [Test]
    public void T2()
    {
        var sut = new S01594();
        Assert.That(sut.MaxProductPath([[1, -2, 1], [1, -2, 1], [3, -4, 1]]), Is.EqualTo(8));
    }

    [Test]
    public void T3()
    {
        var sut = new S01594();
        Assert.That(sut.MaxProductPath([[1, 3], [0, -4]]), Is.EqualTo(0));
    }
}