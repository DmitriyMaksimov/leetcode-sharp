using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03992))]
public class S03992Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03992();
        Assert.That(sut.RearrangeString("aabc", 'a', 'c'), Is.EqualTo("bcaa"));
    }

    [Test]
    public void T2()
    {
        var sut = new S03992();
        Assert.That(sut.RearrangeString("dcab", 'd', 'b'), Is.EqualTo("cabd"));
    }

    [Test]
    public void T3()
    {
        var sut = new S03992();
        Assert.That(sut.RearrangeString("axe", 'o', 'x'), Is.EqualTo("aex"));
    }
}