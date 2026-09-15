using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S02472))]
public class S02472Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02472();
        Assert.That(sut.MaxPalindromes("abaccdbbd", 3), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S02472();
        Assert.That(sut.MaxPalindromes("adbcda", 2), Is.Zero);
    }
}