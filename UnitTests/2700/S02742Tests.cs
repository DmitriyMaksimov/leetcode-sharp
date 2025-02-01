using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02742Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02742();
        Assert.That(sut.PaintWalls(new[] {1, 2, 3, 2}, new[] {1, 2, 3, 2}), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S02742();
        Assert.That(sut.PaintWalls(new[] {2, 3, 4, 2}, new[] {1, 1, 1, 1}), Is.EqualTo(4));
    }
}