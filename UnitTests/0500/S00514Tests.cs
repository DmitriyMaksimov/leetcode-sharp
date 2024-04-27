using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00514Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00514();
        sut.FindRotateSteps("godding", "gd").Should().Be(4);
    }

    [Test]
    public void T2()
    {
        var sut = new S00514();
        sut.FindRotateSteps("godding", "godding").Should().Be(13);
    }
}