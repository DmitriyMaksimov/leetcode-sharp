using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00316Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00316();
        sut.RemoveDuplicateLetters("bcabc").Should().Be("abc");
    }

    [Test]
    public void T2()
    {
        var sut = new S00316();
        sut.RemoveDuplicateLetters("cbacdcbc").Should().Be("acdb");
    }
}