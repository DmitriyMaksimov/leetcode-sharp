using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03075Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03075();
        Assert.That(sut.MaximumHappinessSum([1, 2, 3], 2), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S03075();
        Assert.That(sut.MaximumHappinessSum([1, 1, 1, 1], 2), Is.EqualTo(1));
    }

    [Test]
    public void T3()
    {
        var sut = new S03075();
        Assert.That(sut.MaximumHappinessSum([2, 3, 4, 5], 1), Is.EqualTo(5));
    }

    [Test]
    public void T4()
    {
        var sut = new S03075();
        Assert.That(sut.MaximumHappinessSum([12, 1, 42], 3), Is.EqualTo(53));
    }
}