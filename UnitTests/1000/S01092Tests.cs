using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01092Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01092();
        Assert.That(sut.ShortestCommonSupersequence("abac", "cab"), Is.EqualTo("cabac"));
    }

    [Test]
    public void T2()
    {
        var sut = new S01092();
        Assert.That(sut.ShortestCommonSupersequence("aaaaaaaa", "aaaaaaaa"), Is.EqualTo("aaaaaaaa"));
    }
}
