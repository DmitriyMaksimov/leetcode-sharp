using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00674Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00674();
        sut.FindLengthOfLCIS(new[] {1, 3, 5, 4, 7}).Should().Be(3);
    }

    [Test]
    public void T2()
    {
        var sut = new S00674();
        sut.FindLengthOfLCIS(new[] {2, 2, 2, 2, 2}).Should().Be(1);
    }
}