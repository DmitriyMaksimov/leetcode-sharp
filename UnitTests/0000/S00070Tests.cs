using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00070Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00070();
        Assert.That(sut.ClimbStairs(2), Is.EqualTo(2));
    }
    [Test]
    public void T2()
    {
        var sut = new S00070();
        Assert.That(sut.ClimbStairs(3), Is.EqualTo(3));
    }
}