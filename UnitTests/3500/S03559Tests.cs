using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03559))]
public class S03559Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03559();
        Assert.That(sut.AssignEdgeWeights([[1, 2]], [[1, 1], [1, 2]]), Is.EqualTo([0, 1]));
    }

    [Test]
    public void T2()
    {
        var sut = new S03559();
        Assert.That(sut.AssignEdgeWeights([[1, 2], [1, 3], [3, 4], [3, 5]], [[1, 4], [3, 4], [2, 5]]), Is.EqualTo([2, 1, 4]));
    }
}