using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02496Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02496();
        Assert.That(sut.MaximumValue(new[] {"alic3", "bob", "3", "4", "00000"}), Is.EqualTo(5));
    }

    [Test]
    public void T2()
    {
        var sut = new S02496();
        Assert.That(sut.MaximumValue(new[] {"1", "01", "001", "0001"}), Is.EqualTo(1));
    }
}