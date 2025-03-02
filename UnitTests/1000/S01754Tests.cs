using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01754Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01754();
        Assert.That(sut.LargestMerge("cabaa", "bcaaa"), Is.EqualTo("cbcabaaaaa"));
    }

    [Test]
    public void T2()
    {
        var sut = new S01754();
        Assert.That(sut.LargestMerge("abcabc", "abdcaba"), Is.EqualTo("abdcabcabcaba"));
    }
}
