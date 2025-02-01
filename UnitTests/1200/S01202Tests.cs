using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01202Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01202();
        Assert.That(sut.SmallestStringWithSwaps("dcab", [[0, 3], [1, 2]]), Is.EqualTo("bacd"));
    }

    [Test]
    public void T2()
    {
        var sut = new S01202();
        Assert.That(sut.SmallestStringWithSwaps("dcab", [[0, 3], [1, 2], [0, 2]]), Is.EqualTo("abcd"));
    }

    [Test]
    public void T3()
    {
        var sut = new S01202();
        Assert.That(sut.SmallestStringWithSwaps("cba", [[0, 1], [1, 2]]), Is.EqualTo("abc"));
    }
}
