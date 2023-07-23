using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00137Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00137();
        sut.SingleNumber(new[] {2, 2, 3, 2}).Should().Be(3);
    }

    [Test]
    public void T2()
    {
        var sut = new S00137();
        sut.SingleNumber(new[] {0, 1, 0, 1, 0, 1, 99}).Should().Be(99);
    }
}