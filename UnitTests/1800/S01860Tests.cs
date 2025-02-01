using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01860Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01860();
        Assert.That(sut.MemLeak(1, 2), Is.EqualTo((int[]) [2, 1, 1]));
    }

    [Test]
    public void T3()
    {
        var sut = new S01860();
        Assert.That(sut.MemLeak(8, 11), Is.EqualTo((int[]) [6, 0, 4]));
    }
}