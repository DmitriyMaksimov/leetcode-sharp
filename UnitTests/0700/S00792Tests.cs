using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00792Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00792();
        Assert.That(sut.NumMatchingSubseq("abcde", ["a", "bb", "acd", "ace"]), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S00792();
        Assert.That(sut.NumMatchingSubseq("dsahjpjauf", ["ahjpjau", "ja", "ahbwzgqnuk", "tnmlanowax"]), Is.EqualTo(2));
    }
}
