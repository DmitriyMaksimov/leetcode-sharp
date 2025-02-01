using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00139Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00139();
        Assert.That(sut.WordBreak("leetcode", new List<string> {"leet", "code"}), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S00139();
        Assert.That(sut.WordBreak("applepenapple", new List<string> {"apple", "pen"}), Is.True);
    }

    [Test]
    public void T3()
    {
        var sut = new S00139();
        Assert.That(sut.WordBreak("catsandog", new List<string> {"cats", "dog", "sand", "and", "cat"}), Is.False);
    }

    [Test]
    public void T4()
    {
        var sut = new S00139();
        Assert.That(sut.WordBreak("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaab",
            new List<string> {"a","aa","aaa","aaaa","aaaaa","aaaaaa","aaaaaaa","aaaaaaaa","aaaaaaaaa","aaaaaaaaaa"}), Is.False);
    }
}
