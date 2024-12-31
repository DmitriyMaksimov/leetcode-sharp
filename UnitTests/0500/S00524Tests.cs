using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00524Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00524();
        sut.FindLongestWord("abpcplea", ["ale", "apple", "monkey", "plea"]).Should().Be("apple");
    }

    [Test]
    public void T2()
    {
        var sut = new S00524();
        sut.FindLongestWord("abpcplea", ["a", "b", "c"]).Should().Be("a");
    }
}
