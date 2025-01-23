using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00299Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00299();
        sut.GetHint("1807", "7810").Should().Be("1A3B");
    }

    [Test]
    public void T2()
    {
        var sut = new S00299();
        sut.GetHint("1123", "0111").Should().Be("1A1B");
    }
}
