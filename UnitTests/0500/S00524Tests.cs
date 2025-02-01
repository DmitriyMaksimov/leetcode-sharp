using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00524Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00524();
        Assert.That(sut.FindLongestWord("abpcplea", ["ale", "apple", "monkey", "plea"]), Is.EqualTo("apple"));
    }

    [Test]
    public void T2()
    {
        var sut = new S00524();
        Assert.That(sut.FindLongestWord("abpcplea", ["a", "b", "c"]), Is.EqualTo("a"));
    }
}
