using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01743Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01743();
        Assert.That(sut.RestoreArray([[2, 1], [3, 4], [3, 2]]), Is.EqualTo((int[]) [1, 2, 3, 4]));
    }

    [Test]
    public void T2()
    {
        var sut = new S01743();
        Assert.That(sut.RestoreArray([[4, -2], [1, 4], [-3, 1]]), Is.EqualTo((int[]) [-2, 4, 1, -3]));
    }

    [Test]
    public void T3()
    {
        var sut = new S01743();
        Assert.That(sut.RestoreArray([[100000, -100000]]), Is.EqualTo((int[]) [100000, -100000]));
    }
}