using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01404Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01404();
        Assert.That(sut.NumSteps("1101"), Is.EqualTo(6));
    }

    [Test]
    public void T2()
    {
        var sut = new S01404();
        Assert.That(sut.NumSteps("10"), Is.EqualTo(1));
    }

    [Test]
    public void T3()
    {
        var sut = new S01404();
        Assert.That(sut.NumSteps("1"), Is.EqualTo(0));
    }
}