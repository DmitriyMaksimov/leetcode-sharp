using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02164Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02164();
        Assert.That(sut.SortEvenOdd(new[] {4, 1, 2, 3}), Is.EqualTo((int[]) [2, 3, 4, 1]));
    }

    [Test]
    public void T2()
    {
        var sut = new S02164();
        Assert.That(sut.SortEvenOdd(new[] {2, 1}), Is.EqualTo((int[]) [2, 1]));
    }
}