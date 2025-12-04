using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S02211))]
public class S02211Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02211();
        Assert.That(sut.CountCollisions("RLRSLL"), Is.EqualTo(5));
    }

    [Test]
    public void T2()
    {
        var sut = new S02211();
        Assert.That(sut.CountCollisions("LLRR"), Is.EqualTo(0));
    }
}