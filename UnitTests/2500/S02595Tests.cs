using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02595Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02595();
        sut.EvenOddBit(17).Should().Equal(2, 0);
    }

    [Test]
    public void T2()
    {
        var sut = new S02595();
        sut.EvenOddBit(2).Should().Equal(0, 1);
    }
}