using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03625))]
public class S03625Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03625();
        Assert.That(sut.CountTrapezoids([[-3, 2], [3, 0], [2, 3], [3, 2], [2, -3]]), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S03625();
        Assert.That(sut.CountTrapezoids([[0, 0], [1, 0], [0, 1], [2, 1]]), Is.EqualTo(1));
    }
}