using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00893Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00893();
        sut.NumSpecialEquivGroups(["abcd", "cdab", "cbad", "xyzz", "zzxy", "zzyx"]).Should().Be(3);
    }

    [Test]
    public void T2()
    {
        var sut = new S00893();
        sut.NumSpecialEquivGroups(["abc", "acb", "bac", "bca", "cab", "cba"]).Should().Be(3);
    }
}