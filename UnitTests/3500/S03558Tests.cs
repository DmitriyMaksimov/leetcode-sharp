using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03558))]
public class S03558Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03558();
        Assert.That(sut.AssignEdgeWeights([[1, 2]]), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S03558();
        Assert.That(sut.AssignEdgeWeights([[1, 2], [1, 3], [3, 4], [3, 5]]), Is.EqualTo(2));
    }
}
