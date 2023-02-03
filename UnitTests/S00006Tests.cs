using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00006Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00006();
        sut.Convert("PAYPALISHIRING", 3).Should().Be("PAHNAPLSIIGYIR");
    }

    [Test]
    public void T2()
    {
        var sut = new S00006();
        sut.Convert("PAYPALISHIRING", 4).Should().Be("PINALSIGYAHRPI");
    }

    [Test]
    public void T3()
    {
        var sut = new S00006();
        sut.Convert("A", 1).Should().Be("A");
    }
}