using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02379Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02379();
        Assert.That(sut.MinimumRecolors("WBBWWBBWBW", 7), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S02379();
        Assert.That(sut.MinimumRecolors("WBWBBBW", 2), Is.EqualTo(0));
    }
}