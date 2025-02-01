using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01209Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01209();
        Assert.That(sut.RemoveDuplicates("abcd", 2), Is.EqualTo("abcd"));
    }

    [Test]
    public void T2()
    {
        var sut = new S01209();
        Assert.That(sut.RemoveDuplicates("deeedbbcccbdaa", 3), Is.EqualTo("aa"));
    }

    [Test]
    public void T3()
    {
        var sut = new S01209();
        Assert.That(sut.RemoveDuplicates("pbbcggttciiippooaais", 2), Is.EqualTo("ps"));
    }
}