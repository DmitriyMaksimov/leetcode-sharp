using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01324Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01324();
        sut.PrintVertically("HOW ARE YOU").Should().Equal("HAY", "ORO", "WEU");
    }

    [Test]
    public void T2()
    {
        var sut = new S01324();
        sut.PrintVertically("TO BE OR NOT TO BE").Should().Equal("TBONTB", "OEROOE", "   T");
    }

    [Test]
    public void T3()
    {
        var sut = new S01324();
        sut.PrintVertically("CONTEST IS COMING").Should().Equal("CIC", "OSO", "N M", "T I", "E N", "S G", "T");
    }
}
