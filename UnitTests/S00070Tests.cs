using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00070Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00070();
        sut.ClimbStairs(2).Should().Be(2);
    }
    [Test]
    public void T2()
    {
        var sut = new S00070();
        sut.ClimbStairs(3).Should().Be(3);
    }
}