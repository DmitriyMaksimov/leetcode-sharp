using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00067Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00067();
        sut.AddBinary("11", "1").Should().Be("100");
    }

    [Test]
    public void T2()
    {
        var sut = new S00067();
        sut.AddBinary("1010", "1011").Should().Be("10101");
    }
    
    [Test]
    public void T3()
    {
        var sut = new S00067();
        sut.AddBinary("1111", "1111").Should().Be("11110");
    }
}