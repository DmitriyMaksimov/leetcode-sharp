using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02566Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02566();
        Assert.That(sut.MinMaxDifference(11891), Is.EqualTo(99009));
    }

    [Test]
    public void T2()
    {
        var sut = new S02566();
        Assert.That(sut.MinMaxDifference(90), Is.EqualTo(99));
    }
}