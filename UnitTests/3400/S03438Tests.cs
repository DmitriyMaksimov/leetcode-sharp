using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03438Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03438();
        Assert.That(sut.FindValidPair("2523533"), Is.EqualTo("23"));
    }

    [Test]
    public void T2()
    {
        var sut = new S03438();
        Assert.That(sut.FindValidPair("221"), Is.EqualTo("21"));
    }

    [Test]
    public void T3()
    {
        var sut = new S03438();
        Assert.That(sut.FindValidPair("22"), Is.EqualTo(""));
    }
}
