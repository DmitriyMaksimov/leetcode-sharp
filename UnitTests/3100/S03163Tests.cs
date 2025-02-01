using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03163Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03163();
        Assert.That(sut.CompressedString("abcde"), Is.EqualTo("1a1b1c1d1e"));
    }

    [Test]
    public void T2()
    {
        var sut = new S03163();
        Assert.That(sut.CompressedString("aaaaaaaaaaaaaabb"), Is.EqualTo("9a5a2b"));
    }
}
