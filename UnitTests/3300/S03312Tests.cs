using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03312))]
public class S03312Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03312();
        Assert.That(sut.GcdValues([2, 3, 4], [0, 2, 2]), Is.EqualTo([1, 2, 2]));
    }

    [Test]
    public void T2()
    {
        var sut = new S03312();
        Assert.That(sut.GcdValues([4, 4, 2, 1], [5, 3, 1, 0]), Is.EqualTo([4, 2, 1, 1]));
    }

    [Test]
    public void T3()
    {
        var sut = new S03312();
        Assert.That(sut.GcdValues([2, 2], [0, 0]), Is.EqualTo([2, 2]));
    }
}