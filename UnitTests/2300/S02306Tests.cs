using leetcode_sharp;

namespace UnitTests;

public class S02306Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02306();
        Assert.That(sut.DistinctNames(new[] {"coffee", "donuts", "time", "toffee"}), Is.EqualTo(6));
    }

    [Test]
    public void T2()
    {
        var sut = new S02306();
        Assert.That(sut.DistinctNames(new[] {"lack", "back"}), Is.EqualTo(0));
    }
}