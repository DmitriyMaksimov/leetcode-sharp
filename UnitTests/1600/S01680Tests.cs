using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01680Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01680();
        sut.ConcatenatedBinary(1).Should().Be(1);
    }

    [Test]
    public void T2()
    {
        var sut = new S01680();
        sut.ConcatenatedBinary(3).Should().Be(27);
    }

    [Test]
    public void T3()
    {
        var sut = new S01680();
        sut.ConcatenatedBinary(12).Should().Be(505379714);
    }
}
