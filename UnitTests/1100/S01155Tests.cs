using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01155Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01155();
        Assert.That(sut.NumRollsToTarget(1, 6, 3), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S01155();
        Assert.That(sut.NumRollsToTarget(2, 6, 7), Is.EqualTo(6));
    }

    [Test]
    public void T3()
    {
        var sut = new S01155();
        Assert.That(sut.NumRollsToTarget(30, 30, 500), Is.EqualTo(222616187));
    }
}