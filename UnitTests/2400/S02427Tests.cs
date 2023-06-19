using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02427Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02427();
        sut.CommonFactors(12, 6).Should().Be(4);
    }

    [Test]
    public void T2()
    {
        var sut = new S02427();
        sut.CommonFactors(25, 30).Should().Be(2);
    }
}