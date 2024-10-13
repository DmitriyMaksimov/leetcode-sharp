using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00869Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00869();
        sut.ReorderedPowerOf2(1).Should().BeTrue();
    }

    [Test]
    public void T2()
    {
        var sut = new S00869();
        sut.ReorderedPowerOf2(10).Should().BeFalse();
    }
}
