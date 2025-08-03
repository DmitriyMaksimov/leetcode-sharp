using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02090Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02090();
        Assert.That(sut.GetAverages([7, 4, 3, 9, 1, 8, 5, 2, 6], 3), Is.EqualTo((int[]) [-1, -1, -1, 5, 4, 4, -1, -1, -1]));
    }

    [Test]
    public void T2()
    {
        var sut = new S02090();
        Assert.That(sut.GetAverages([100000], 0), Is.EqualTo((int[]) [100000]));
    }

    [Test]
    public void T3()
    {
        var sut = new S02090();
        Assert.That(sut.GetAverages([8], 100000), Is.EqualTo((int[]) [-1]));
    }
}