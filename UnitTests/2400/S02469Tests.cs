using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02469UnitTests
{
    [Test]
    public void Test1()
    {
        var sut = new S02469();
        sut.ConvertTemperature(36.50).Should().Equal(309.65000, 97.70000);
    }
    
    [Test]
    public void Test2()
    {
        var sut = new S02469();
        sut.ConvertTemperature(122.11).Should().Equal(395.26000, 251.79800);
    }
}