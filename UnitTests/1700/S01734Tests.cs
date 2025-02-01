using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01734Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01734();
        Assert.That(sut.Decode([3, 1]), Is.EqualTo((int[]) [1, 2, 3]));
    }

    [Test]
    public void T2()
    {
        var sut = new S01734();
        Assert.That(sut.Decode([6, 5, 4, 6]), Is.EqualTo((int[]) [2, 4, 1, 5, 3]));
    }
}
