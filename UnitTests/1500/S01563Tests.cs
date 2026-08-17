using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S01563))]
public class S01563Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01563();
        Assert.That(sut.StoneGameV([6, 2, 3, 4, 5, 5]), Is.EqualTo(18));
    }

    [Test]
    public void T2()
    {
        var sut = new S01563();
        Assert.That(sut.StoneGameV([7, 7, 7, 7, 7, 7, 7]), Is.EqualTo(28));
    }

    [Test]
    public void T3()
    {
        var sut = new S01563();
        Assert.That(sut.StoneGameV([4]), Is.Zero);
    }
}