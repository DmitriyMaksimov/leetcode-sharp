using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03714))]
public class S03714Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03714();
        Assert.That(sut.LongestBalanced("abbac"), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S03714();
        Assert.That(sut.LongestBalanced("aabcc"), Is.EqualTo(3));
    }

    [Test]
    public void T3()
    {
        var sut = new S03714();
        Assert.That(sut.LongestBalanced("aba"), Is.EqualTo(2));
    }
}