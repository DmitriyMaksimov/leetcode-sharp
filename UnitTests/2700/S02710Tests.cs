using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02710Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02710();
        sut.RemoveTrailingZeros("51230100").Should().Be("512301");
    }

    [Test]
    public void T2()
    {
        var sut = new S02710();
        sut.RemoveTrailingZeros("123").Should().Be("123");
    }
}