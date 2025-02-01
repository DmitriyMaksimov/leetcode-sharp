using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00514Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00514();
        Assert.That(sut.FindRotateSteps("godding", "gd"), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S00514();
        Assert.That(sut.FindRotateSteps("godding", "godding"), Is.EqualTo(13));
    }
}