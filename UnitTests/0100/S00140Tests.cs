using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00140Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00140();
        Assert.That(sut.WordBreak("catsanddog", ["cat", "cats", "and", "sand", "dog"]), Is.EquivalentTo((string[]) ["cats and dog", "cat sand dog"]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00140();
        Assert.That(sut.WordBreak("pineapplepenapple", ["apple", "pen", "applepen", "pine", "pineapple"]), Is.EquivalentTo((string[]) ["pine apple pen apple", "pineapple pen apple", "pine applepen apple"]));
    }

    [Test]
    public void T3()
    {
        var sut = new S00140();
        Assert.That(sut.WordBreak("catsandog", ["cats", "dog", "sand", "and", "cat"]), Is.Empty);
    }
}
