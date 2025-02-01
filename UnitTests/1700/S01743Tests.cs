using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01743Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01743();
        Assert.That(sut.RestoreArray(new[] {new[] {2, 1}, new[] {3, 4}, new[] {3, 2}}), Is.EqualTo((int[]) [1, 2, 3, 4]));
    }

    [Test]
    public void T2()
    {
        var sut = new S01743();
        Assert.That(sut.RestoreArray(new[] {new[] {4, -2}, new[] {1, 4}, new[] {-3, 1}}), Is.EqualTo((int[]) [-2, 4, 1, -3]));
    }

    [Test]
    public void T3()
    {
        var sut = new S01743();
        Assert.That(sut.RestoreArray(new[] {new[] {100000, -100000}}), Is.EqualTo((int[]) [100000, -100000]));
    }
}