using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00053Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00053();
        sut.MaxSubArray(new[] {-2, 1, -3, 4, -1, 2, 1, -5, 4}).Should().Be(6);
    }

    [Test]
    public void T2()
    {
        var sut = new S00053();
        sut.MaxSubArray(new[] {1}).Should().Be(1);
    }

    [Test]
    public void T3()
    {
        var sut = new S00053();
        sut.MaxSubArray(new[] {5,4,-1,7,8}).Should().Be(23);
    }
}