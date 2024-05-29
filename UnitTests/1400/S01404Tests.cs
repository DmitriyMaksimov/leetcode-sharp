using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01404Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01404();
        sut.NumSteps("1101").Should().Be(6);
    }

    [Test]
    public void T2()
    {
        var sut = new S01404();
        sut.NumSteps("10").Should().Be(1);
    }

    [Test]
    public void T3()
    {
        var sut = new S01404();
        sut.NumSteps("1").Should().Be(0);
    }
}