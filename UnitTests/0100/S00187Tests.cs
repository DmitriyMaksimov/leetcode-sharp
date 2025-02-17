using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00187Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00187();
        Assert.That(sut.FindRepeatedDnaSequences("AAAAACCCCCAAAAACCCCCCAAAAAGGGTTT"), Is.EqualTo(["AAAAACCCCC", "CCCCCAAAAA"]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00187();
        Assert.That(sut.FindRepeatedDnaSequences("AAAAAAAAAAAAA"), Is.EqualTo(["AAAAAAAAAA"]));
    }
}
