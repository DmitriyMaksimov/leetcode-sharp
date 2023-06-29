using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00338Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00338();
        sut.CountBits(2).Should().Equal(0, 1, 1);
    }

    [Test]
    public void T2()
    {
        var sut = new S00338();
        sut.CountBits(5).Should().Equal(0, 1, 1, 2, 1, 2);
    }
}