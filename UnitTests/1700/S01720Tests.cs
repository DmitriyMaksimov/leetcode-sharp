using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01720Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01720();
        Assert.That(sut.Decode([1, 2, 3], 1), Is.EqualTo((int[]) [1, 0, 2, 1]));
    }

    [Test]
    public void T2()
    {
        var sut = new S01720();
        Assert.That(sut.Decode([6, 2, 7, 3], 4), Is.EqualTo((int[]) [4, 2, 0, 7, 4]));
    }
}