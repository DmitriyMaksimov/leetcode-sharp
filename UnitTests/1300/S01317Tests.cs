using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01317Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01317();
        sut.GetNoZeroIntegers(2).Should().Equal(1, 1);
    }

    [Test]
    public void T2()
    {
        var sut = new S01317();
        sut.GetNoZeroIntegers(11).Should().Equal(2, 9);
    }
}