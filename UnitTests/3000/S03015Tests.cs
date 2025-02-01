using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03015Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03015();
        Assert.That(sut.CountOfPairs(3, 1, 3), Is.EqualTo((int[]) [6, 0, 0]));
    }

    [Test]
    public void T2()
    {
        var sut = new S03015();
        Assert.That(sut.CountOfPairs(5, 2, 4), Is.EqualTo((int[]) [10, 8, 2, 0, 0]));
    }

    [Test]
    public void T3()
    {
        var sut = new S03015();
        Assert.That(sut.CountOfPairs(4, 1, 1), Is.EqualTo((int[]) [6, 4, 2, 0]));
    }
}
