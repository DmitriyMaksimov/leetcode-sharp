using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00767Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00767();
        sut.ReorganizeString("aab").Should().Be("aba");
    }

    [Test]
    public void T2()
    {
        var sut = new S00767();
        sut.ReorganizeString("aaab").Should().Be("");
    }
}