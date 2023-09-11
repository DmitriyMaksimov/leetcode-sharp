using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01758Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01758();
        sut.MinOperations("0100").Should().Be(1);
    }

    [Test]
    public void T2()
    {
        var sut = new S01758();
        sut.MinOperations("10").Should().Be(0);
    }

    [Test]
    public void T3()
    {
        var sut = new S01758();
        sut.MinOperations("1111").Should().Be(2);
    }
}