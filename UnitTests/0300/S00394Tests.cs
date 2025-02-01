using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00394Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00394();
        Assert.That(sut.DecodeString("3[a]2[bc]"), Is.EqualTo("aaabcbc"));
    }
    
    [Test]
    public void T2()
    {
        var sut = new S00394();
        Assert.That(sut.DecodeString("3[a2[c]]"), Is.EqualTo("accaccacc"));
    }

    [Test]
    public void T3()
    {
        var sut = new S00394();
        Assert.That(sut.DecodeString("2[abc]3[cd]ef"), Is.EqualTo("abcabccdcdcdef"));
    }

}