using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00030Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00030();
        sut.FindSubstring("barfoothefoobarman", new[] {"foo", "bar"}).Should().Equal(0, 9);
    }

    [Test]
    public void T2()
    {
        var sut = new S00030();
        sut.FindSubstring("wordgoodgoodgoodbestword", new[] {"word", "good", "best", "word"}).Should().BeEmpty();
    }

    [Test]
    public void T3()
    {
        var sut = new S00030();
        sut.FindSubstring("barfoofoobarthefoobarman", new[] {"bar", "foo", "the"}).Should().Equal(6, 9, 12);
    }
}