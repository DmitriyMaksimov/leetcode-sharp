using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02062Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02062();
        Assert.That(sut.CountVowelSubstrings("aeiouu"), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S02062();
        Assert.That(sut.CountVowelSubstrings("unicornarihan"), Is.EqualTo(0));
    }

    [Test]
    public void T3()
    {
        var sut = new S02062();
        Assert.That(sut.CountVowelSubstrings("cuaieuouac"), Is.EqualTo(7));
    }
}