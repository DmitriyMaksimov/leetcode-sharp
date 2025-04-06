using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03259Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03259();
        Assert.That(sut.MaxEnergyBoost([1, 3, 1], [3, 1, 1]), Is.EqualTo(5));
    }

    [Test]
    public void T2()
    {
        var sut = new S03259();
        Assert.That(sut.MaxEnergyBoost([4, 1, 1], [1, 1, 3]), Is.EqualTo(7));
    }
}
