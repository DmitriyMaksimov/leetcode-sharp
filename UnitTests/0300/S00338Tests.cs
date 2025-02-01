using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00338Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00338();
        Assert.That(sut.CountBits(2), Is.EqualTo((int[]) [0, 1, 1]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00338();
        Assert.That(sut.CountBits(5), Is.EqualTo((int[]) [0, 1, 1, 2, 1, 2]));
    }
}