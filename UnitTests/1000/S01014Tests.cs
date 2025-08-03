using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01014Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01014();
        Assert.That(sut.MaxScoreSightseeingPair([8, 1, 5, 2, 6]), Is.EqualTo(11));
    }

    [Test]
    public void T2()
    {
        var sut = new S01014();
        Assert.That(sut.MaxScoreSightseeingPair([1, 2]), Is.EqualTo(2));
    }
}