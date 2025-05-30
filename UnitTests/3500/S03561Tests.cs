using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03561))]
public class S03561Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03561();
        Assert.That(sut.ResultingString("abc"), Is.EqualTo("c"));
    }

    [Test]
    public void T2()
    {
        var sut = new S03561();
        Assert.That(sut.ResultingString("adcb"), Is.EqualTo(""));
    }

    [Test]
    public void T3()
    {
        var sut = new S03561();
        Assert.That(sut.ResultingString("zadb"), Is.EqualTo("db"));
    }
}
