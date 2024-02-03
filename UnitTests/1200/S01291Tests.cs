using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01291Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01291();
        sut.SequentialDigits(100, 300).Should().Equal(123, 234);
    }

    [Test]
    public void T2()
    {
        var sut = new S01291();
        sut.SequentialDigits(1000, 13000).Should().Equal(1234, 2345, 3456, 4567, 5678, 6789, 12345);
    }
}