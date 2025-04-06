using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03498Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03498();
        Assert.That(sut.ReverseDegree("abc"), Is.EqualTo(148));
    }

    [Test]
    public void T2()
    {
        var sut = new S03498();
        Assert.That(sut.ReverseDegree("zaza"), Is.EqualTo(160));
    }
}
