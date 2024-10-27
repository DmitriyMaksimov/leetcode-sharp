using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00820Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00820();
        sut.MinimumLengthEncoding(["time", "me", "bell"]).Should().Be(10);
    }

    [Test]
    public void T2()
    {
        var sut = new S00820();
        sut.MinimumLengthEncoding(["t"]).Should().Be(2);
    }
}
