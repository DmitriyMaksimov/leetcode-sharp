using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02028Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02028();
        Assert.That(sut.MissingRolls([3, 2, 4, 3], 4, 2), Is.EqualTo((int[]) [6, 6]));
    }

    [Test]
    public void T2()
    {
        var sut = new S02028();
        Assert.That(sut.MissingRolls([1, 5, 6], 3, 4), Is.EqualTo((int[]) [3, 2, 2, 2]));
    }

    [Test]
    public void T3()
    {
        var sut = new S02028();
        Assert.That(sut.MissingRolls([1, 2, 3, 4], 6, 4), Is.Empty);
    }
}
