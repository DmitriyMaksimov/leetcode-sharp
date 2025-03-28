using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02503Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02503();
        Assert.That(sut.MaxPoints([[1, 2, 3], [2, 5, 7], [3, 5, 1]], [5, 6, 2]), Is.EqualTo([5, 8, 1]));
    }

    [Test]
    public void T2()
    {
        var sut = new S02503();
        Assert.That(sut.MaxPoints([[5, 2, 1], [1, 1, 2]], [3]), Is.EqualTo([0]));
    }
}
