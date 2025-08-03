using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01187Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01187();
        Assert.That(sut.MakeArrayIncreasing([1, 5, 3, 6, 7], [1, 3, 2, 4]), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S01187();
        Assert.That(sut.MakeArrayIncreasing([1, 5, 3, 6, 7], [4, 3, 1]), Is.EqualTo(2));
    }

    [Test]
    public void T3()
    {
        var sut = new S01187();
        Assert.That(sut.MakeArrayIncreasing([1, 5, 3, 6, 7], [1, 6, 3, 3]), Is.EqualTo(-1));
    }
}