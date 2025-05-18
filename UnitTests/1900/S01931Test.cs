using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S01931))]
public class S01931Test
{
    [Test]
    public void T1()
    {
        var sut = new S01931();
        Assert.That(sut.ColorTheGrid(1, 1), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S01931();
        Assert.That(sut.ColorTheGrid(1, 2), Is.EqualTo(6));
    }

    [Test]
    public void T3()
    {
        var sut = new S01931();
        Assert.That(sut.ColorTheGrid(5, 5), Is.EqualTo(580986));
    }
}
