using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00824Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00824();
        Assert.That(sut.ToGoatLatin("I speak Goat Latin"), Is.EqualTo("Imaa peaksmaaa oatGmaaaa atinLmaaaaa"));
    }

    [Test]
    public void T2()
    {
        var sut = new S00824();
        Assert.That(sut.ToGoatLatin("The quick brown fox jumped over the lazy dog"), Is.EqualTo("heTmaa uickqmaaa rownbmaaaa oxfmaaaaa umpedjmaaaaaa overmaaaaaaa hetmaaaaaaaa azylmaaaaaaaaa ogdmaaaaaaaaaa"));
    }
}