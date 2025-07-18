using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S02163))]
public class S02163Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02163();
        Assert.That(sut.MinimumDifference([3, 1, 2]), Is.EqualTo(-1));
    }

    [Test]
    public void T2()
    {
        var sut = new S02163();
        Assert.That(sut.MinimumDifference([7, 9, 5, 8, 1, 3]), Is.EqualTo(1));
    }
}