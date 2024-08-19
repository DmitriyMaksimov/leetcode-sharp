using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00650Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00650();
        sut.MinSteps(3).Should().Be(3);
    }

    [Test]
    public void T2()
    {
        var sut = new S00650();
        sut.MinSteps(1).Should().Be(0);
    }
}
