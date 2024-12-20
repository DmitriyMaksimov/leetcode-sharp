using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00371Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00371();
        sut.GetSum(1, 2).Should().Be(3);
    }

    [Test]
    public void T2()
    {
        var sut = new S00371();
        sut.GetSum(2, 3).Should().Be(5);
    }
}
