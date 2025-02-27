using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00873Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00873();
        Assert.That(sut.LenLongestFibSubseq([1, 2, 3, 4, 5, 6, 7, 8]), Is.EqualTo(5));
    }

    [Test]
    public void T2()
    {
        var sut = new S00873();
        Assert.That(sut.LenLongestFibSubseq([1, 3, 7, 11, 12, 14, 18]), Is.EqualTo(3));
    }
}
