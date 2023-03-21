using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00191Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00191();
        sut.HammingWeight(0b00000000000000000000000000001011).Should().Be(3);
    }

    [Test]
    public void T2()
    {
        var sut = new S00191();
        sut.HammingWeight(0b00000000000000000000000010000000).Should().Be(1);
    }

    [Test]
    public void T3()
    {
        var sut = new S00191();
        sut.HammingWeight(0b11111111111111111111111111111101).Should().Be(31);
    }
}