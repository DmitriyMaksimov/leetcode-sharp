using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01961Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01961();
        sut.IsPrefixString("iloveleetcode", new[] {"i", "love", "leetcode", "apples"}).Should().BeTrue();
    }

    [Test]
    public void T2()
    {
        var sut = new S01961();
        sut.IsPrefixString("iloveleetcode", new[] {"apples", "i", "love", "leetcode"}).Should().BeFalse();
    }
}