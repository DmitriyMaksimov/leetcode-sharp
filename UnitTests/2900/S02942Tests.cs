using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02942Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02942();
        Assert.That(sut.FindWordsContaining(new[] {"leet", "code"}, 'e'), Is.EqualTo((int[]) [0, 1]));
    }

    [Test]
    public void T2()
    {
        var sut = new S02942();
        Assert.That(sut.FindWordsContaining(new[] {"abc", "bcd", "aaaa", "cbc"}, 'a'), Is.EqualTo((int[]) [0, 2]));
    }

    [Test]
    public void T3()
    {
        var sut = new S02942();
        Assert.That(sut.FindWordsContaining(new[] {"abc", "bcd", "aaaa", "cbc"}, 'z'), Is.Empty);
    }
}