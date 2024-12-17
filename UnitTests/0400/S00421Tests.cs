using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00421Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00421();
        sut.FindMaximumXOR([3, 10, 5, 25, 2, 8]).Should().Be(28);
    }

    [Test]
    public void T2()
    {
        var sut = new S00421();
        sut.FindMaximumXOR([14, 70, 53, 83, 49, 91, 36, 80, 92, 51, 66, 70]).Should().Be(127);
    }
}
