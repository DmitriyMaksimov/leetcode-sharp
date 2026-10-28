using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03882))]
public class S03882Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03882();
        Assert.That(sut.MinCost([[1, 2], [3, 4]]), Is.EqualTo(6));
    }

    [Test]
    public void T2()
    {
        var sut = new S03882();
        Assert.That(sut.MinCost([[6, 7], [5, 8]]), Is.EqualTo(9));
    }

    [Test]
    public void T3()
    {
        var sut = new S03882();
        Assert.That(sut.MinCost([[2, 7, 5]]), Is.Zero);
    }
}