using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00893Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00893();
        Assert.That(sut.NumSpecialEquivGroups(["abcd", "cdab", "cbad", "xyzz", "zzxy", "zzyx"]), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S00893();
        Assert.That(sut.NumSpecialEquivGroups(["abc", "acb", "bac", "bca", "cab", "cba"]), Is.EqualTo(3));
    }
}