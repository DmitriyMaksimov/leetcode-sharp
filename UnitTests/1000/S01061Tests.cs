using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01061Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01061();
        Assert.That(sut.SmallestEquivalentString("parker", "morris", "parser"), Is.EqualTo("makkek"));
    }

    [Test]
    public void T2()
    {
        var sut = new S01061();
        Assert.That(sut.SmallestEquivalentString("hello", "world", "hold"), Is.EqualTo("hdld"));
    }

    [Test]
    public void T3()
    {
        var sut = new S01061();
        Assert.That(sut.SmallestEquivalentString("leetcode", "programs", "sourcecode"), Is.EqualTo("aauaaaaada"));
    }
    
    [Test]
    public void T4()
    {
        var sut = new S01061();
        Assert.That(sut.SmallestEquivalentString("cgokcgerolkgksgbhgmaaealacnsshofjinidiigbjerdnkolc", "rjjlkbmnprkslilqmbnlasardrossiogrcboomrbcmgmglsrsj", "bxbwjlbdazfejdsaacsjgrlxqhiddwaeguxhqoupicyzfeupcn"), Is.EqualTo("axawaaaaazaaaaaaaaaaaaaxaaaaawaaauxaaauaaayzaauaaa"));
    }
}