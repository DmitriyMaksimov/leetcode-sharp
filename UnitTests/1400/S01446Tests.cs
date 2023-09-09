using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01446Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01446();
        sut.MaxPower("leetcode").Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S01446();
        sut.MaxPower("abbcccddddeeeeedcba").Should().Be(5);
    }
}