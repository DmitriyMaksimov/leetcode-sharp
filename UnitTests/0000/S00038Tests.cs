using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00038Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00038();
        sut.CountAndSay(4).Should().Be("1211");
    }

    [Test]
    public void T2()
    {
        var sut = new S00038();
        sut.CountAndSay(1).Should().Be("1");
    }
}
