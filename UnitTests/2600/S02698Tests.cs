using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02698Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02698();
        sut.PunishmentNumber(10).Should().Be(182);
    }

    [Test]
    public void T2()
    {
        var sut = new S02698();
        sut.PunishmentNumber(37).Should().Be(1478);
    }
}
