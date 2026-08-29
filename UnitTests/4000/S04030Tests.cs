using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S04030))]
public class S04030Tests
{
    [Test]
    public void T1()
    {
        var sut = new S04030();
        Assert.That(sut.IsPalindromic("ff"), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S04030();
        Assert.That(sut.IsPalindromic("leet"), Is.False);
    }

    [Test]
    public void T3()
    {
        var sut = new S04030();
        Assert.That(sut.IsPalindromic("vn"), Is.True);
    }

    [Test]
    public void T4()
    {
        var sut = new S04030();
        Assert.That(sut.IsPalindromic("a"), Is.False);
    }
}