using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03774))]
public class S03774Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03774();
        Assert.That(sut.AbsDifference([5, 2, 2, 4], 2), Is.EqualTo(5));
    }

    [Test]
    public void T2()
    {
        var sut = new S03774();
        Assert.That(sut.AbsDifference([100], 1), Is.Zero);
    }
}