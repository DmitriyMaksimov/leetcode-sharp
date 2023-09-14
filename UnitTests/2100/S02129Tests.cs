using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02129Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02129();
        sut.CapitalizeTitle("capiTalIze tHe titLe").Should().Be("Capitalize The Title");
    }

    [Test]
    public void T2()
    {
        var sut = new S02129();
        sut.CapitalizeTitle("First leTTeR of EACH Word").Should().Be("First Letter of Each Word");
    }

    [Test]
    public void T3()
    {
        var sut = new S02129();
        sut.CapitalizeTitle("i lOve leetcode").Should().Be("i Love Leetcode");
    }
}