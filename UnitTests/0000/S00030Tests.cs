using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00030Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00030();
        Assert.That(sut.FindSubstring("barfoothefoobarman", new[] {"foo", "bar"}), Is.EqualTo((int[]) [0, 9]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00030();
        Assert.That(sut.FindSubstring("wordgoodgoodgoodbestword", new[] {"word", "good", "best", "word"}), Is.Empty);
    }

    [Test]
    public void T3()
    {
        var sut = new S00030();
        Assert.That(sut.FindSubstring("barfoofoobarthefoobarman", new[] {"bar", "foo", "the"}), Is.EqualTo((int[]) [6, 9, 12]));
    }
}