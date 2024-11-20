using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02240Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02240();
        sut.WaysToBuyPensPencils(20, 10, 5).Should().Be(9);
    }

    [Test]
    public void T2()
    {
        var sut = new S02240();
        sut.WaysToBuyPensPencils(5, 10, 10).Should().Be(1);
    }
}
