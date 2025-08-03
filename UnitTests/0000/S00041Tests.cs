using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00041Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00041();
        Assert.That(sut.FirstMissingPositive([1, 2, 0]), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S00041();
        Assert.That(sut.FirstMissingPositive([3, 4, -1, 1]), Is.EqualTo(2));
    }

    [Test]
    public void T3()
    {
        var sut = new S00041();
        Assert.That(sut.FirstMissingPositive([7, 8, 9, 11, 12]), Is.EqualTo(1));
    }
}