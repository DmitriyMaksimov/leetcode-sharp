using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03619))]
public class S03619Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03619();
        Assert.That(
            sut.CountIslands([[0, 2, 1, 0, 0], [0, 5, 0, 0, 5], [0, 0, 1, 0, 0], [0, 1, 4, 7, 0], [0, 2, 0, 0, 8]], 5),
            Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S03619();
        Assert.That(sut.CountIslands([[3, 0, 3, 0], [0, 3, 0, 3], [3, 0, 3, 0]], 3), Is.EqualTo(6));
    }
}