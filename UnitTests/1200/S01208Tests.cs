using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01208Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01208();
        sut.EqualSubstring("abcd", "bcdf", 3).Should().Be(3);
    }

    [Test]
    public void T2()
    {
        var sut = new S01208();
        sut.EqualSubstring("abcd", "cdef", 3).Should().Be(1);
    }

    [Test]
    public void T3()
    {
        var sut = new S01208();
        sut.EqualSubstring("abcd", "acde", 0).Should().Be(1);
    }
}