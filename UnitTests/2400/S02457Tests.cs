using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02457Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02457();
        Assert.That(sut.MakeIntegerBeautiful(16, 6), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S02457();
        Assert.That(sut.MakeIntegerBeautiful(467, 6), Is.EqualTo(33));
    }

    [Test]
    public void T3()
    {
        var sut = new S02457();
        Assert.That(sut.MakeIntegerBeautiful(1, 1), Is.EqualTo(0));
    }
}