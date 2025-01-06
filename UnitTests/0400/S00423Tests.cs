using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00423Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00423();
        sut.OriginalDigits("owoztneoer").Should().Be("012");
    }

    [Test]
    public void T2()
    {
        var sut = new S00423();
        sut.OriginalDigits("fviefuro").Should().Be("45");
    }
}
