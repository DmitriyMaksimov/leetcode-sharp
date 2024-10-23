using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01017Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01017();
        sut.BaseNeg2(2).Should().Be("110");
    }

    [Test]
    public void T2()
    {
        var sut = new S01017();
        sut.BaseNeg2(3).Should().Be("111");
    }

    [Test]
    public void T3()
    {
        var sut = new S01017();
        sut.BaseNeg2(4).Should().Be("100");
    }
}
