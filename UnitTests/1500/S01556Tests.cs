using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01556Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01556();
        sut.ThousandSeparator(987).Should().Be("987");
    }

    [Test]
    public void T2()
    {
        var sut = new S01556();
        sut.ThousandSeparator(1234).Should().Be("1.234");
    }
}