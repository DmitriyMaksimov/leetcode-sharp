using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01980Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01980();
        Assert.That(sut.FindDifferentBinaryString(new[] {"01", "10"}), Is.EqualTo("11"));
    }

    [Test]
    public void T2()
    {
        var sut = new S01980();
        Assert.That(sut.FindDifferentBinaryString(new[] {"00", "01"}), Is.EqualTo("10"));
    }

    [Test]
    public void T3()
    {
        var sut = new S01980();
        Assert.That(sut.FindDifferentBinaryString(new[] {"111", "011", "001"}), Is.EqualTo("000"));
    }
}