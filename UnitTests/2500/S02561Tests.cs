using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S02561))]
public class S02561Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02561();
        Assert.That(sut.MinCost([4, 2, 2, 2], [1, 4, 1, 2]), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S02561();
        Assert.That(sut.MinCost([2, 3, 4, 1], [3, 2, 5, 1]), Is.EqualTo(-1));
    }
}