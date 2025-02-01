using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00966Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00966();
        Assert.That(sut.Spellchecker(["KiTe", "kite", "hare", "Hare"], ["kite", "Kite", "KiTe", "Hare", "HARE", "Hear", "hear", "keti", "keet", "keto"]), Is.EqualTo((string[]) ["kite", "KiTe", "KiTe", "Hare", "hare", "", "", "KiTe", "", "KiTe"]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00966();
        Assert.That(sut.Spellchecker(["yellow"], ["YellOw"]), Is.EqualTo((string[]) ["yellow"]));
    }
}
