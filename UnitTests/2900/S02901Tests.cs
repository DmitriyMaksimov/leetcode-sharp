using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S02901))]
public class S02901Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02901();
        Assert.That(sut.GetWordsInLongestSubsequence(["bab", "dab", "cab"], [1, 2, 2]), Is.EqualTo(["bab", "dab"]));
    }

    [Test]
    public void T2()
    {
        var sut = new S02901();
        Assert.That(sut.GetWordsInLongestSubsequence(["a", "b", "c", "d"], [1, 2, 3, 4]), Is.EqualTo(["a", "b", "c", "d"]));
    }
}
