using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00136Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00136();
        sut.SingleNumber(new[] {2, 2, 1}).Should().Be(1);
    }

    [Test]
    public void T2()
    {
        var sut = new S00136();
        sut.SingleNumber(new[] {4, 1, 2, 1, 2}).Should().Be(4);
    }
}