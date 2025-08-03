using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01345Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01345();
        Assert.That(sut.MinJumps([100, -23, -23, 404, 100, 23, 23, 23, 3, 404]), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S01345();
        Assert.That(sut.MinJumps([7]), Is.EqualTo(0));
    }

    [Test]
    public void T3()
    {
        var sut = new S01345();
        Assert.That(sut.MinJumps([7, 6, 9, 6, 9, 6, 9, 7]), Is.EqualTo(1));
    }
}