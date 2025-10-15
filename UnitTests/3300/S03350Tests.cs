using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03350))]
public class S03350Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03350();
        Assert.That(sut.MaxIncreasingSubarrays([2, 5, 7, 8, 9, 2, 3, 4, 3, 1]), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S03350();
        Assert.That(sut.MaxIncreasingSubarrays([1, 2, 3, 4, 4, 4, 4, 5, 6, 7]), Is.EqualTo(2));
    }
}