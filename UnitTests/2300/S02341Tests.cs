using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02341Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02341();
        Assert.That(sut.NumberOfPairs(new[] {1, 3, 2, 1, 3, 2, 2}), Is.EqualTo((int[]) [3, 1]));
    }

    [Test]
    public void T2()
    {
        var sut = new S02341();
        Assert.That(sut.NumberOfPairs(new[] {1, 1}), Is.EqualTo((int[]) [1, 0]));
    }

    [Test]
    public void T3()
    {
        var sut = new S02341();
        Assert.That(sut.NumberOfPairs(new[] {0}), Is.EqualTo((int[]) [0, 1]));
    }
}