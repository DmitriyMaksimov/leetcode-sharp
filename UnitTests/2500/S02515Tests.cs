using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02515Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02515();
        sut.ClosetTarget(new[] {"hello", "i", "am", "leetcode", "hello"}, "hello", 1).Should().Be(1);
    }

    [Test]
    public void T2()
    {
        var sut = new S02515();
        sut.ClosetTarget(new[] {"a", "b", "leetcode"}, "leetcode", 0).Should().Be(1);
    }

    [Test]
    public void T3()
    {
        var sut = new S02515();
        sut.ClosetTarget(new[] {"i", "eat", "leetcode"}, "ate", 0).Should().Be(-1);
    }
}