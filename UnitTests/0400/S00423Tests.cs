using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00423Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00423();
        Assert.That(sut.OriginalDigits("owoztneoer"), Is.EqualTo("012"));
    }

    [Test]
    public void T2()
    {
        var sut = new S00423();
        Assert.That(sut.OriginalDigits("fviefuro"), Is.EqualTo("45"));
    }
}
