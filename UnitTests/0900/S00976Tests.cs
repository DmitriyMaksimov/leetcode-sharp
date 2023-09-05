using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00976Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00976();
        sut.LargestPerimeter(new[] {2, 1, 2}).Should().Be(5);
    }

    [Test]
    public void T2()
    {
        var sut = new S00976();
        sut.LargestPerimeter(new[] {1, 2, 1, 10}).Should().Be(0);
    }
}