using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S00849))]
public class S00849Test
{
    [Test]
    public void T1()
    {
        var sut = new S00849();
        Assert.That(sut.MaxDistToClosest([1, 0, 0, 0, 1, 0, 1]), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S00849();
        Assert.That(sut.MaxDistToClosest([1, 0, 0, 0]), Is.EqualTo(3));
    }

    [Test]
    public void T3()
    {
        var sut = new S00849();
        Assert.That(sut.MaxDistToClosest([0, 1]), Is.EqualTo(1));
    }
}
