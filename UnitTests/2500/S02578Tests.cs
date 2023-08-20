using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02578Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02578();
        sut.SplitNum(4325).Should().Be(59);
    }

    [Test]
    public void T2()
    {
        var sut = new S02578();
        sut.SplitNum(687).Should().Be(75);
    }
}