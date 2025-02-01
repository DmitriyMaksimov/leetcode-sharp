using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01915Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01915();
        Assert.That(sut.WonderfulSubstrings("aba"), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S01915();
        Assert.That(sut.WonderfulSubstrings("aabb"), Is.EqualTo(9));
    }

    [Test]
    public void T3()
    {
        var sut = new S01915();
        Assert.That(sut.WonderfulSubstrings("he"), Is.EqualTo(2));
    }
}