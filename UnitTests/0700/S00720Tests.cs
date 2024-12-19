using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00720Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00720();
        sut.LongestWord(["w", "wo", "wor", "worl", "world"]).Should().Be("world");
    }

    [Test]
    public void T2()
    {
        var sut = new S00720();
        sut.LongestWord(["a", "banana", "app", "appl", "ap", "apply", "apple"]).Should().Be("apple");
    }
}
