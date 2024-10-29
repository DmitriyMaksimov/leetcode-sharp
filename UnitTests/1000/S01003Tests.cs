using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01003Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01003();
        sut.IsValid("aabcbc").Should().BeTrue();
    }

    [Test]
    public void T2()
    {
        var sut = new S01003();
        sut.IsValid("abcabcababcc").Should().BeTrue();
    }

    [Test]
    public void T3()
    {
        var sut = new S01003();
        sut.IsValid("abccba").Should().BeFalse();
    }
}
