using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03380Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03380();
        Assert.That(sut.MaxRectangleArea([[1, 1], [1, 3], [3, 1], [3, 3]]), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S03380();
        Assert.That(sut.MaxRectangleArea([[1, 1], [1, 3], [3, 1], [3, 3], [2, 2]]), Is.EqualTo(-1));
    }

    [Test]
    public void T3()
    {
        var sut = new S03380();
        Assert.That(sut.MaxRectangleArea([[1, 1], [1, 3], [3, 1], [3, 3], [1, 2], [3, 2]]), Is.EqualTo(2));
    }
}
