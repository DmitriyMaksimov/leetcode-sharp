using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00167Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00167();
        Assert.That(sut.TwoSum([2, 7, 11, 15], 9), Is.EqualTo((int[]) [1, 2]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00167();
        Assert.That(sut.TwoSum([2, 3, 4], 6), Is.EqualTo((int[]) [1, 3]));
    }

    [Test]
    public void T3()
    {
        var sut = new S00167();
        Assert.That(sut.TwoSum([-1, 0], -1), Is.EqualTo((int[]) [1, 2]));
    }

    [Test]
    public void T4()
    {
        var sut = new S00167();
        Assert.That(sut.TwoSum([5, 25, 75], 100), Is.EqualTo((int[]) [2, 3]));
    }
}