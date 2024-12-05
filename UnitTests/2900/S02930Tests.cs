using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02930Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02930();
        sut.StringCount(4).Should().Be(12);
    }

    [Test]
    public void T2()
    {
        var sut = new S02930();
        sut.StringCount(10).Should().Be(83943898);
    }
}
