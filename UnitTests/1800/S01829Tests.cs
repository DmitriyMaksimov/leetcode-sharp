using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01829Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01829();
        Assert.That(sut.GetMaximumXor([0, 1, 1, 3], 2), Is.EqualTo((int[]) [0, 3, 2, 3]));
    }

    [Test]
    public void T2()
    {
        var sut = new S01829();
        Assert.That(sut.GetMaximumXor([2, 3, 4, 7], 3), Is.EqualTo((int[]) [5, 2, 6, 5]));
    }

    [Test]
    public void T3()
    {
        var sut = new S01829();
        Assert.That(sut.GetMaximumXor([0, 1, 2, 2, 5, 7], 3), Is.EqualTo((int[]) [4, 3, 6, 4, 6, 7]));
    }
}