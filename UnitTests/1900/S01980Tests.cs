using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01980Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01980();
        sut.FindDifferentBinaryString(new[] {"01", "10"}).Should().Be("11");
    }

    [Test]
    public void T2()
    {
        var sut = new S01980();
        sut.FindDifferentBinaryString(new[] {"00", "01"}).Should().Be("10");
    }

    [Test]
    public void T3()
    {
        var sut = new S01980();
        sut.FindDifferentBinaryString(new[] {"111", "011", "001"}).Should().Be("000");
    }
}