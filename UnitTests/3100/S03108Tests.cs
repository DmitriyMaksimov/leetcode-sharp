using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03108Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03108();
        Assert.That(sut.MinimumCost(5, [[0, 1, 7], [1, 3, 7], [1, 2, 1]], [[0, 3], [3, 4]]), Is.EqualTo([1, -1]));
    }

    [Test]
    public void T2()
    {
        var sut = new S03108();
        Assert.That(sut.MinimumCost(3, [[0, 2, 7], [0, 1, 15], [1, 2, 6], [1, 2, 1]], [[1, 2]]), Is.EqualTo([0]));
    }
}
