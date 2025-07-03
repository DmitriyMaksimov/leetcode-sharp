using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03275))]
public class S03275Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03275();
        Assert.That(sut.ResultsArray([[1, 2], [3, 4], [2, 3], [-3, 0]], 2), Is.EqualTo([-1, 7, 5, 3]));
    }

    [Test]
    public void T2()
    {
        var sut = new S03275();
        Assert.That(sut.ResultsArray([[5, 5], [4, 4], [3, 3]], 1), Is.EqualTo([10, 8, 6]));
    }
}