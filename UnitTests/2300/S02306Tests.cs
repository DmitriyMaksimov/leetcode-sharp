using leetcode_sharp;

namespace UnitTests;

public class S02306Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02306();
        Assert.That(sut.DistinctNames(["coffee", "donuts", "time", "toffee"]), Is.EqualTo(6));
    }

    [Test]
    public void T2()
    {
        var sut = new S02306();
        Assert.That(sut.DistinctNames(["lack", "back"]), Is.EqualTo(0));
    }
}