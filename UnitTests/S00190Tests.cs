using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00190Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00190();
        sut.reverseBits(0b00000010100101000001111010011100).Should().Be(0b00111001011110000010100101000000);
    }

    [Test]
    public void T2()
    {
        var sut = new S00190();
        sut.reverseBits(0b11111111111111111111111111111101).Should().Be(0b10111111111111111111111111111111);
    }
}