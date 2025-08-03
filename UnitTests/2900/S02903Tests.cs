using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02903Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02903();
        Assert.That(sut.FindIndices([5, 1, 4, 1], 2, 4), Is.EqualTo((int[]) [0, 3]));
    }

    [Test]
    public void T2()
    {
        var sut = new S02903();
        Assert.That(sut.FindIndices([2, 1], 0, 0), Is.EqualTo((int[]) [0, 0]));
    }

    [Test]
    public void T3()
    {
        var sut = new S02903();
        Assert.That(sut.FindIndices([1, 2, 3], 2, 4), Is.EqualTo((int[]) [-1, -1]));
    }
}