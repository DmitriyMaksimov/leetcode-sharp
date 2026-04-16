using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03488))]
public class S03488Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03488();
        Assert.That(sut.SolveQueries([1, 3, 1, 4, 1, 3, 2], [0, 3, 5]), Is.EqualTo([2, -1, 3]));
    }

    [Test]
    public void T2()
    {
        var sut = new S03488();
        Assert.That(sut.SolveQueries([1, 2, 3, 4], [0, 1, 2, 3]), Is.EqualTo([-1, -1, -1, -1]));
    }
}