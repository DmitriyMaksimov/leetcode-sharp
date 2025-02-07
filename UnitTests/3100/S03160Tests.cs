using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03160Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03160();
        Assert.That(sut.QueryResults(4, [[1, 4], [2, 5], [1, 3], [3, 4]]), Is.EqualTo([1, 2, 2, 3]));
    }

    [Test]
    public void T2()
    {
        var sut = new S03160();
        Assert.That(sut.QueryResults(4, [[0, 1], [1, 2], [2, 2], [3, 4], [4, 5]]), Is.EqualTo([1, 2, 2, 3, 4]));
    }
}
