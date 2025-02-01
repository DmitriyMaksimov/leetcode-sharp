using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02698Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02698();
        Assert.That(sut.PunishmentNumber(10), Is.EqualTo(182));
    }

    [Test]
    public void T2()
    {
        var sut = new S02698();
        Assert.That(sut.PunishmentNumber(37), Is.EqualTo(1478));
    }
}
