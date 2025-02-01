using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02469Tests
{
    [Test]
    public void Test1()
    {
        var sut = new S02469();
        Assert.That(sut.ConvertTemperature(36.50), Is.EqualTo((double[]) [309.65000, 97.70000]));
    }
    
    [Test]
    public void Test2()
    {
        var sut = new S02469();
        Assert.That(sut.ConvertTemperature(122.11), Is.EqualTo((double[]) [395.26000, 251.79800]));
    }
}
