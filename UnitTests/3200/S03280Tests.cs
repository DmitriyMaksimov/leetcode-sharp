using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03280Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03280();
        Assert.That(sut.ConvertDateToBinary("2080-02-29"), Is.EqualTo("100000100000-10-11101"));
    }

    [Test]
    public void T2()
    {
        var sut = new S03280();
        Assert.That(sut.ConvertDateToBinary("1900-01-01"), Is.EqualTo("11101101100-1-1"));
    }
}
