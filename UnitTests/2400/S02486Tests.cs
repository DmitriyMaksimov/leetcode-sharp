using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02486Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02486();
        Assert.That(sut.AppendCharacters("coaching", "coding"), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S02486();
        Assert.That(sut.AppendCharacters("abcde", "a"), Is.EqualTo(0));
    }

    [Test]
    public void T3()
    {
        var sut = new S02486();
        Assert.That(sut.AppendCharacters("z", "abcde"), Is.EqualTo(5));
    }
}