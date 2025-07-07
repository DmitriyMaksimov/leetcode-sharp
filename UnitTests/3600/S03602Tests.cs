using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03602))]
public class S03602Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03602();
        Assert.That(sut.ConcatHex36(13), Is.EqualTo("A91P1"));
    }

    [Test]
    public void T2()
    {
        var sut = new S03602();
        Assert.That(sut.ConcatHex36(36), Is.EqualTo("5101000"));
    }
}