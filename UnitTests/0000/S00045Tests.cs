using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00045Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00045();
        Assert.That(sut.Jump(new[] {2, 3, 1, 1, 4}), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S00045();
        Assert.That(sut.Jump(new[] {2, 3, 0, 1, 4}), Is.EqualTo(2));
    }

    [Test]
    public void T3()
    {
        var sut = new S00045();
        Assert.That(sut.Jump(new[] {0}), Is.EqualTo(0));
    }

    [Test]
    public void T4()
    {
        var sut = new S00045();
        Assert.That(sut.Jump(new[] {1, 2, 3}), Is.EqualTo(2));
    }
}