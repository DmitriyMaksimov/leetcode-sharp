using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00424Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00424();
        Assert.That(sut.CharacterReplacement("ABAB", 2), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S00424();
        Assert.That(sut.CharacterReplacement("AABABBA", 1), Is.EqualTo(4));
    }
}
