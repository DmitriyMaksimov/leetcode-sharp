using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03120Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03120();
        Assert.That(sut.NumberOfSpecialChars("aaAbcBC"), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S03120();
        Assert.That(sut.NumberOfSpecialChars("abc"), Is.EqualTo(0));
    }

    [Test]
    public void T3()
    {
        var sut = new S03120();
        Assert.That(sut.NumberOfSpecialChars("abBCab"), Is.EqualTo(1));
    }
}