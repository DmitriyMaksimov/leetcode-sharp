using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00824Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00824();
        sut.ToGoatLatin("I speak Goat Latin").Should().Be("Imaa peaksmaaa oatGmaaaa atinLmaaaaa");
    }

    [Test]
    public void T2()
    {
        var sut = new S00824();
        sut.ToGoatLatin("The quick brown fox jumped over the lazy dog").Should().Be(
            "heTmaa uickqmaaa rownbmaaaa oxfmaaaaa umpedjmaaaaaa overmaaaaaaa hetmaaaaaaaa azylmaaaaaaaaa ogdmaaaaaaaaaa");
    }
}