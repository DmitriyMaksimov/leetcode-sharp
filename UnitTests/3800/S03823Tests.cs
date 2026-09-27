using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03823))]
public class S03823Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03823();
        Assert.That(sut.ReverseByType(")ebc#da@f("), Is.EqualTo("(fad@cb#e)"));
    }

    [Test]
    public void T2()
    {
        var sut = new S03823();
        Assert.That(sut.ReverseByType("z"), Is.EqualTo("z"));
    }

    [Test]
    public void T3()
    {
        var sut = new S03823();
        Assert.That(sut.ReverseByType("!@#$%^&*()"), Is.EqualTo(")(*&^%$#@!"));
    }
}