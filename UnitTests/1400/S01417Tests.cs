using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01417Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01417();
        sut.Reformat("a0b1c2").Should().Be("0a1b2c");
    }

    [Test]
    public void T2()
    {
        var sut = new S01417();
        sut.Reformat("leetcode").Should().Be("");
    }

    [Test]
    public void T3()
    {
        var sut = new S01417();
        sut.Reformat("1229857369").Should().Be("");
    }
}