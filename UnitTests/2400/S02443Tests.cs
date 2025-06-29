using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S02443))]
public class S02443Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02443();
        Assert.That(sut.SumOfNumberAndReverse(443), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S02443();
        Assert.That(sut.SumOfNumberAndReverse(63), Is.False);
    }

    [Test]
    public void T3()
    {
        var sut = new S02443();
        Assert.That(sut.SumOfNumberAndReverse(181), Is.True);
    }

    [Test]
    public void T4()
    {
        var sut = new S02443();
        Assert.That(sut.SumOfNumberAndReverse(2), Is.True);
    }
}