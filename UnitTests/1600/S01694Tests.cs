using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01694Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01694();
        Assert.That(sut.ReformatNumber("1-23-45 6"), Is.EqualTo("123-456"));
    }

    [Test]
    public void T2()
    {
        var sut = new S01694();
        Assert.That(sut.ReformatNumber("123 4-567"), Is.EqualTo("123-45-67"));
    }

    [Test]
    public void T3()
    {
        var sut = new S01694();
        Assert.That(sut.ReformatNumber("123 4-5678"), Is.EqualTo("123-456-78"));
    }
}