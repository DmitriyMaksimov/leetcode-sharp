using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02129Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02129();
        Assert.That(sut.CapitalizeTitle("capiTalIze tHe titLe"), Is.EqualTo("Capitalize The Title"));
    }

    [Test]
    public void T2()
    {
        var sut = new S02129();
        Assert.That(sut.CapitalizeTitle("First leTTeR of EACH Word"), Is.EqualTo("First Letter of Each Word"));
    }

    [Test]
    public void T3()
    {
        var sut = new S02129();
        Assert.That(sut.CapitalizeTitle("i lOve leetcode"), Is.EqualTo("i Love Leetcode"));
    }
}