using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03634))]
public class S03634Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03634();
        Assert.That(sut.MinRemoval([2, 1, 5], 2), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S03634();
        Assert.That(sut.MinRemoval([1, 6, 2, 9], 3), Is.EqualTo(2));
    }

    [Test]
    public void T3()
    {
        var sut = new S03634();
        Assert.That(sut.MinRemoval([4, 6], 2), Is.Zero);
    }
}