using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02855Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02855();
        Assert.That(sut.MinimumRightShifts(new[] {3, 4, 5, 1, 2}), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S02855();
        Assert.That(sut.MinimumRightShifts(new[] {1, 3, 5}), Is.EqualTo(0));
    }

    [Test]
    public void T3()
    {
        var sut = new S02855();
        Assert.That(sut.MinimumRightShifts(new[] {2, 1, 4}), Is.EqualTo(-1));
    }
}