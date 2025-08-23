using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03197))]
public class S03197Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03197();
        Assert.That(sut.MinimumSum([[1, 0, 1], [1, 1, 1]]), Is.EqualTo(5));
    }

    [Test]
    public void T2()
    {
        var sut = new S03197();
        Assert.That(sut.MinimumSum([[1, 0, 1, 0], [0, 1, 0, 1]]), Is.EqualTo(5));
    }
}