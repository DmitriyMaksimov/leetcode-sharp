using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02273Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02273();
        sut.RemoveAnagrams(new[] {"abba", "baba", "bbaa", "cd", "cd"}).Should().Equal("abba", "cd");
    }

    [Test]
    public void T2()
    {
        var sut = new S02273();
        sut.RemoveAnagrams(new[] {"a", "b", "c", "d", "e"}).Should().Equal("a", "b", "c", "d", "e");
    }
}