using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00918Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00918();
        sut.MaxSubarraySumCircular(new[] {1, -2, 3, -2}).Should().Be(3);
    }

    [Test]
    public void T2()
    {
        var sut = new S00918();
        sut.MaxSubarraySumCircular(new[] {5, -3, 5}).Should().Be(10);
    }

    [Test]
    public void T3()
    {
        var sut = new S00918();
        sut.MaxSubarraySumCircular(new[] {-3, -2, -3}).Should().Be(-2);
    }
}