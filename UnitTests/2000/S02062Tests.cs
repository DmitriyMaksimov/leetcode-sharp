using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02062Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02062();
        sut.CountVowelSubstrings("aeiouu").Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S02062();
        sut.CountVowelSubstrings("unicornarihan").Should().Be(0);
    }

    [Test]
    public void T3()
    {
        var sut = new S02062();
        sut.CountVowelSubstrings("cuaieuouac").Should().Be(7);
    }
}