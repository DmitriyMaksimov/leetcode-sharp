using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01090Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01090();
        Assert.That(sut.LargestValsFromLabels([5, 4, 3, 2, 1], [1, 1, 2, 2, 3], 3, 1), Is.EqualTo(9));
    }

    [Test]
    public void T2()
    {
        var sut = new S01090();
        Assert.That(sut.LargestValsFromLabels([5, 4, 3, 2, 1], [1, 3, 3, 3, 2], 3, 2), Is.EqualTo(12));
    }

    [Test]
    public void T3()
    {
        var sut = new S01090();
        Assert.That(sut.LargestValsFromLabels([9, 8, 8, 7, 6], [0, 0, 0, 1, 1], 3, 1), Is.EqualTo(16));
    }
}
