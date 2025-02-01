using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02053Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02053();
        Assert.That(sut.KthDistinct(new[] {"d", "b", "c", "b", "c", "a"}, 2), Is.EqualTo("a"));
    }

    [Test]
    public void T2()
    {
        var sut = new S02053();
        Assert.That(sut.KthDistinct(new[] {"aaa", "aa", "a"}, 1), Is.EqualTo("aaa"));
    }

    [Test]
    public void T3()
    {
        var sut = new S02053();
        Assert.That(sut.KthDistinct(new[] {"a", "b", "a"}, 3), Is.EqualTo(""));
    }
}