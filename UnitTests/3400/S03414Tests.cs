using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03414))]
public class S03414Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03414();
        Assert.That(sut.MaximumWeight([[1, 3, 2], [4, 5, 2], [1, 5, 5], [6, 9, 3], [6, 7, 1], [8, 9, 1]]), Is.EqualTo([2, 3]));
    }

    [Test]
    public void T2()
    {
        var sut = new S03414();
        Assert.That(sut.MaximumWeight([[5, 8, 1], [6, 7, 7], [4, 7, 3], [9, 10, 6], [7, 8, 2], [11, 14, 3], [3, 5, 5]]), Is.EqualTo([1, 3, 5, 6]));
    }
}