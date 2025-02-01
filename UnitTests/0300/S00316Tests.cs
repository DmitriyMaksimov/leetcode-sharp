using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00316Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00316();
        Assert.That(sut.RemoveDuplicateLetters("bcabc"), Is.EqualTo("abc"));
    }

    [Test]
    public void T2()
    {
        var sut = new S00316();
        Assert.That(sut.RemoveDuplicateLetters("cbacdcbc"), Is.EqualTo("acdb"));
    }
}