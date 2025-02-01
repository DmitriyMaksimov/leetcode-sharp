using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03010Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03010();
        Assert.That(sut.MinimumCost([1, 2, 3, 12]), Is.EqualTo(6));
    }

    [Test]
    public void T2()
    {
        var sut = new S03010();
        Assert.That(sut.MinimumCost([5, 4, 3]), Is.EqualTo(12));
    }

    [Test]
    public void T3()
    {
        var sut = new S03010();
        Assert.That(sut.MinimumCost([10, 3, 1, 1]), Is.EqualTo(12));
    }

    [Test]
    public void T4()
    {
        var sut = new S03010();
        Assert.That(sut.MinimumCost([1, 6, 1, 5]), Is.EqualTo(7));
    }
}