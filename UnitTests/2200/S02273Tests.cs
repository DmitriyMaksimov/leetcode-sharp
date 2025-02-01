using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02273Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02273();
        Assert.That(sut.RemoveAnagrams(new[] {"abba", "baba", "bbaa", "cd", "cd"}), Is.EqualTo((string[]) ["abba", "cd"]));
    }

    [Test]
    public void T2()
    {
        var sut = new S02273();
        Assert.That(sut.RemoveAnagrams(new[] {"a", "b", "c", "d", "e"}), Is.EqualTo((string[]) ["a", "b", "c", "d", "e"]));
    }
}
