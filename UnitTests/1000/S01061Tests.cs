using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01061Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01061();
        sut.SmallestEquivalentString("parker", "morris", "parser").Should().Be("makkek");
    }

    [Test]
    public void T2()
    {
        var sut = new S01061();
        sut.SmallestEquivalentString("hello", "world", "hold").Should().Be("hdld");
    }

    [Test]
    public void T3()
    {
        var sut = new S01061();
        sut.SmallestEquivalentString("leetcode", "programs", "sourcecode").Should().Be("aauaaaaada");
    }
    
    [Test]
    public void T4()
    {
        var sut = new S01061();
        sut.SmallestEquivalentString("cgokcgerolkgksgbhgmaaealacnsshofjinidiigbjerdnkolc", "rjjlkbmnprkslilqmbnlasardrossiogrcboomrbcmgmglsrsj", "bxbwjlbdazfejdsaacsjgrlxqhiddwaeguxhqoupicyzfeupcn").Should().Be("axawaaaaazaaaaaaaaaaaaaxaaaaawaaauxaaauaaayzaauaaa");
    }
}