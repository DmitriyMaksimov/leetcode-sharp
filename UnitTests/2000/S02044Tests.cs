using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02044Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02044();
        Assert.That(sut.CountMaxOrSubsets([3, 1]), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S02044();
        Assert.That(sut.CountMaxOrSubsets([2, 2, 2]), Is.EqualTo(7));
    }

    [Test]
    public void T3()
    {
        var sut = new S02044();
        Assert.That(sut.CountMaxOrSubsets([3, 2, 1, 5]), Is.EqualTo(6));
    }
}