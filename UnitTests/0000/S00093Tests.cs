using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00093Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00093();
        sut.RestoreIpAddresses("25525511135").Should().BeEquivalentTo("255.255.11.135", "255.255.111.35");
    }

    [Test]
    public void T2()
    {
        var sut = new S00093();
        sut.RestoreIpAddresses("0000").Should().BeEquivalentTo("0.0.0.0");
    }

    [Test]
    public void T3()
    {
        var sut = new S00093();
        sut.RestoreIpAddresses("101023").Should().BeEquivalentTo("1.0.10.23", "1.0.102.3", "10.1.0.23", "10.10.2.3", "101.0.2.3");
    }
}