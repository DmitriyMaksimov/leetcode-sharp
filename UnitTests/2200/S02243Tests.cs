using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02243Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02243();
        Assert.That(sut.DigitSum("11111222223", 3), Is.EqualTo("135"));
    }

    [Test]
    public void T2()
    {
        var sut = new S02243();
        Assert.That(sut.DigitSum("00000000", 3), Is.EqualTo("000"));
    }
}