using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00537Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00537();
        Assert.That(sut.ComplexNumberMultiply("1+1i", "1+1i"), Is.EqualTo("0+2i"));
    }

    [Test]
    public void T2()
    {
        var sut = new S00537();
        Assert.That(sut.ComplexNumberMultiply("1+-1i", "1+-1i"), Is.EqualTo("0+-2i"));
    }
}