using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03629))]
public class S03629Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03629();
        Assert.That(sut.MinJumps([1, 2, 4, 6]), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S03629();
        Assert.That(sut.MinJumps([2, 3, 4, 7, 9]), Is.EqualTo(2));
    }

    [Test]
    public void T3()
    {
        var sut = new S03629();
        Assert.That(sut.MinJumps([4, 6, 5, 8]), Is.EqualTo(3));
    }
}