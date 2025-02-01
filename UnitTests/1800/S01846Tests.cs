using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01846Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01846();
        Assert.That(sut.MaximumElementAfterDecrementingAndRearranging(new[] {2, 2, 1, 2, 1}), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S01846();
        Assert.That(sut.MaximumElementAfterDecrementingAndRearranging(new[] {100, 1, 1000}), Is.EqualTo(3));
    }

    [Test]
    public void T3()
    {
        var sut = new S01846();
        Assert.That(sut.MaximumElementAfterDecrementingAndRearranging(new[] {1, 2, 3, 4, 5}), Is.EqualTo(5));
    }
}