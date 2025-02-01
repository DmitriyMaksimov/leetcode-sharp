using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00093Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00093();
        Assert.That(sut.RestoreIpAddresses("25525511135"), Is.EquivalentTo((string[]) ["255.255.11.135", "255.255.111.35"]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00093();
        Assert.That(sut.RestoreIpAddresses("0000"), Is.EquivalentTo((string[]) ["0.0.0.0"]));
    }

    [Test]
    public void T3()
    {
        var sut = new S00093();
        Assert.That(sut.RestoreIpAddresses("101023"), Is.EquivalentTo((string[]) ["1.0.10.23", "1.0.102.3", "10.1.0.23", "10.10.2.3", "101.0.2.3"]));
    }
}
