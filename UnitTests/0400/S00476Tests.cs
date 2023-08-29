using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00476Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00476();
        sut.FindComplement(5).Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S00476();
        sut.FindComplement(1).Should().Be(0);
    }
}