using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00172Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00172();
        sut.TrailingZeroes(3).Should().Be(0);
    }

    [Test]
    public void T2()
    {
        var sut = new S00172();
        sut.TrailingZeroes(5).Should().Be(1);
    }

    [Test]
    public void T3()
    {
        var sut = new S00172();
        sut.TrailingZeroes(0).Should().Be(0);
    }
}