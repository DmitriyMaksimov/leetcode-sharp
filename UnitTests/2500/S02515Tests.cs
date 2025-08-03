using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02515Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02515();
        Assert.That(sut.ClosetTarget(["hello", "i", "am", "leetcode", "hello"], "hello", 1), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S02515();
        Assert.That(sut.ClosetTarget(["a", "b", "leetcode"], "leetcode", 0), Is.EqualTo(1));
    }

    [Test]
    public void T3()
    {
        var sut = new S02515();
        Assert.That(sut.ClosetTarget(["i", "eat", "leetcode"], "ate", 0), Is.EqualTo(-1));
    }
}