using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03525))]
public class S03525Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03525();
        Assert.That(sut.ResultArray([1, 2, 3, 4, 5], 3, [[2, 2, 0, 2], [3, 3, 3, 0], [0, 1, 0, 1]]), Is.EqualTo([2, 2, 2]));
    }

    [Test]
    public void T2()
    {
        var sut = new S03525();
        Assert.That(sut.ResultArray([1, 2, 4, 8, 16, 32], 4, [[0, 2, 0, 2], [0, 2, 0, 1]]), Is.EqualTo([1, 0]));
    }

    [Test]
    public void T3()
    {
        var sut = new S03525();
        Assert.That(sut.ResultArray([1, 1, 2, 1, 1], 2, [[2, 1, 0, 1]]), Is.EqualTo([5]));
    }
}