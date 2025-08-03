using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00888Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00888();
        Assert.That(sut.FairCandySwap([1, 1], [2, 2]), Is.EqualTo((int[]) [1, 2]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00888();
        Assert.That(sut.FairCandySwap([1, 2], [2, 3]), Is.EqualTo((int[]) [1, 2]));
    }

    [Test]
    public void T3()
    {
        var sut = new S00888();
        Assert.That(sut.FairCandySwap([2], [1, 3]), Is.EqualTo((int[]) [2, 3]));
    }
}