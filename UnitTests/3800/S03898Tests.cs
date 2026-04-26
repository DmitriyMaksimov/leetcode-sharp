using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03898))]
public class S03898Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03898();
        Assert.That(sut.FindDegrees([[0, 1, 1], [1, 0, 1], [1, 1, 0]]), Is.EqualTo([2, 2, 2]));
    }

    [Test]
    public void T2()
    {
        var sut = new S03898();
        Assert.That(sut.FindDegrees([[0, 1, 0], [1, 0, 0], [0, 0, 0]]), Is.EqualTo([1, 1, 0]));
    }

    [Test]
    public void T3()
    {
        var sut = new S03898();
        Assert.That(sut.FindDegrees([[0]]), Is.EqualTo([0]));
    }
}