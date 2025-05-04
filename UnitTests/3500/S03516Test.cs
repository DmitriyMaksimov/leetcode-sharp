using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03516))]
public class S03516Test
{
    [Test]
    public void T1()
    {
        var sut = new S03516();
        Assert.That(sut.FindClosest(2, 7, 4), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S03516();
        Assert.That(sut.FindClosest(2, 5, 6), Is.EqualTo(2));
    }

    [Test]
    public void T3()
    {
        var sut = new S03516();
        Assert.That(sut.FindClosest(1, 5, 3), Is.EqualTo(0));
    }
}
