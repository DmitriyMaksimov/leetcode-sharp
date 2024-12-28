using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00481Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00481();
        sut.MagicalString(6).Should().Be(3);
    }

    [Test]
    public void T2()
    {
        var sut = new S00481();
        sut.MagicalString(1).Should().Be(1);
    }
}
