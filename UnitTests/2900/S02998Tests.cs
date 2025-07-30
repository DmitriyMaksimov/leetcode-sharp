using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S02998))]
public class S02998Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02998();
        Assert.That(sut.MinimumOperationsToMakeEqual(26, 1), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S02998();
        Assert.That(sut.MinimumOperationsToMakeEqual(54, 2), Is.EqualTo(4));
    }

    [Test]
    public void T3()
    {
        var sut = new S02998();
        Assert.That(sut.MinimumOperationsToMakeEqual(25, 30), Is.EqualTo(5));
    }
}