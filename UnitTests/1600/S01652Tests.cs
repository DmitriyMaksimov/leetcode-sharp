using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01652Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01652();
        Assert.That(sut.Decrypt([5, 7, 1, 4], 3), Is.EqualTo((int[]) [12, 10, 16, 13]));
    }

    [Test]
    public void T2()
    {
        var sut = new S01652();
        Assert.That(sut.Decrypt([1, 2, 3, 4], 0), Is.EqualTo((int[]) [0, 0, 0, 0]));
    }

    [Test]
    public void T3()
    {
        var sut = new S01652();
        Assert.That(sut.Decrypt([2, 4, 9, 3], -2), Is.EqualTo((int[]) [12, 5, 6, 13]));
    }
}