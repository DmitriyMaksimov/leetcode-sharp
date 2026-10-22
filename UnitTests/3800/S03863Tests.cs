using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03863))]
public class S03863Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03863();
        Assert.That(sut.MinOperations("dog"), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S03863();
        Assert.That(sut.MinOperations("card"), Is.EqualTo(2));
    }

    [Test]
    public void T3()
    {
        var sut = new S03863();
        Assert.That(sut.MinOperations("gf"), Is.EqualTo(-1));
    }
}