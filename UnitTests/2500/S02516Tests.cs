using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02516Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02516();
        Assert.That(sut.TakeCharacters("aabaaaacaabc", 2), Is.EqualTo(8));
    }

    [Test]
    public void T2()
    {
        var sut = new S02516();
        Assert.That(sut.TakeCharacters("a", 1), Is.EqualTo(-1));
    }
}
