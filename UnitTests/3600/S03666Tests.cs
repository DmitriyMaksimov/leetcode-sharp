using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03666))]
public class S03666Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03666();
        Assert.That(sut.MinOperations("110", 1), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S03666();
        Assert.That(sut.MinOperations("0101", 3), Is.EqualTo(2));
    }

    [Test]
    public void T3()
    {
        var sut = new S03666();
        Assert.That(sut.MinOperations("101", 2), Is.EqualTo(-1));
    }
}