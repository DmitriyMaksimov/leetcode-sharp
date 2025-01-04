using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00966Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00966();
        sut.Spellchecker(["KiTe", "kite", "hare", "Hare"], ["kite", "Kite", "KiTe", "Hare", "HARE", "Hear", "hear", "keti", "keet", "keto"]).Should()
            .Equal("kite", "KiTe", "KiTe", "Hare", "hare", "", "", "KiTe", "", "KiTe");
    }

    [Test]
    public void T2()
    {
        var sut = new S00966();
        sut.Spellchecker(["yellow"], ["YellOw"]).Should().Equal("yellow");
    }
}
