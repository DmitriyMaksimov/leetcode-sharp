using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02155Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02155();
        Assert.That(sut.MaxScoreIndices([0, 0, 1, 0]), Is.EqualTo((int[]) [2, 4]));
    }

    [Test]
    public void T2()
    {
        var sut = new S02155();
        Assert.That(sut.MaxScoreIndices([0, 0, 0]), Is.EqualTo((int[]) [3]));
    }

    [Test]
    public void T3()
    {
        var sut = new S02155();
        Assert.That(sut.MaxScoreIndices([1, 1]), Is.EqualTo((int[]) [0]));
    }
}
