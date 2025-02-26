using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02645Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02645();
        Assert.That(sut.AddMinimum("b"), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S02645();
        Assert.That(sut.AddMinimum("aaa"), Is.EqualTo(6));
    }

    [Test]
    public void T3()
    {
        var sut = new S02645();
        Assert.That(sut.AddMinimum("abc"), Is.EqualTo(0));
    }
}
