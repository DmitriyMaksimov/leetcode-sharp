using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S00955))]
public class S00955Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00955();
        Assert.That(sut.MinDeletionSize(["ca", "bb", "ac"]), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S00955();
        Assert.That(sut.MinDeletionSize(["xc", "yb", "za"]), Is.Zero);
    }

    [Test]
    public void T3()
    {
        var sut = new S00955();
        Assert.That(sut.MinDeletionSize(["zyx", "wvu", "tsr"]), Is.EqualTo(3));
    }
}