using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00605Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00605();
        Assert.That(sut.CanPlaceFlowers(new[] {1, 0, 0, 0, 1}, 1), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S00605();
        Assert.That(sut.CanPlaceFlowers(new[] {1, 0, 0, 0, 1}, 2), Is.False);
    }

    [Test]
    public void T3()
    {
        var sut = new S00605();
        Assert.That(sut.CanPlaceFlowers(new[] {1, 0, 1, 0, 1, 0, 0}, 2), Is.False);
    }

    [Test]
    public void T4()
    {
        var sut = new S00605();
        Assert.That(sut.CanPlaceFlowers(new[] {1, 0, 1, 0, 1, 0, 0}, 1), Is.True);
    }

    [Test]
    public void T5()
    {
        var sut = new S00605();
        Assert.That(sut.CanPlaceFlowers(new[] {0, 1, 1, 1, 0}, 1), Is.False);
    }

    [Test]
    public void T6()
    {
        var sut = new S00605();
        Assert.That(sut.CanPlaceFlowers(new[] {1, 0, 1, 1, 0}, 1), Is.False);
    }


    [Test]
    public void T7()
    {
        var sut = new S00605();
        Assert.That(sut.CanPlaceFlowers(new[] {0, 0, 1, 1, 0}, 1), Is.True);
    }
}
