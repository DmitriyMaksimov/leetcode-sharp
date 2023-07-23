using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02220Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02220();
        sut.MinBitFlips(10, 7).Should().Be(3);
    }

    [Test]
    public void T2()
    {
        var sut = new S02220();
        sut.MinBitFlips(3, 4).Should().Be(3);
    }
}