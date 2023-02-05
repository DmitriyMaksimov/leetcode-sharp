using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S000438Tests
{
    [Test]
    public void T1()
    {
        var sut = new S000438();
        sut.FindAnagrams("cbaebabacd", "abc").Should().BeEquivalentTo(new[] {0, 6});
    }

    [Test]
    public void T2()
    {
        var sut = new S000438();
        sut.FindAnagrams("abab", "ab").Should().BeEquivalentTo(new[] {0, 1, 2});
    }

    [Test]
    public void T3()
    {
        var sut = new S000438();
        sut.FindAnagrams("aaaaaaaaaa", "aaaaaaaaaaaaa").Should().BeEmpty();
    }
}