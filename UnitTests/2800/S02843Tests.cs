using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02843Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02843();
        sut.CountSymmetricIntegers(1, 100).Should().Be(9);
    }

    [Test]
    public void T2()
    {
        var sut = new S02843();
        sut.CountSymmetricIntegers(1200, 1230).Should().Be(4);
    }
}