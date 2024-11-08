using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01209Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01209();
        sut.RemoveDuplicates("abcd", 2).Should().Be("abcd");
    }

    [Test]
    public void T2()
    {
        var sut = new S01209();
        sut.RemoveDuplicates("deeedbbcccbdaa", 3).Should().Be("aa");
    }

    [Test]
    public void T3()
    {
        var sut = new S01209();
        sut.RemoveDuplicates("pbbcggttciiippooaais", 2).Should().Be("ps");
    }
}