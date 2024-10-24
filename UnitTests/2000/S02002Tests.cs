using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02002Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02002();
        sut.MaxProduct("leetcodecom").Should().Be(9);
    }

    [Test]
    public void T2()
    {
        var sut = new S02002();
        sut.MaxProduct("bb").Should().Be(1);
    }

    [Test]
    public void T3()
    {
        var sut = new S02002();
        sut.MaxProduct("accbcaxxcxx").Should().Be(25);
    }
}
