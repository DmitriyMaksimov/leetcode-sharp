using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00762Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00762();
        sut.CountPrimeSetBits(6, 10).Should().Be(4);
    }

    [Test]
    public void T2()
    {
        var sut = new S00762();
        sut.CountPrimeSetBits(10, 15).Should().Be(5);
    }
}