using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02049Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02049();
        Assert.That(sut.CountHighestScoreNodes([-1, 2, 0, 2, 0]), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S02049();
        Assert.That(sut.CountHighestScoreNodes([-1, 2, 0]), Is.EqualTo(2));
    }
}
