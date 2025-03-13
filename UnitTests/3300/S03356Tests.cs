using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03356Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03356();
        Assert.That(sut.MinZeroArray([2, 0, 2], [[0, 2, 1], [0, 2, 1], [1, 1, 3]]), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S03356();
        Assert.That(sut.MinZeroArray([4, 3, 2, 1], [[1, 3, 2], [0, 2, 1]]), Is.EqualTo(-1));
    }
}
