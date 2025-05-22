using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03362))]
public class S03362Test
{
    [Test]
    public void T1()
    {
        var sut = new S03362();
        Assert.That(sut.MaxRemoval([2, 0, 2], [[0, 2], [0, 2], [1, 1]]), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S03362();
        Assert.That(sut.MaxRemoval([1, 1, 1, 1], [[1, 3], [0, 2], [1, 3], [1, 2]]), Is.EqualTo(2));
    }

    [Test]
    public void T3()
    {
        var sut = new S03362();
        Assert.That(sut.MaxRemoval([1, 2, 3, 4], [[0, 3]]), Is.EqualTo(-1));
    }
}
