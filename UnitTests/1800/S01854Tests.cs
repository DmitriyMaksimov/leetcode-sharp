using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01854Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01854();
        Assert.That(sut.MaximumPopulation([[1993, 1999], [2000, 2010]]), Is.EqualTo(1993));
    }

    [Test]
    public void T2()
    {
        var sut = new S01854();
        Assert.That(sut.MaximumPopulation([[1950, 1961], [1960, 1971], [1970, 1981]]), Is.EqualTo(1960));
    }
}