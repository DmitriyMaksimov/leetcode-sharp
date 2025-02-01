using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00689Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00689();
        Assert.That(sut.MaxSumOfThreeSubarrays([1, 2, 1, 2, 6, 7, 5, 1], 2), Is.EqualTo((int[]) [0, 3, 5]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00689();
        Assert.That(sut.MaxSumOfThreeSubarrays([1, 2, 1, 2, 1, 2, 1, 2, 1], 2), Is.EqualTo((int[]) [0, 2, 4]));
    }
}
