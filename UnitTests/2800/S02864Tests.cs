using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02864Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02864();
        Assert.That(sut.MaximumOddBinaryNumber("010"), Is.EqualTo("001"));
    }

    [Test]
    public void T2()
    {
        var sut = new S02864();
        Assert.That(sut.MaximumOddBinaryNumber("0101"), Is.EqualTo("1001"));
    }
}