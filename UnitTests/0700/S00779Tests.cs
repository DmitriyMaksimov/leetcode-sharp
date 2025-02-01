using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00779Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00779();
        Assert.That(sut.KthGrammar(1, 1), Is.EqualTo(0));
    }

    [Test]
    public void T2()
    {
        var sut = new S00779();
        Assert.That(sut.KthGrammar(2, 1), Is.EqualTo(0));
    }

    [Test]
    public void T3()
    {
        var sut = new S00779();
        Assert.That(sut.KthGrammar(2, 2), Is.EqualTo(1));
    }
}