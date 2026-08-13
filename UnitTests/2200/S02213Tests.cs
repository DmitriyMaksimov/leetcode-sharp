using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S02213))]
public class S02213Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02213();
        Assert.That(sut.LongestRepeating("babacc", "bcb", [1, 3, 3]), Is.EqualTo([3, 3, 4]));
    }

    [Test]
    public void T2()
    {
        var sut = new S02213();
        Assert.That(sut.LongestRepeating("abyzz", "aa", [2, 1]), Is.EqualTo([2, 3]));
    }
}