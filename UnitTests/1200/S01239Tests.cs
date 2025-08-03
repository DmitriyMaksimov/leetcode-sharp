using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01239Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01239();
        Assert.That(sut.MaxLength(["un","iq","ue"]), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S01239();
        Assert.That(sut.MaxLength(["cha","r","act","ers"]), Is.EqualTo(6));
    }

    [Test]
    public void T3()
    {
        var sut = new S01239();
        Assert.That(sut.MaxLength(["abcdefghijklmnopqrstuvwxyz"]), Is.EqualTo(26));
    }
}