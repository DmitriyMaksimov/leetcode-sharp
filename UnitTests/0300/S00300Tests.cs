using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00300Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00300();
        sut.LengthOfLIS(new[] {10, 9, 2, 5, 3, 7, 101, 18}).Should().Be(4);
    }

    [Test]
    public void T2()
    {
        var sut = new S00300();
        sut.LengthOfLIS(new[] {0, 1, 0, 3, 2, 3}).Should().Be(4);
    }

    [Test]
    public void T3()
    {
        var sut = new S00300();
        sut.LengthOfLIS(new[] {7, 7, 7, 7, 7, 7, 7}).Should().Be(1);
    }
}