using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03794))]
public class S03794Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03794();
        Assert.That(sut.ReversePrefix("abcd", 2), Is.EqualTo("bacd"));
    }

    [Test]
    public void T2()
    {
        var sut = new S03794();
        Assert.That(sut.ReversePrefix("xyz", 3), Is.EqualTo("zyx"));
    }

    [Test]
    public void T3()
    {
        var sut = new S03794();
        Assert.That(sut.ReversePrefix("hey", 1), Is.EqualTo("hey"));
    }
}