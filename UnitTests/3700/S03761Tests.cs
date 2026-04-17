using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03761))]
public class S03761Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03761();
        Assert.That(sut.MinMirrorPairDistance([12, 21, 45, 33, 54]), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S03761();
        Assert.That(sut.MinMirrorPairDistance([120, 21]), Is.EqualTo(1));
    }

    [Test]
    public void T3()
    {
        var sut = new S03761();
        Assert.That(sut.MinMirrorPairDistance([21, 120]), Is.EqualTo(-1));
    }
}