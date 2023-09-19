using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02243Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02243();
        sut.DigitSum("11111222223", 3).Should().Be("135");
    }

    [Test]
    public void T2()
    {
        var sut = new S02243();
        sut.DigitSum("00000000", 3).Should().Be("000");
    }
}