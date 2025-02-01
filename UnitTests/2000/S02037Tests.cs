using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02037Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02037();
        Assert.That(sut.MinMovesToSeat(new[] {3, 1, 5}, new[] {2, 7, 4}), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S02037();
        Assert.That(sut.MinMovesToSeat(new[] {4, 1, 5, 9}, new[] {1, 3, 2, 6}), Is.EqualTo(7));
    }

    [Test]
    public void T3()
    {
        var sut = new S02037();
        Assert.That(sut.MinMovesToSeat(new[] {2, 2, 6, 6}, new[] {1, 3, 2, 6}), Is.EqualTo(4));
    }
}