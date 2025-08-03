using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01608Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01608();
        Assert.That(sut.SpecialArray([3, 5]), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S01608();
        Assert.That(sut.SpecialArray([0, 0]), Is.EqualTo(-1));
    }

    [Test]
    public void T3()
    {
        var sut = new S01608();
        Assert.That(sut.SpecialArray([0, 4, 3, 0, 4]), Is.EqualTo(3));
    }
}