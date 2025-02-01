using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01003Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01003();
        Assert.That(sut.IsValid("aabcbc"), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S01003();
        Assert.That(sut.IsValid("abcabcababcc"), Is.True);
    }

    [Test]
    public void T3()
    {
        var sut = new S01003();
        Assert.That(sut.IsValid("abccba"), Is.False);
    }
}
