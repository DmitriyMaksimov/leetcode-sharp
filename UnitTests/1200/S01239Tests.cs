using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01239Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01239();
        Assert.That(sut.MaxLength(new[] { "un","iq","ue"}), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S01239();
        Assert.That(sut.MaxLength(new[] {"cha","r","act","ers" }), Is.EqualTo(6));
    }

    [Test]
    public void T3()
    {
        var sut = new S01239();
        Assert.That(sut.MaxLength(new[] { "abcdefghijklmnopqrstuvwxyz"}), Is.EqualTo(26));
    }
}