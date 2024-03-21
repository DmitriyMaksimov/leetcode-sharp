using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00995Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00995();
        sut.MinKBitFlips([0, 1, 0], 1).Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S00995();
        sut.MinKBitFlips([1, 1, 0], 2).Should().Be(-1);
    }

    [Test]
    public void T3()
    {
        var sut = new S00995();
        sut.MinKBitFlips([0, 0, 0, 1, 0, 1, 1, 0], 3).Should().Be(3);
    }
}