using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00485Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00485();
        sut.FindMaxConsecutiveOnes(new[] {1, 1, 0, 1, 1, 1}).Should().Be(3);
    }

    [Test]
    public void T2()
    {
        var sut = new S00485();
        sut.FindMaxConsecutiveOnes(new[] {1, 0, 1, 1, 0, 1}).Should().Be(2);
    }
}