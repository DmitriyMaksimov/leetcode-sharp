using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02053Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02053();
        sut.KthDistinct(new[] {"d", "b", "c", "b", "c", "a"}, 2).Should().Be("a");
    }

    [Test]
    public void T2()
    {
        var sut = new S02053();
        sut.KthDistinct(new[] {"aaa", "aa", "a"}, 1).Should().Be("aaa");
    }

    [Test]
    public void T3()
    {
        var sut = new S02053();
        sut.KthDistinct(new[] {"a", "b", "a"}, 3).Should().Be("");
    }
}