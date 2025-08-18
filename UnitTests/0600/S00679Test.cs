using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S00679))]
public class S00679Test
{

    [Test]
    public void T1()
    {
        var sut = new S00679();
        Assert.That(sut.JudgePoint24([4,1,8,7]), Is.True);
    }
    [Test]
    public void T2()
    {
        var sut = new S00679();
        Assert.That(sut.JudgePoint24([1, 2, 1, 2]), Is.False);
    }
}