using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01009Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01009();
        sut.BitwiseComplement(5).Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S01009();
        sut.BitwiseComplement(7).Should().Be(0);
    }

    [Test]
    public void T3()
    {
        var sut = new S01009();
        sut.BitwiseComplement(10).Should().Be(5);
    }
}