using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01324Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01324();
        Assert.That(sut.PrintVertically("HOW ARE YOU"), Is.EqualTo((string[]) ["HAY", "ORO", "WEU"]));
    }

    [Test]
    public void T2()
    {
        var sut = new S01324();
        Assert.That(sut.PrintVertically("TO BE OR NOT TO BE"), Is.EqualTo((string[]) ["TBONTB", "OEROOE", "   T"]));
    }

    [Test]
    public void T3()
    {
        var sut = new S01324();
        Assert.That(sut.PrintVertically("CONTEST IS COMING"), Is.EqualTo((string[]) ["CIC", "OSO", "N M", "T I", "E N", "S G", "T"]));
    }
}
