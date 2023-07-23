using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02272Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02272();
        sut.LargestVariance("aababbb").Should().Be(3);
    }

    [Test]
    public void T2()
    {
        var sut = new S02272();
        sut.LargestVariance("abcde").Should().Be(0);
    }
}