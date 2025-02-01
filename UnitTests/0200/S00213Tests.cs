using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00213Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00213();
        Assert.That(sut.Rob(new[] {1, 2, 3, 1}), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S00213();
        Assert.That(sut.Rob(new[] {2, 3, 2}), Is.EqualTo(3));
    }

    [Test]
    public void T3()
    {
        var sut = new S00213();
        Assert.That(sut.Rob(new[] {1, 2, 3}), Is.EqualTo(3));
    }

    [Test]
    public void T4()
    {
        var sut = new S00213();
        Assert.That(sut.Rob(new[] {1}), Is.EqualTo(1));
    }

    [Test]
    public void T5()
    {
        var sut = new S00213();
        Assert.That(sut.Rob(new[] {1, 2, 1, 1}), Is.EqualTo(3));
    }
}