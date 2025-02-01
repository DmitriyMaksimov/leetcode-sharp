using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02938Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02938();
        Assert.That(sut.MinimumSteps("101"), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S02938();
        Assert.That(sut.MinimumSteps("100"), Is.EqualTo(2));
    }

    [Test]
    public void T3()
    {
        var sut = new S02938();
        Assert.That(sut.MinimumSteps("0111"), Is.EqualTo(0));
    }
}
