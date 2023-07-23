using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02496Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02496();
        sut.MaximumValue(new[] {"alic3", "bob", "3", "4", "00000"}).Should().Be(5);
    }

    [Test]
    public void T2()
    {
        var sut = new S02496();
        sut.MaximumValue(new[] {"1", "01", "001", "0001"}).Should().Be(1);
    }
}