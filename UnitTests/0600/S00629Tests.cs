using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00629Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00629();
        sut.KInversePairs(3, 0).Should().Be(1);
    }

    [Test]
    public void T2()
    {
        var sut = new S00629();
        sut.KInversePairs(3, 1).Should().Be(2);
    }
}