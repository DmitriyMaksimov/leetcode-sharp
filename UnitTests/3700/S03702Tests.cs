using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03702))]
public class S03702Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03702();
        Assert.That(sut.LongestSubsequence([1, 2, 3]), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S03702();
        Assert.That(sut.LongestSubsequence([2, 3, 4]), Is.EqualTo(3));
    }
}