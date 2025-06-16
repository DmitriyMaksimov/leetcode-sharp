using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03545))]
public class S03545Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03545();
        Assert.That(sut.MinDeletion("abc", 2), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S03545();
        Assert.That(sut.MinDeletion("aabb", 2), Is.EqualTo(0));
    }

    [Test]
    public void T3()
    {
        var sut = new S03545();
        Assert.That(sut.MinDeletion("yyyzz", 1), Is.EqualTo(2));
    }
}
