using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02864Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02864();
        sut.MaximumOddBinaryNumber("010").Should().Be("001");
    }

    [Test]
    public void T2()
    {
        var sut = new S02864();
        sut.MaximumOddBinaryNumber("0101").Should().Be("1001");
    }
}