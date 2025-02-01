using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00748Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00748();
        Assert.That(sut.ShortestCompletingWord("1s3 PSt", new[] {"step", "steps", "stripe", "stepple"}), Is.EqualTo("steps"));
    }

    [Test]
    public void T2()
    {
        var sut = new S00748();
        Assert.That(sut.ShortestCompletingWord("1s3 456", new[] {"looks", "pest", "stew", "show"}), Is.EqualTo("pest"));
    }
}