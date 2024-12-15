using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00357Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00357();
        sut.CountNumbersWithUniqueDigits(2).Should().Be(91);
    }

    [Test]
    public void T2()
    {
        var sut = new S00357();
        sut.CountNumbersWithUniqueDigits(0).Should().Be(1);
    }
}
