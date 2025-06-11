using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03445))]
public class S03445Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03445();
        Assert.That(sut.MaxDifference("12233", 4), Is.EqualTo(-1));
    }

    [Test]
    public void T2()
    {
        var sut = new S03445();
        Assert.That(sut.MaxDifference("1122211", 3), Is.EqualTo(1));
    }

    [Test]
    public void T3()
    {
        var sut = new S03445();
        Assert.That(sut.MaxDifference("110", 3), Is.EqualTo(-1));
    }
}
