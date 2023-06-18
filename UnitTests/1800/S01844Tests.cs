using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01844Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01844();
        sut.ReplaceDigits("a1c1e1").Should().Be("abcdef");
    }

    [Test]
    public void T2()
    {
        var sut = new S01844();
        sut.ReplaceDigits("a1b2c3d4e").Should().Be("abbdcfdhe");
    }
}