using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03693))]
public class S03693Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03693();
        Assert.That(sut.ClimbStairs(4, [1, 2, 3, 4]), Is.EqualTo(13));
    }

    [Test]
    public void T2()
    {
        var sut = new S03693();
        Assert.That(sut.ClimbStairs(4, [5, 1, 6, 2]), Is.EqualTo(11));
    }

    [Test]
    public void T3()
    {
        var sut = new S03693();
        Assert.That(sut.ClimbStairs(3, [9, 8, 3]), Is.EqualTo(12));
    }
}