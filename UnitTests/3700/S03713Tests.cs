using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03713))]
public class S03713Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03713();
        Assert.That(sut.LongestBalanced("abbac"), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S03713();
        Assert.That(sut.LongestBalanced("zzabccy"), Is.EqualTo(4));
    }

    [Test]
    public void T3()
    {
        var sut = new S03713();
        Assert.That(sut.LongestBalanced("aba"), Is.EqualTo(2));
    }
}