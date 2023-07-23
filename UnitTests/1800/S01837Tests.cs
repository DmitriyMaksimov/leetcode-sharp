using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01837Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01837();
        sut.SumBase(34, 6).Should().Be(9);
    }

    [Test]
    public void T2()
    {
        var sut = new S01837();
        sut.SumBase(10, 10).Should().Be(1);
    }
}