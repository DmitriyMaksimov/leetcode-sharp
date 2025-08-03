using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01961Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01961();
        Assert.That(sut.IsPrefixString("iloveleetcode", ["i", "love", "leetcode", "apples"]), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S01961();
        Assert.That(sut.IsPrefixString("iloveleetcode", ["apples", "i", "love", "leetcode"]), Is.False);
    }
}
