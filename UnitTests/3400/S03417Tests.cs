using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03417Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03417();
        Assert.That(sut.ZigzagTraversal([[1, 2], [3, 4]]), Is.EqualTo([1, 4]));
    }

    [Test]
    public void T2()
    {
        var sut = new S03417();
        Assert.That(sut.ZigzagTraversal([[2, 1], [2, 1], [2, 1]]), Is.EqualTo([2, 1, 2]));
    }

    [Test]
    public void T3()
    {
        var sut = new S03417();
        Assert.That(sut.ZigzagTraversal([[1, 2, 3], [4, 5, 6], [7, 8, 9]]), Is.EqualTo([1, 3, 5, 7, 9]));
    }
}
