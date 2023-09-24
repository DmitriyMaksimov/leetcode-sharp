using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02506TTests
{
    [Test]
    public void T1()
    {
        var sut = new S02506();
        sut.SimilarPairs(new[] {"aba", "aabb", "abcd", "bac", "aabc"}).Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S02506();
        sut.SimilarPairs(new[] {"aabb", "ab", "ba"}).Should().Be(3);
    }

    [Test]
    public void T3()
    {
        var sut = new S02506();
        sut.SimilarPairs(new[] {"nba", "cba", "dba"}).Should().Be(0);
    }
}