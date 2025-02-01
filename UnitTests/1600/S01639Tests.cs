using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01639Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01639();
        Assert.That(sut.NumWays(new[] {"acca", "bbbb", "caca"}, "aba"), Is.EqualTo(6));
    }

    [Test]
    public void T2()
    {
        var sut = new S01639();
        Assert.That(sut.NumWays(new[] {"abba", "baab"}, "bab"), Is.EqualTo(4));
    }
}