using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S00757))]
public class S00757Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00757();
        Assert.That(sut.IntersectionSizeTwo([[1, 3], [3, 7], [8, 9]]), Is.EqualTo(5));
    }

    [Test]
    public void T2()
    {
        var sut = new S00757();
        Assert.That(sut.IntersectionSizeTwo([[1, 3], [1, 4], [2, 5], [3, 5]]), Is.EqualTo(3));
    }

    [Test]
    public void T3()
    {
        var sut = new S00757();
        Assert.That(sut.IntersectionSizeTwo([[1, 2], [2, 3], [2, 4], [4, 5]]), Is.EqualTo(5));
    }
}