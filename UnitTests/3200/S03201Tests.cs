using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03201))]
public class S03201Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03201();
        Assert.That(sut.MaximumLength([1, 2, 3, 4]), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S03201();
        Assert.That(sut.MaximumLength([1, 2, 1, 1, 2, 1, 2]), Is.EqualTo(6));
    }

    [Test]
    public void T3()
    {
        var sut = new S03201();
        Assert.That(sut.MaximumLength([1, 3]), Is.EqualTo(2));
    }
}