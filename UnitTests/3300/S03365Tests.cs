using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03365Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03365();
        sut.IsPossibleToRearrange("abcd", "cdab", 2).Should().BeTrue();
    }

    [Test]
    public void T2()
    {
        var sut = new S03365();
        sut.IsPossibleToRearrange("aabbcc", "bbaacc", 3).Should().BeTrue();
    }

    [Test]
    public void T3()
    {
        var sut = new S03365();
        sut.IsPossibleToRearrange("aabbcc", "bbaacc", 2).Should().BeFalse();
    }
}
