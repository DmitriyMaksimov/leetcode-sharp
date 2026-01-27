using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03650))]
public class S03650Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03650();
        Assert.That(sut.MinCost(4, [[0, 1, 3], [3, 1, 1], [2, 3, 4], [0, 2, 2]]), Is.EqualTo(5));
    }

    [Test]
    public void T2()
    {
        var sut = new S03650();
        Assert.That(sut.MinCost(4, [[0, 2, 1], [2, 1, 1], [1, 3, 1], [2, 3, 3]]), Is.EqualTo(3));
    }
}