using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03068Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03068();
        Assert.That(sut.MaximumValueSum([1, 2, 1], 3, [[0, 1], [0, 2]]), Is.EqualTo(6));
    }

    [Test]
    public void T2()
    {
        var sut = new S03068();
        Assert.That(sut.MaximumValueSum([2, 3], 7, [[0, 1]]), Is.EqualTo(9));
    }

    [Test]
    public void T3()
    {
        var sut = new S03068();
        Assert.That(sut.MaximumValueSum([7, 7, 7, 7, 7, 7], 3, [[0, 1], [0, 2], [0, 3], [0, 4], [0, 5]]), Is.EqualTo(42));
    }
}