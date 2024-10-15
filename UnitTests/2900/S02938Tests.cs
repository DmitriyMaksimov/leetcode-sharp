using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02938Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02938();
        sut.MinimumSteps("101").Should().Be(1);
    }

    [Test]
    public void T2()
    {
        var sut = new S02938();
        sut.MinimumSteps("100").Should().Be(2);
    }

    [Test]
    public void T3()
    {
        var sut = new S02938();
        sut.MinimumSteps("0111").Should().Be(0);
    }
}
