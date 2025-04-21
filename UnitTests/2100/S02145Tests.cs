using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02145Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02145();
        Assert.That(sut.NumberOfArrays([1, -3, 4], 1, 6), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S02145();
        Assert.That(sut.NumberOfArrays([3, -4, 5, 1, -2], -4, 5), Is.EqualTo(4));
    }

    [Test]
    public void T3()
    {
        var sut = new S02145();
        Assert.That(sut.NumberOfArrays([4, -7, 2], 3, 6), Is.EqualTo(0));
    }
}
