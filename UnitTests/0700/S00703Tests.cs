using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00703Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00703.KthLargest(3, new[] {4, 5, 8, 2});
        sut.Add(3).Should().Be(4);
        sut.Add(5).Should().Be(5);
        sut.Add(10).Should().Be(5);
        sut.Add(9).Should().Be(8);
        sut.Add(4).Should().Be(8);
    }
}