using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00650Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00650();
        Assert.That(sut.MinSteps(3), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S00650();
        Assert.That(sut.MinSteps(1), Is.EqualTo(0));
    }
}
