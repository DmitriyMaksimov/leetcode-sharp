using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01903Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01903();
        sut.LargestOddNumber("52").Should().Be("5");
    }

    [Test]
    public void T2()
    {
        var sut = new S01903();
        sut.LargestOddNumber("4206").Should().Be("");
    }

    [Test]
    public void T3()
    {
        var sut = new S01903();
        sut.LargestOddNumber("35427").Should().Be("35427");
    }
}