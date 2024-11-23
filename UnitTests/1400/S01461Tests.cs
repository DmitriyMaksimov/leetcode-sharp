using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01461Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01461();
        sut.HasAllCodes("00110110", 2).Should().BeTrue();
    }

    [Test]
    public void T2()
    {
        var sut = new S01461();
        sut.HasAllCodes("0110", 1).Should().BeTrue();
    }

    [Test]
    public void T3()
    {
        var sut = new S01461();
        sut.HasAllCodes("0110", 2).Should().BeFalse();
    }
}
