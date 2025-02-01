using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03249Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03249();
        Assert.That(sut.CountGoodNodes([[0, 1], [0, 2], [1, 3], [1, 4], [2, 5], [2, 6]]), Is.EqualTo(7));
    }

    [Test]
    public void T2()
    {
        var sut = new S03249();
        Assert.That(sut.CountGoodNodes([[0, 1], [1, 2], [2, 3], [3, 4], [0, 5], [1, 6], [2, 7], [3, 8]]), Is.EqualTo(6));
    }

    [Test]
    public void T3()
    {
        var sut = new S03249();
        Assert.That(sut.CountGoodNodes([[0, 1], [1, 2], [1, 3], [1, 4], [0, 5], [5, 6], [6, 7], [7, 8], [0, 9], [9, 10], [9, 12], [10, 11]]), Is.EqualTo(12));
    }
}
