using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02970Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02970();
        Assert.That(sut.IncremovableSubarrayCount(new[] {1, 2, 3, 4}), Is.EqualTo(10));
    }

    [Test]
    public void T2()
    {
        var sut = new S02970();
        Assert.That(sut.IncremovableSubarrayCount(new[] {6, 5, 7, 8}), Is.EqualTo(7));
    }

    [Test]
    public void T3()
    {
        var sut = new S02970();
        Assert.That(sut.IncremovableSubarrayCount(new[] {8, 7, 6, 6}), Is.EqualTo(3));
    }
}