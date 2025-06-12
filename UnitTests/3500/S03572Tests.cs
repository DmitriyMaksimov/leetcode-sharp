using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03572))]
public class S03572Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03572();
        Assert.That(sut.MaxSumDistinctTriplet([1, 2, 1, 3, 2], [5, 3, 4, 6, 2]), Is.EqualTo(14));
    }

    [Test]
    public void T2()
    {
        var sut = new S03572();
        Assert.That(sut.MaxSumDistinctTriplet([1, 2, 1, 2], [4, 5, 6, 7]), Is.EqualTo(-1));
    }
}
