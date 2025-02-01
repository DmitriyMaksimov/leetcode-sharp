using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01455Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01455();
        Assert.That(sut.IsPrefixOfWord("i love eating burger", "burg"), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S01455();
        Assert.That(sut.IsPrefixOfWord("this problem is an easy problem", "pro"), Is.EqualTo(2));
    }

    [Test]
    public void T3()
    {
        var sut = new S01455();
        Assert.That(sut.IsPrefixOfWord("i am tired", "you"), Is.EqualTo(-1));
    }
}