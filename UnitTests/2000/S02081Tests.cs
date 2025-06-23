using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S02081))]
public class S02081Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02081();
        Assert.That(sut.KMirror(2, 5), Is.EqualTo(25));
    }

    [Test]
    public void T2()
    {
        var sut = new S02081();
        Assert.That(sut.KMirror(3, 7), Is.EqualTo(499));
    }

    [Test]
    public void T3()
    {
        var sut = new S02081();
        Assert.That(sut.KMirror(7, 17), Is.EqualTo(20379000));
    }
}