using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03121))]
public class S03121Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03121();
        Assert.That(sut.NumberOfSpecialChars("aaAbcBC"), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S03121();
        Assert.That(sut.NumberOfSpecialChars("abc"), Is.Zero);
    }

    [Test]
    public void T3()
    {
        var sut = new S03121();
        Assert.That(sut.NumberOfSpecialChars("AbBCab"), Is.Zero);
    }
}