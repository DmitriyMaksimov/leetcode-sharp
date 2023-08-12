using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00084Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00084();
        sut.LargestRectangleArea(new[] {2, 1, 5, 6, 2, 3}).Should().Be(10);
    }

    [Test]
    public void T2()
    {
        var sut = new S00084();
        sut.LargestRectangleArea(new[] {2, 4}).Should().Be(4);
    }
}