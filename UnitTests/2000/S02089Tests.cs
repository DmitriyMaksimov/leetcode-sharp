using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02089Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02089();
        Assert.That(sut.TargetIndices(new[] {1, 2, 5, 2, 3}, 2), Is.EqualTo((int[]) [1, 2]));
    }

    [Test]
    public void T2()
    {
        var sut = new S02089();
        Assert.That(sut.TargetIndices(new[] {1, 2, 5, 2, 3}, 3), Is.EqualTo((int[]) [3]));
    }

    [Test]
    public void T3()
    {
        var sut = new S02089();
        Assert.That(sut.TargetIndices(new[] {1, 2, 5, 2, 3}, 5), Is.EqualTo((int[]) [4]));
    }
}