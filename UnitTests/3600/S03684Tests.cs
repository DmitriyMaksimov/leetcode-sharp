using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03684))]
public class S03684Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03684();
        Assert.That(sut.MaxKDistinct([84, 93, 100, 77, 90], 3), Is.EqualTo([100, 93, 90]));
    }

    [Test]
    public void T2()
    {
        var sut = new S03684();
        Assert.That(sut.MaxKDistinct([84, 93, 100, 77, 93], 3), Is.EqualTo([100, 93, 84]));
    }

    [Test]
    public void T3()
    {
        var sut = new S03684();
        Assert.That(sut.MaxKDistinct([1, 1, 1, 2, 2, 2], 6), Is.EqualTo([2, 1]));
    }
}