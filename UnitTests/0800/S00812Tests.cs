using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00812Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00812();
        Assert.That(sut.LargestTriangleArea([[0, 0], [0, 1], [1, 0], [0, 2], [2, 0]]), Is.EqualTo(2.0));
    }

    [Test]
    public void T2()
    {
        var sut = new S00812();
        Assert.That(sut.LargestTriangleArea([[1, 0], [0, 0], [0, 1]]), Is.EqualTo(0.5));
    }
}