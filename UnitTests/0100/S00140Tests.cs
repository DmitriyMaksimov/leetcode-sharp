using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00140Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00140();
        sut.WordBreak("catsanddog", ["cat", "cats", "and", "sand", "dog"]).Should().BeEquivalentTo(["cats and dog", "cat sand dog"]);
    }

    [Test]
    public void T2()
    {
        var sut = new S00140();
        sut.WordBreak("pineapplepenapple", ["apple", "pen", "applepen", "pine", "pineapple"]).Should()
            .BeEquivalentTo(["pine apple pen apple", "pineapple pen apple", "pine applepen apple"]);
    }

    [Test]
    public void T3()
    {
        var sut = new S00140();
        sut.WordBreak("catsandog", ["cats", "dog", "sand", "and", "cat"]).Should().BeEmpty();
    }
}