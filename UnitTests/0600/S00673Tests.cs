using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00673Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00673();
        sut.FindNumberOfLIS(new[] {1, 3, 5, 4, 7}).Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S00673();
        sut.FindNumberOfLIS(new[] {2, 2, 2, 2, 2}).Should().Be(5);
    }
}