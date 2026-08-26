using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S02904))]
public class S02904Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02904();
        Assert.That(sut.ShortestBeautifulSubstring("100011001", 3), Is.EqualTo("11001"));
    }

    [Test]
    public void T2()
    {
        var sut = new S02904();
        Assert.That(sut.ShortestBeautifulSubstring("1011", 2), Is.EqualTo("11"));
    }

    [Test]
    public void T3()
    {
        var sut = new S02904();
        Assert.That(sut.ShortestBeautifulSubstring("000", 1), Is.EqualTo(""));
    }
}