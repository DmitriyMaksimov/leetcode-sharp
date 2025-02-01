using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02679Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02679();
        Assert.That(sut.MatrixSum([[7, 2, 1], [6, 4, 2], [6, 5, 3], [3, 2, 1]]), Is.EqualTo(15));
    }

    [Test]
    public void T2()
    {
        var sut = new S02679();
        Assert.That(sut.MatrixSum([[1]]), Is.EqualTo(1));
    }
}
