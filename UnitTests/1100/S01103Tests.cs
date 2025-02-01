using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01103Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01103();
        Assert.That(sut.DistributeCandies(7, 4), Is.EqualTo((int[]) [1, 2, 3, 1]));
    }

    [Test]
    public void T2()
    {
        var sut = new S01103();
        Assert.That(sut.DistributeCandies(10, 3), Is.EqualTo((int[]) [5, 2, 3]));
    }
}