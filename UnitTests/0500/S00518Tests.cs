using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00518Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00518();
        Assert.That(sut.Change(5, new[] {1, 2, 5}), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S00518();
        Assert.That(sut.Change(3, new[] {2}), Is.EqualTo(0));
    }

    [Test]
    public void T3()
    {
        var sut = new S00518();
        Assert.That(sut.Change(10, new[] {10}), Is.EqualTo(1));
    }
}