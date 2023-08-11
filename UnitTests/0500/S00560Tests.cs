using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00560Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00560();
        sut.SubarraySum(new[] {1, 1, 1}, 2).Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S00560();
        sut.SubarraySum(new[] {1, 2, 3}, 3).Should().Be(2);
    }
}