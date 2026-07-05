using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S01301))]
public class S01301Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01301();
        Assert.That(sut.PathsWithMaxScore(["E23", "2X2", "12S"]), Is.EqualTo([7, 1]));
    }

    [Test]
    public void T2()
    {
        var sut = new S01301();
        Assert.That(sut.PathsWithMaxScore(["E12", "1X1", "21S"]), Is.EqualTo([4, 2]));
    }

    [Test]
    public void T3()
    {
        var sut = new S01301();
        Assert.That(sut.PathsWithMaxScore(["E11", "XXX", "11S"]), Is.EqualTo([0, 0]));
    }
}