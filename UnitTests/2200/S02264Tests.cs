using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02264Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02264();
        sut.LargestGoodInteger("6777133339").Should().Be("777");
    }

    [Test]
    public void T2()
    {
        var sut = new S02264();
        sut.LargestGoodInteger("2300019").Should().Be("000");
    }

    [Test]
    public void T3()
    {
        var sut = new S02264();
        sut.LargestGoodInteger("42352338").Should().Be("");
    }
}