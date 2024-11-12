using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01006Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01006();
        sut.Clumsy(4).Should().Be(7);
    }

    [Test]
    public void T2()
    {
        var sut = new S01006();
        sut.Clumsy(10).Should().Be(12);
    }
}
