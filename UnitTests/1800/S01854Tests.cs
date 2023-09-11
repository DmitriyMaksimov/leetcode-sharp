using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01854Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01854();
        sut.MaximumPopulation(new[] {new[] {1993, 1999}, new[] {2000, 2010}}).Should().Be(1993);
    }

    [Test]
    public void T2()
    {
        var sut = new S01854();
        sut.MaximumPopulation(new[] {new[] {1950, 1961}, new[] {1960, 1971}, new[] {1970, 1981}}).Should().Be(1960);
    }
}