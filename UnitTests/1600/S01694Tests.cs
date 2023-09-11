using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01694Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01694();
        sut.ReformatNumber("1-23-45 6").Should().Be("123-456");
    }

    [Test]
    public void T2()
    {
        var sut = new S01694();
        sut.ReformatNumber("123 4-567").Should().Be("123-45-67");
    }

    [Test]
    public void T3()
    {
        var sut = new S01694();
        sut.ReformatNumber("123 4-5678").Should().Be("123-456-78");
    }
}