using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00405Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00405();
        sut.ToHex(26).Should().Be("1a");
    }

    [Test]
    public void T2()
    {
        var sut = new S00405();
        sut.ToHex(-1).Should().Be("ffffffff");
    }
}